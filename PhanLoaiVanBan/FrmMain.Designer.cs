namespace PhanLoaiVanBan
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.RibbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.rbnMain = new DevComponents.DotNetBar.RibbonPanel();
            this.RibbonBarRestaurent = new DevComponents.DotNetBar.RibbonBar();
            this.btnImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFromFile = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonPanel8 = new DevComponents.DotNetBar.RibbonPanel();
            this.RibbonBarSystem = new DevComponents.DotNetBar.RibbonBar();
            this.btnCateogry = new DevComponents.DotNetBar.ButtonItem();
            this.btnStopWord = new DevComponents.DotNetBar.ButtonItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnTraining = new DevComponents.DotNetBar.ButtonItem();
            this.btnClassify = new DevComponents.DotNetBar.ButtonItem();
            this.rbtShop = new DevComponents.DotNetBar.RibbonTabItem();
            this.RibbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbtSystem = new DevComponents.DotNetBar.RibbonTabItem();
            this.Office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.btnItemExit = new DevComponents.DotNetBar.ButtonItem();
            this.cmdLanguage = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonControl1.SuspendLayout();
            this.rbnMain.SuspendLayout();
            this.RibbonPanel8.SuspendLayout();
            this.RibbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RibbonControl1
            // 
            this.RibbonControl1.CanCustomize = false;
            this.RibbonControl1.CaptionVisible = true;
            this.RibbonControl1.Controls.Add(this.rbnMain);
            this.RibbonControl1.Controls.Add(this.RibbonPanel8);
            this.RibbonControl1.Controls.Add(this.RibbonPanel1);
            this.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RibbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtShop,
            this.RibbonTabItem1,
            this.rbtSystem});
            this.RibbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl1.Name = "RibbonControl1";
            this.RibbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.RibbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Office2007StartButton1,
            this.cmdLanguage});
            this.RibbonControl1.Size = new System.Drawing.Size(1139, 154);
            this.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonControl1.TabGroupHeight = 14;
            this.RibbonControl1.TabIndex = 3;
            // 
            // rbnMain
            // 
            this.rbnMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbnMain.Controls.Add(this.RibbonBarRestaurent);
            this.rbnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnMain.Location = new System.Drawing.Point(0, 55);
            this.rbnMain.Name = "rbnMain";
            this.rbnMain.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rbnMain.Size = new System.Drawing.Size(1139, 97);
            this.rbnMain.TabIndex = 1;
            // 
            // RibbonBarRestaurent
            // 
            this.RibbonBarRestaurent.AutoOverflowEnabled = true;
            this.RibbonBarRestaurent.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBarRestaurent.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnImport,
            this.btnFromFile});
            this.RibbonBarRestaurent.ItemSpacing = 5;
            this.RibbonBarRestaurent.Location = new System.Drawing.Point(3, 0);
            this.RibbonBarRestaurent.Name = "RibbonBarRestaurent";
            this.RibbonBarRestaurent.Padding = new System.Windows.Forms.Padding(5);
            this.RibbonBarRestaurent.ResizeItemsToFit = false;
            this.RibbonBarRestaurent.Size = new System.Drawing.Size(199, 94);
            this.RibbonBarRestaurent.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonBarRestaurent.TabIndex = 0;
            this.RibbonBarRestaurent.Text = "Thêm mới văn bản";
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImagePaddingHorizontal = 8;
            this.btnImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImport.Name = "btnImport";
            this.btnImport.SubItemsExpandWidth = 14;
            this.btnImport.Text = "&Thêm mới trực tiếp";
            this.btnImport.Click += new System.EventHandler(this.btnThemVanBan_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.Image = global::PhanLoaiVanBan.Properties.Resources.BitTorrent132;
            this.btnFromFile.ImagePaddingHorizontal = 30;
            this.btnFromFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.SubItemsExpandWidth = 14;
            this.btnFromFile.Text = "&Thêm mới từ file";
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // RibbonPanel8
            // 
            this.RibbonPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonPanel8.Controls.Add(this.RibbonBarSystem);
            this.RibbonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonPanel8.Location = new System.Drawing.Point(0, 55);
            this.RibbonPanel8.Name = "RibbonPanel8";
            this.RibbonPanel8.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RibbonPanel8.Size = new System.Drawing.Size(1139, 97);
            this.RibbonPanel8.TabIndex = 9;
            this.RibbonPanel8.Visible = false;
            // 
            // RibbonBarSystem
            // 
            this.RibbonBarSystem.AutoOverflowEnabled = true;
            this.RibbonBarSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonBarSystem.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCateogry,
            this.btnStopWord,
            this.btnAbout});
            this.RibbonBarSystem.ItemSpacing = 5;
            this.RibbonBarSystem.Location = new System.Drawing.Point(3, 0);
            this.RibbonBarSystem.Name = "RibbonBarSystem";
            this.RibbonBarSystem.Size = new System.Drawing.Size(1133, 94);
            this.RibbonBarSystem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonBarSystem.TabIndex = 4;
            // 
            // btnCateogry
            // 
            this.btnCateogry.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCateogry.FixedSize = new System.Drawing.Size(300, 0);
            this.btnCateogry.Image = ((System.Drawing.Image)(resources.GetObject("btnCateogry.Image")));
            this.btnCateogry.ImagePaddingHorizontal = 30;
            this.btnCateogry.ImagePaddingVertical = 8;
            this.btnCateogry.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCateogry.Name = "btnCateogry";
            this.btnCateogry.SubItemsExpandWidth = 14;
            this.btnCateogry.Text = "Danh mục lớp";
            this.btnCateogry.Click += new System.EventHandler(this.btnCateogry_Click);
            // 
            // btnStopWord
            // 
            this.btnStopWord.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStopWord.FixedSize = new System.Drawing.Size(300, 0);
            this.btnStopWord.Image = ((System.Drawing.Image)(resources.GetObject("btnStopWord.Image")));
            this.btnStopWord.ImagePaddingHorizontal = 30;
            this.btnStopWord.ImagePaddingVertical = 8;
            this.btnStopWord.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStopWord.Name = "btnStopWord";
            this.btnStopWord.SubItemsExpandWidth = 14;
            this.btnStopWord.Text = "Từ dừng";
            this.btnStopWord.Click += new System.EventHandler(this.btnStopWord_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BeginGroup = true;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImagePaddingHorizontal = 30;
            this.btnAbout.ImagePaddingVertical = 8;
            this.btnAbout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SubItemsExpandWidth = 14;
            this.btnAbout.Text = "Thông tin liên hệ";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // RibbonPanel1
            // 
            this.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonPanel1.Controls.Add(this.RibbonBar1);
            this.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.RibbonPanel1.Name = "RibbonPanel1";
            this.RibbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RibbonPanel1.Size = new System.Drawing.Size(1139, 97);
            this.RibbonPanel1.TabIndex = 10;
            this.RibbonPanel1.Visible = false;
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTraining,
            this.btnClassify});
            this.RibbonBar1.Location = new System.Drawing.Point(3, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(172, 94);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.RibbonBar1.TabIndex = 0;
            this.RibbonBar1.Text = "Naive Bayes";
            // 
            // btnTraining
            // 
            this.btnTraining.Image = global::PhanLoaiVanBan.Properties.Resources.Tokhai_Edit32;
            this.btnTraining.ImagePaddingHorizontal = 30;
            this.btnTraining.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.SubItemsExpandWidth = 14;
            this.btnTraining.Text = "Huấn luyện";
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnClassify
            // 
            this.btnClassify.Image = ((System.Drawing.Image)(resources.GetObject("btnClassify.Image")));
            this.btnClassify.ImagePaddingHorizontal = 30;
            this.btnClassify.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.SubItemsExpandWidth = 14;
            this.btnClassify.Text = "Phân loại";
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // rbtShop
            // 
            this.rbtShop.Checked = true;
            this.rbtShop.ImagePaddingHorizontal = 8;
            this.rbtShop.Name = "rbtShop";
            this.rbtShop.Panel = this.rbnMain;
            this.rbtShop.Text = "&Nhập liệu";
            // 
            // RibbonTabItem1
            // 
            this.RibbonTabItem1.ImagePaddingHorizontal = 8;
            this.RibbonTabItem1.Name = "RibbonTabItem1";
            this.RibbonTabItem1.Panel = this.RibbonPanel1;
            this.RibbonTabItem1.Text = "Xử lý văn bản";
            // 
            // rbtSystem
            // 
            this.rbtSystem.ImagePaddingHorizontal = 8;
            this.rbtSystem.Name = "rbtSystem";
            this.rbtSystem.Panel = this.RibbonPanel8;
            this.rbtSystem.Text = "&Hệ thống";
            // 
            // Office2007StartButton1
            // 
            this.Office2007StartButton1.AutoExpandOnClick = true;
            this.Office2007StartButton1.CanCustomize = false;
            this.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.Office2007StartButton1.Image = ((System.Drawing.Image)(resources.GetObject("Office2007StartButton1.Image")));
            this.Office2007StartButton1.ImagePaddingHorizontal = 2;
            this.Office2007StartButton1.ImagePaddingVertical = 2;
            this.Office2007StartButton1.Name = "Office2007StartButton1";
            this.Office2007StartButton1.ShowSubItems = false;
            this.Office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemExit});
            // 
            // btnItemExit
            // 
            this.btnItemExit.BeginGroup = true;
            this.btnItemExit.Image = global::PhanLoaiVanBan.Properties.Resources.WinXPSetV4_Icon_17;
            this.btnItemExit.ImagePaddingHorizontal = 8;
            this.btnItemExit.Name = "btnItemExit";
            this.btnItemExit.Text = "Kết thúc chương trình";
            this.btnItemExit.Click += new System.EventHandler(this.btnItemExit_Click);
            // 
            // cmdLanguage
            // 
            this.cmdLanguage.ImagePaddingHorizontal = 8;
            this.cmdLanguage.Name = "cmdLanguage";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 625);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân loại văn bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.RibbonControl1.ResumeLayout(false);
            this.RibbonControl1.PerformLayout();
            this.rbnMain.ResumeLayout(false);
            this.RibbonPanel8.ResumeLayout(false);
            this.RibbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion       

        internal DevComponents.DotNetBar.RibbonControl RibbonControl1;
        internal DevComponents.DotNetBar.RibbonPanel RibbonPanel1;
        internal DevComponents.DotNetBar.RibbonBar RibbonBar1;
        internal DevComponents.DotNetBar.ButtonItem btnTraining;
        internal DevComponents.DotNetBar.ButtonItem btnClassify;
        internal DevComponents.DotNetBar.RibbonPanel rbnMain;
        internal DevComponents.DotNetBar.RibbonBar RibbonBarRestaurent;
        internal DevComponents.DotNetBar.ButtonItem btnImport;
        internal DevComponents.DotNetBar.ButtonItem btnFromFile;
        internal DevComponents.DotNetBar.RibbonPanel RibbonPanel8;
        internal DevComponents.DotNetBar.RibbonBar RibbonBarSystem;
        internal DevComponents.DotNetBar.ButtonItem btnStopWord;
        internal DevComponents.DotNetBar.ButtonItem btnAbout;
        internal DevComponents.DotNetBar.RibbonTabItem rbtShop;
        internal DevComponents.DotNetBar.RibbonTabItem RibbonTabItem1;
        internal DevComponents.DotNetBar.RibbonTabItem rbtSystem;
        internal DevComponents.DotNetBar.Office2007StartButton Office2007StartButton1;
        internal DevComponents.DotNetBar.ButtonItem btnItemExit;
        internal DevComponents.DotNetBar.ButtonItem cmdLanguage;
        internal DevComponents.DotNetBar.ButtonItem btnCateogry;







    }
}