using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhanLoaiVanBan.DataAccess.Linq;
using PhanLoaiVanBan.DataAccess;
namespace PhanLoaiVanBan.DocumentProcessing
{
    public class DocumentAnalyzer
    {
        public delegate void NaiveBayesProgressChangedHandler(Object sender, NaiveBayesEventArgs e);
        public event NaiveBayesProgressChangedHandler NaiveBayesProgressChanged;

        public void Analyze(Document doc)
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            try
            {
                l.BeginTransaction();
                l.Insert(doc);
                List<String> words = GetListOfWordInDoc(doc);
                NaiveBayesEventArgs e = new NaiveBayesEventArgs();
                e.TotalWord = words.Count;
                foreach (String w in words)
                {
                    e.Word = w;
                    e.CurrentWord += 1;
                    if (NaiveBayesProgressChanged != null)
                        NaiveBayesProgressChanged(this, e);

                    if (w.Trim() == String.Empty)
                    {
                        continue;
                    }
                    String correctWord = w.Trim();
                    var wordInDoc = l.GetTable<WordInDocument>().Where(m => m.Word == correctWord && m.DocID == doc.DocID).SingleOrDefault();
                    if (wordInDoc != null)
                    {
                        wordInDoc.Number += 1;
                        l.Update(wordInDoc, m => m.Word == correctWord && m.DocID == doc.DocID);
                    }
                    else
                    {
                        wordInDoc = new WordInDocument()
                        {
                            DocID = doc.DocID,
                            Word = correctWord.Trim(),
                            Number = 1
                        };
                        l.Insert(wordInDoc);
                    }
                }
            }
            catch (Exception ex)
            {
                l.Transaction.RollbackAndDispose();
                throw ex;
            }
            l.Transaction.CommitAndDispose();

        }

        public List<string> GetListOfWordInDoc(string document)
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            var stopWords = l.GetTable<StopWord>().ToList();
            foreach (StopWord s in stopWords)
            {
                document = document.Replace(s.Word, "");
            }
            return new List<String>(document.Split(' '));
        }

        public List<string> GetListOfWordInDoc(Document document)
        {
            String data = document.Content.Trim().ToUpper();
            data = data.Replace(Environment.NewLine, "");
            data = data.Replace("[", "");
            data = data.Replace("]", "|");
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            var stopWords = l.GetTable<StopWord>().ToList();
            foreach (StopWord s in stopWords)
            {
                data = data.Replace(s.Word, "");
            }
            List<String> result = new List<String>(data.Split('|')).Where(q => q.Trim() != String.Empty).ToList();            
            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].Trim();
            }
            return result;
        }

    }
}
