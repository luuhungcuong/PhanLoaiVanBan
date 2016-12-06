using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanLoaiVanBan.DataAccess.Linq;
using PhanLoaiVanBan.DataAccess;
using PhanLoaiVanBan.DocumentProcessing;
namespace PhanLoaiVanBan
{
    public partial class FrmImport : Form
    {
        public FrmImport()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            cbbCategory.DisplayMember = "CateName";
            cbbCategory.ValueMember = "CateID";
            cbbCategory.DataSource = l.GetTable<Category>();
        }

        Document d;
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            d = new Document
            {
                CateID = (int)cbbCategory.SelectedValue,
                Content = txtDocument.Text
            };
            if (bgwImport.IsBusy)
            {
                MessageBox.Show("System is already running!");
                return;
            }
            bgwImport.RunWorkerAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDocument.Text = String.Empty;
        }

        private void bgwImport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {               
                DocumentProcessing.DocumentAnalyzer da = new DocumentProcessing.DocumentAnalyzer();
                da.NaiveBayesProgressChanged += new DocumentAnalyzer.NaiveBayesProgressChangedHandler(da_NaiveBayesProgressChanged);
                da.Analyze(d);
                MessageBox.Show("Document is analyzed successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void da_NaiveBayesProgressChanged(object sender, NaiveBayesEventArgs e)
        {
            int percent = (int)((e.CurrentCagegory * 1.0 / e.TotalCategory) * 100);
            bgwImport.ReportProgress(percent, e);
        }

        private void bgwImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            NaiveBayesEventArgs agrs = (NaiveBayesEventArgs)e.UserState;
            pgbImport.Value = agrs.CurrentWord;
            pgbImport.Maximum = agrs.TotalWord;
            lblStatus.Text = "Processing word:" + agrs.Word;
        }

     
    }
}
