namespace PhanLoaiVanBan
{
    partial class FrmImportFromFile
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
            this.btnImports = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdImportFile = new System.Windows.Forms.FolderBrowserDialog();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pgbFile = new System.Windows.Forms.ProgressBar();
            this.bgwImport = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImports
            // 
            this.btnImports.Location = new System.Drawing.Point(449, 69);
            this.btnImports.Name = "btnImports";
            this.btnImports.Size = new System.Drawing.Size(75, 23);
            this.btnImports.TabIndex = 0;
            this.btnImports.Text = "Import";
            this.btnImports.UseVisualStyleBackColor = true;
            this.btnImports.Click += new System.EventHandler(this.btnImports_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(5, 25);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(471, 20);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(484, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "EDUCATION",
            "ICT",
            "SCIENCE",
            "ECONOMIC"});
            this.cbbCategory.Location = new System.Drawing.Point(5, 71);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(181, 21);
            this.cbbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(2, 48);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // pgbFile
            // 
            this.pgbFile.Location = new System.Drawing.Point(-3, 132);
            this.pgbFile.Name = "pgbFile";
            this.pgbFile.Size = new System.Drawing.Size(528, 23);
            this.pgbFile.TabIndex = 6;
            // 
            // bgwImport
            // 
            this.bgwImport.WorkerReportsProgress = true;
            this.bgwImport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwImport_DoWork);
            this.bgwImport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwImport_ProgressChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(2, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 7;
            // 
            // FrmImportFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 156);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pgbFile);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnImports);
            this.Name = "FrmImportFromFile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImportFromFile";
            this.Load += new System.EventHandler(this.FrmImportFromFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImports;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdImportFile;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ProgressBar pgbFile;
        private System.ComponentModel.BackgroundWorker bgwImport;
        private System.Windows.Forms.Label lblStatus;
    }
}