using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanLoaiVanBan.DocumentProcessing;
namespace PhanLoaiVanBan
{
    public partial class FrmTraining : Form
    {
        public FrmTraining()
        {
            InitializeComponent();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            lblStatusCate.Text = "Initializing...";
            if (bgwTraining.IsBusy)
            {
                MessageBox.Show("System is already running!");
                return;
            }
            bgwTraining.RunWorkerAsync();            
        }

        private void bgwTraining_DoWork(object sender, DoWorkEventArgs e)
        {
            PhanLoaiVanBan.DocumentProcessing.NaiveBayes nb = new DocumentProcessing.NaiveBayes();
            nb.NaiveBayesProgressChanged += new NaiveBayes.NaiveBayesProgressChangedHandler(nb_NaiveBayesProgressChanged);
            nb.Training();
            MessageBox.Show("Training is completed");
        }

        void nb_NaiveBayesProgressChanged(object sender, NaiveBayesEventArgs e)
        {
            int percent = (int)((e.CurrentCagegory * 1.0 / e.TotalCategory) * 100);
            bgwTraining.ReportProgress(percent, e);
        }


        private void bgwTraining_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            NaiveBayesEventArgs agrs = (NaiveBayesEventArgs)e.UserState;
            pgbCate.Value = agrs.CurrentCagegory;
            pgbCate.Maximum = agrs.TotalCategory;
            pgbWord.Value = agrs.CurrentWord;
            pgbWord.Maximum = agrs.TotalWord;
            lblStatusCate.Text = "Processing category:" + agrs.Category;
            lblStatusWord.Text = "Processing word:" + agrs.Word;
        }

        private void bgwTraining_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
