namespace Balaio.Views
{
    partial class FAddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddTable));
            this.lblTblName = new System.Windows.Forms.Label();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.dataGridViewColumns = new System.Windows.Forms.DataGridView();
            this.butCreateTable = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTblName
            // 
            this.lblTblName.AutoSize = true;
            this.lblTblName.Location = new System.Drawing.Point(12, 9);
            this.lblTblName.Name = "lblTblName";
            this.lblTblName.Size = new System.Drawing.Size(38, 13);
            this.lblTblName.TabIndex = 0;
            this.lblTblName.Text = "Name:";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTableName.Location = new System.Drawing.Point(56, 6);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(454, 20);
            this.textBoxTableName.TabIndex = 1;
            // 
            // dataGridViewColumns
            // 
            this.dataGridViewColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumns.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewColumns.Name = "dataGridViewColumns";
            this.dataGridViewColumns.Size = new System.Drawing.Size(498, 252);
            this.dataGridViewColumns.TabIndex = 2;
            // 
            // butCreateTable
            // 
            this.butCreateTable.Location = new System.Drawing.Point(435, 307);
            this.butCreateTable.Name = "butCreateTable";
            this.butCreateTable.Size = new System.Drawing.Size(75, 23);
            this.butCreateTable.TabIndex = 3;
            this.butCreateTable.Text = "Create";
            this.butCreateTable.UseVisualStyleBackColor = true;
            this.butCreateTable.Click += new System.EventHandler(this.butCreateTable_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(15, 307);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // FAddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butCreateTable);
            this.Controls.Add(this.dataGridViewColumns);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.lblTblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTblName;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.DataGridView dataGridViewColumns;
        private System.Windows.Forms.Button butCreateTable;
        private System.Windows.Forms.Button butCancel;
    }
}