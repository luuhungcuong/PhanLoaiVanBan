using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanLoaiVanBan.DataAccess;
using PhanLoaiVanBan.DocumentProcessing;
namespace PhanLoaiVanBan
{
    public partial class FrmClassify : Form
    {
        public FrmClassify()
        {
            InitializeComponent();
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (bgwClassify.IsBusy)
            {
                MessageBox.Show("System is already running!");
                return;
            }
            bgwClassify.RunWorkerAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDocument.Text = String.Empty;
        }

        Category result;
        private void bgwClassify_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                NaiveBayes nb = new NaiveBayes();
                nb.NaiveBayesProgressChanged += new NaiveBayes.NaiveBayesProgressChangedHandler(nb_NaiveBayesProgressChanged);
                Document d = new Document()
                {
                    Content = txtDocument.Text
                };
                result = nb.Classify(d);
                if (result != null || result.CateID != 0)
                    MessageBox.Show(result.CateName);
                else
                    MessageBox.Show("Cannot classified!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void nb_NaiveBayesProgressChanged(object sender, NaiveBayesEventArgs e)
        {
            int percent = (int)((e.CurrentCagegory * 1.0 / e.TotalCategory) * 100);
            bgwClassify.ReportProgress(percent, e);
        }

        private void bgwClassify_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            NaiveBayesEventArgs agrs = (NaiveBayesEventArgs)e.UserState;
            pgbCate.Value = agrs.CurrentCagegory;
            pgbCate.Maximum = agrs.TotalCategory;
            pgbWord.Value = agrs.CurrentWord;
            pgbWord.Maximum = agrs.TotalWord;
            lblStatusCategory.Text = "Processing category:" + agrs.Category;
            lblStatusWord.Text = "Processing word:" + agrs.Word;
            if (agrs.Result != String.Empty)
                lblResult.Text = agrs.Result;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
                txtDocument.Text = System.IO.File.ReadAllText(txtFile.Text).Replace(Environment.NewLine, "");
            }
        }
    }
}
