using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanLoaiVanBan.DataAccess;
using PhanLoaiVanBan.DataAccess.Linq;

namespace PhanLoaiVanBan
{
    public partial class FrmStopWords : Form
    {
        public FrmStopWords()
        {
            InitializeComponent();
        }

        private void FrmStopWords_Load(object sender, EventArgs e)
        {
            BinData();
        }

        private void BinData()
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            List<StopWord> list = l.GetTable<StopWord>().ToList();
            dgvStopWords.AutoGenerateColumns = false;
            dgvStopWords.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            StopWord word = new StopWord()
            {
                Word = txtWord.Text.Trim().ToUpper()
            };
            l.Insert(word);
            BinData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            StopWord word = new StopWord()
            {
                Word = txtWord.Text.Trim().ToUpper()
            };
            l.Update(word, w=>w.Word == word.Word);
            BinData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            LinqHelper<PhanLoaiVanBanDataContext> l = new LinqHelper<PhanLoaiVanBanDataContext>();
            StopWord word = new StopWord()
            {
                Word = txtWord.Text.Trim().ToUpper()
            };
            l.Delete<StopWord>(w => w.Word == word.Word);
            BinData();
        }

        private void dgvStopWords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStopWords.SelectedRows.Count > 0)
            txtWord.Text = dgvStopWords.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
