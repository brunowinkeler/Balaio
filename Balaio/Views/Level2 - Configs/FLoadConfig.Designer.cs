namespace Balaio.Views
{
    partial class FLoadConfig
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC-bruno",
            "Energisa"}, -1);
            this.listViewLoad = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butSave = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLoad
            // 
            this.listViewLoad.AllowColumnReorder = true;
            this.listViewLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLoad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewLoad.FullRowSelect = true;
            listViewItem2.StateImageIndex = 0;
            this.listViewLoad.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewLoad.Location = new System.Drawing.Point(12, 12);
            this.listViewLoad.MultiSelect = false;
            this.listViewLoad.Name = "listViewLoad";
            this.listViewLoad.Size = new System.Drawing.Size(251, 246);
            this.listViewLoad.TabIndex = 0;
            this.listViewLoad.UseCompatibleStateImageBehavior = false;
            this.listViewLoad.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Database";
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.Location = new System.Drawing.Point(12, 268);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(124, 35);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butLoad
            // 
            this.butLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoad.Location = new System.Drawing.Point(142, 268);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(121, 35);
            this.butLoad.TabIndex = 2;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // FLoadConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 315);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.listViewLoad);
            this.Name = "FLoadConfig";
            this.Text = "FLoadConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLoad;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button butLoad;
    }
}