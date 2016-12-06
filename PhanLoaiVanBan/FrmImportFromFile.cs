using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PhanLoaiVanBan.DocumentProcessing;
using PhanLoaiVanBan.DataAccess;
using PhanLoaiVanBan.DataAccess.Linq;

namespace PhanLoaiVanBan
{
    public partial class FrmImportFromFile : Form
    {
        public FrmImportFromFile()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txtFolder.Text == String.Empty)
                fbdImportFile.SelectedPath = Path.GetDirectoryName(Application.StartupPath);
            else
                fbdImportFile.SelectedPath = txtFolder.Text;
            if (fbdImportFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtFolder.Text = fbdImportFile.SelectedPath;
        }

        private int cateID;
        private void btnImports_Click(object sender, EventArgs e)
        {

            if (txtFolder.Text == String.Empty)
            {
                MessageBox.Show("You must to set the import folder fist!!!");
                return;
            }
            cateID = (int)cbbCategory.SelectedValue;
            if (bgwImport.IsBusy)
            {
                MessageBox.Show("System is already running!");
                return;
            }
            bgwImport.RunWorkerAsync();
        }

        private string ReadFromFile(string fileName)
        {
            return File.ReadAllText(fileName).Replace(Environment.NewLine, "");
        }

        private void FrmImportFromFile_Load(object sender, EventArgs e)
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

        private void bgwImport_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(txtFolder.Text, "*.wseg");
            DocumentAnalyzer da = new DocumentAnalyzer();
            int currentFile = 0;
            int totalFile = files.Length;
            foreach (string file in files)
            {
                currentFile++;
                bgwImport.ReportProgress((int)((currentFile * 100.0) / totalFile), String.Format("Procesing ({0}/{1}):{2}",
                    currentFile.ToString(), totalFile.ToString(), Path.GetFileName(file)));
                String content = ReadFromFile(file);
                Document d = new Document()
                {
                    CateID = cateID,
                    Content = content
                };
                da.Analyze(d);
            }
            MessageBox.Show("Documents are imported completely.");
        }

        private void bgwImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = (String)e.UserState;
            pgbFile.Value = e.ProgressPercentage;
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
