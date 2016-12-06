namespace PhanLoaiVanBan
{
    partial class FrmStopWords
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
            this.dgvStopWords = new System.Windows.Forms.DataGridView();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevocationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopWords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStopWords
            // 
            this.dgvStopWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStopWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.RevocationDate});
            this.dgvStopWords.Location = new System.Drawing.Point(12, 66);
            this.dgvStopWords.Name = "dgvStopWords";
            this.dgvStopWords.ReadOnly = true;
            this.dgvStopWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStopWords.Size = new System.Drawing.Size(543, 285);
            this.dgvStopWords.TabIndex = 1;
            this.dgvStopWords.TabStop = false;
            this.dgvStopWords.SelectionChanged += new System.EventHandler(this.dgvStopWords_SelectionChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(52, 28);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(343, 20);
            this.txtWord.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(401, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(13, 31);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 13);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "Word";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(482, 26);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNumber.DataPropertyName = "ID";
            this.SerialNumber.HeaderText = "ID";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // RevocationDate
            // 
            this.RevocationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RevocationDate.DataPropertyName = "Word";
            this.RevocationDate.HeaderText = "Word";
            this.RevocationDate.Name = "RevocationDate";
            this.RevocationDate.ReadOnly = true;
            // 
            // FrmStopWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.dgvStopWords);
            this.Name = "FrmStopWords";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmStopWords";
            this.Load += new System.EventHandler(this.FrmStopWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStopWords;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevocationDate;

    }
}