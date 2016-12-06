namespace PhanLoaiVanBan
{
    partial class FrmCategory
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.dgvStopWords = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevocationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopWords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(472, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(3, 35);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(49, 13);
            this.lblCate.TabIndex = 10;
            this.lblCate.Text = "Category";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(391, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(58, 32);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(327, 20);
            this.txtCateName.TabIndex = 8;
            // 
            // dgvStopWords
            // 
            this.dgvStopWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStopWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.RevocationDate});
            this.dgvStopWords.Location = new System.Drawing.Point(2, 70);
            this.dgvStopWords.Name = "dgvStopWords";
            this.dgvStopWords.ReadOnly = true;
            this.dgvStopWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStopWords.Size = new System.Drawing.Size(543, 285);
            this.dgvStopWords.TabIndex = 7;
            this.dgvStopWords.TabStop = false;
            this.dgvStopWords.SelectionChanged += new System.EventHandler(this.dgvStopWords_SelectionChanged);
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNumber.DataPropertyName = "CateID";
            this.SerialNumber.HeaderText = "ID";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // RevocationDate
            // 
            this.RevocationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RevocationDate.DataPropertyName = "CateName";
            this.RevocationDate.HeaderText = "Category";
            this.RevocationDate.Name = "RevocationDate";
            this.RevocationDate.ReadOnly = true;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 357);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCateName);
            this.Controls.Add(this.dgvStopWords);
            this.Name = "FrmCategory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.DataGridView dgvStopWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevocationDate;
    }
}