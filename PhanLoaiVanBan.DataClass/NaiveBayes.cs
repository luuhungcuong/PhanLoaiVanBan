using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhanLoaiVanBan.DataAccess;
using PhanLoaiVanBan.DataAccess.Linq;
using System.Data;
namespace PhanLoaiVanBan.DocumentProcessing
{
    public class NaiveBayes
    {
        LinqHelper<PhanLoaiVanBanDataContext> l;
        public delegate void NaiveBayesProgressChangedHandler(Object sender, NaiveBayesEventArgs e);
        public event NaiveBayesProgressChangedHandler NaiveBayesProgressChanged;

        public NaiveBayes()
        {
            l = new LinqHelper<PhanLoaiVanBanDataContext>();
        }

        public void Training()
        {
            try
            {
                l.BeginTransaction();
                CaculatorCategoryProbablity();
                CaculatorWordProablity();
            }
            catch (Exception ex)
            {
                l.Transaction.RollbackAndDispose();
                throw ex;
            }
            l.Transaction.CommitAndDispose();
        }

        private void CaculatorWordProablity()
        {
            var lstWord = (from wordInDocument in l.GetTable<WordInDocument>()
                           select wordInDocument.Word).Distinct();
            var lstCategory = from cate in l.GetTable<Category>()
                              select new { cate.CateID, cate.CateName};

            var q = from wordInDoc in l.GetTable<WordInDocument>()
                    join document in l.GetTable<Document>()
                    on wordInDoc.DocID equals document.DocID
                    select new { wordInDoc.DocID, wordInDoc.Word, document.CateID };

            NaiveBayesEventArgs e = new NaiveBayesEventArgs();
            e.TotalCategory = lstCategory.Count();
            e.TotalWord = lstWord.Count();

            foreach (var cate in lstCategory)
            {
                int c = cate.CateID;
                e.CurrentCagegory++;
                e.Category = cate.CateName;
                e.CurrentWord = 0;

                foreach (string word in lstWord) 
                {
                    e.CurrentWord += 1;
                    e.Word = word;
                    if (NaiveBayesProgressChanged != null)
                        NaiveBayesProgressChanged(this, e);

                    ProbWord pw = new ProbWord();
                    int numOfDocWord = q.Count(d => d.Word == word && d.CateID == c);
                    int numOfDoc = l.GetTable<Document>().Count(d => d.CateID == c);
                    pw.CateID = c;
                    pw.Word = word;
                    pw.Probablity = (Decimal)(numOfDocWord + 1) / (numOfDoc + 2);
                    l.Insert(pw);
                }
            }
        }

        private void CaculatorCategoryProbablity()
        {
            l.DeleteAll<ProbCate>();
            l.DeleteAll<ProbWord>();

            var lstCategory = from cate in l.GetTable<Category>()
                              select cate.CateID;
            int numOfCategory = lstCategory.Count();
            int numOfDoc = l.GetTable<Document>().Count();
            foreach (var cateID in lstCategory)
            {
                int numOfDocInCate = l.GetTable<Document>().Where(c => c.CateID == cateID).Count();
                ProbCate pc = new ProbCate()
                {
                    CateID = cateID,
                    Probablity = (decimal)(numOfDocInCate + 1) / (numOfDoc + numOfCategory)
                };
                l.Insert(pc);
            }
        }

        public Category Classify(Document d)
        {
            var lstCategory = from cate in l.GetTable<Category>()
                              select new { cate.CateID, cate.CateName };
            var lstWordInDoc = (new DocumentAnalyzer()).GetListOfWordInDoc(d);
            Double maxProbablity = 0.0;
            Double currentProablity = Math.Pow(10,100); //Avoid the probablity is too small
            Category result = new Category();

                             
            NaiveBayesEventArgs e = new NaiveBayesEventArgs();
            e.TotalCategory = lstCategory.Count();
            e.TotalWord = lstWordInDoc.Count();

            foreach (var cate in lstCategory)
            {
                e.CurrentCagegory++;
                e.Category = cate.CateName;

                int cateID = cate.CateID;                
                Decimal probablity = l.GetOne<ProbCate>(x => x.CateID == cateID).Probablity;
                currentProablity = (double)probablity;

                e.CurrentWord = 0;
                
                foreach (string w in lstWordInDoc)
                {
                    e.CurrentWord += 1;
                    e.Word = w.Trim();                    
                    if (NaiveBayesProgressChanged != null)
                        NaiveBayesProgressChanged(this, e);
                    if (w == String.Empty) continue;
                    ProbWord pw = l.GetOne<ProbWord>(z => z.CateID == cateID && z.Word == w);
                    if (pw == null) continue;
                    if (pw.Probablity == 0)
                    {
                        throw new Exception("Existing proablity equal zero!");
                    }
                    currentProablity *= (double)pw.Probablity;
                    if (currentProablity == 0)
                    {
                        throw new Exception("Please config weight to ensure the proablity is not too small!");
                    }
                }

                if (currentProablity > maxProbablity)
                {
                    maxProbablity = currentProablity;
                    result.CateID = cateID;
                    result.CateName = e.Category;
                    e.Result = result.CateName;
                    if (NaiveBayesProgressChanged != null)
                        NaiveBayesProgressChanged(this, e);
                }
            }           
            return result;
        }
    }
}
