using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanLoaiVanBan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnThemVanBan_Click(object sender, EventArgs e)
        {
            FrmImport imp = new FrmImport();
            imp.ShowDialog();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            FrmTraining tr = new FrmTraining();
            tr.ShowDialog();
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            FrmClassify frm = new FrmClassify();
            frm.ShowDialog();
        }

       
        private void btnItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            FrmImportFromFile frm = new FrmImportFromFile();
            frm.ShowDialog();
        }

        private void btnStopWord_Click(object sender, EventArgs e)
        {
            FrmStopWords frm = new FrmStopWords();
            frm.ShowDialog();
        }

        private void btnCateogry_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

      
        
    }
}
