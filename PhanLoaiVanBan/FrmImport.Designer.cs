namespace PhanLoaiVanBan
{
    partial class FrmImport
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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.bgwImport = new System.ComponentModel.BackgroundWorker();
            this.pgbImport = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(584, 22);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(3, 62);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDocument.Size = new System.Drawing.Size(656, 282);
            this.txtDocument.TabIndex = 1;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "EDUCATION",
            "ICT",
            "SCIENCE",
            "ECONOMIC"});
            this.cbbCategory.Location = new System.Drawing.Point(3, 24);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(575, 21);
            this.cbbCategory.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(584, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bgwImport
            // 
            this.bgwImport.WorkerReportsProgress = true;
            this.bgwImport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwImport_DoWork);
            this.bgwImport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwImport_ProgressChanged);
            
            // 
            // pgbImport
            // 
            this.pgbImport.Location = new System.Drawing.Point(0, 379);
            this.pgbImport.Name = "pgbImport";
            this.pgbImport.Size = new System.Drawing.Size(659, 23);
            this.pgbImport.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 360);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 405);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pgbImport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.btnAnalyze);
            this.Name = "FrmImport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import document";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Button btnClear;
        private System.ComponentModel.BackgroundWorker bgwImport;
        private System.Windows.Forms.ProgressBar pgbImport;
        private System.Windows.Forms.Label lblStatus;
    }
}

