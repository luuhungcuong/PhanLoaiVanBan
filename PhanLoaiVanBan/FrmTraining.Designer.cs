namespace PhanLoaiVanBan
{
    partial class FrmTraining
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
            this.btnTraining = new System.Windows.Forms.Button();
            this.bgwTraining = new System.ComponentModel.BackgroundWorker();
            this.pgbWord = new System.Windows.Forms.ProgressBar();
            this.pgbCate = new System.Windows.Forms.ProgressBar();
            this.lblStatusCate = new System.Windows.Forms.Label();
            this.lblStatusWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(377, 38);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(75, 23);
            this.btnTraining.TabIndex = 0;
            this.btnTraining.Text = "Training";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // bgwTraining
            // 
            this.bgwTraining.WorkerReportsProgress = true;
            this.bgwTraining.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTraining_DoWork);
            this.bgwTraining.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwTraining_ProgressChanged);
            this.bgwTraining.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTraining_RunWorkerCompleted);
            // 
            // pgbWord
            // 
            this.pgbWord.Location = new System.Drawing.Point(-1, 123);
            this.pgbWord.Name = "pgbWord";
            this.pgbWord.Size = new System.Drawing.Size(469, 23);
            this.pgbWord.TabIndex = 1;
            // 
            // pgbCate
            // 
            this.pgbCate.Location = new System.Drawing.Point(-1, 81);
            this.pgbCate.Name = "pgbCate";
            this.pgbCate.Size = new System.Drawing.Size(469, 23);
            this.pgbCate.TabIndex = 2;
            // 
            // lblStatusCate
            // 
            this.lblStatusCate.AutoSize = true;
            this.lblStatusCate.Location = new System.Drawing.Point(1, 65);
            this.lblStatusCate.Name = "lblStatusCate";
            this.lblStatusCate.Size = new System.Drawing.Size(0, 13);
            this.lblStatusCate.TabIndex = 3;
            // 
            // lblStatusWord
            // 
            this.lblStatusWord.AutoSize = true;
            this.lblStatusWord.Location = new System.Drawing.Point(1, 107);
            this.lblStatusWord.Name = "lblStatusWord";
            this.lblStatusWord.Size = new System.Drawing.Size(0, 13);
            this.lblStatusWord.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please press the traning button to start training!";
            // 
            // FrmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusWord);
            this.Controls.Add(this.lblStatusCate);
            this.Controls.Add(this.pgbCate);
            this.Controls.Add(this.pgbWord);
            this.Controls.Add(this.btnTraining);
            this.Name = "FrmTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraining;
        private System.ComponentModel.BackgroundWorker bgwTraining;
        private System.Windows.Forms.ProgressBar pgbWord;
        private System.Windows.Forms.ProgressBar pgbCate;
        private System.Windows.Forms.Label lblStatusCate;
        private System.Windows.Forms.Label lblStatusWord;
        private System.Windows.Forms.Label label1;
    }
}