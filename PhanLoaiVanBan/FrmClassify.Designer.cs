namespace PhanLoaiVanBan
{
    partial class FrmClassify
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
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pgbWord = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusCategory = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pgbCate = new System.Windows.Forms.ProgressBar();
            this.lblStatusWord = new System.Windows.Forms.Label();
            this.bgwClassify = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnClassify
            // 
            this.btnClassify.Location = new System.Drawing.Point(582, 17);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(75, 23);
            this.btnClassify.TabIndex = 0;
            this.btnClassify.Text = "Classify";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(0, 56);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDocument.Size = new System.Drawing.Size(657, 333);
            this.txtDocument.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(503, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pgbWord
            // 
            this.pgbWord.Location = new System.Drawing.Point(0, 463);
            this.pgbWord.Name = "pgbWord";
            this.pgbWord.Size = new System.Drawing.Size(657, 23);
            this.pgbWord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Document:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // lblStatusCategory
            // 
            this.lblStatusCategory.AutoSize = true;
            this.lblStatusCategory.Location = new System.Drawing.Point(-3, 404);
            this.lblStatusCategory.Name = "lblStatusCategory";
            this.lblStatusCategory.Size = new System.Drawing.Size(16, 13);
            this.lblStatusCategory.TabIndex = 7;
            this.lblStatusCategory.Text = "...";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(33, 392);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Unclassified";
            // 
            // pgbCate
            // 
            this.pgbCate.Location = new System.Drawing.Point(0, 420);
            this.pgbCate.Name = "pgbCate";
            this.pgbCate.Size = new System.Drawing.Size(657, 23);
            this.pgbCate.TabIndex = 9;
            // 
            // lblStatusWord
            // 
            this.lblStatusWord.AutoSize = true;
            this.lblStatusWord.Location = new System.Drawing.Point(-3, 447);
            this.lblStatusWord.Name = "lblStatusWord";
            this.lblStatusWord.Size = new System.Drawing.Size(16, 13);
            this.lblStatusWord.TabIndex = 11;
            this.lblStatusWord.Text = "...";
            // 
            // bgwClassify
            // 
            this.bgwClassify.WorkerReportsProgress = true;
            this.bgwClassify.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClassify_DoWork);
            this.bgwClassify.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwClassify_ProgressChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "From file:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(460, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(0, 17);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(454, 20);
            this.txtFile.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.wseg";
            this.openFileDialog.Filter = "(wseg file)|*.wseg";
            // 
            // FrmClassify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblStatusWord);
            this.Controls.Add(this.pgbCate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblStatusCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbWord);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.btnClassify);
            this.Name = "FrmClassify";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClassify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar pgbWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatusCategory;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar pgbCate;
        private System.Windows.Forms.Label lblStatusWord;
        private System.ComponentModel.BackgroundWorker bgwClassify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}