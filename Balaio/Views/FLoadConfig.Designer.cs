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
            this.listViewLoad = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butCancel = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLoad
            // 
            this.listViewLoad.AllowColumnReorder = true;
            this.listViewLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLoad.BackColor = System.Drawing.SystemColors.Window;
            this.listViewLoad.CheckBoxes = true;
            this.listViewLoad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewLoad.FullRowSelect = true;
            this.listViewLoad.Location = new System.Drawing.Point(12, 12);
            this.listViewLoad.MultiSelect = false;
            this.listViewLoad.Name = "listViewLoad";
            this.listViewLoad.Size = new System.Drawing.Size(398, 332);
            this.listViewLoad.TabIndex = 0;
            this.listViewLoad.UseCompatibleStateImageBehavior = false;
            this.listViewLoad.View = System.Windows.Forms.View.Details;
            this.listViewLoad.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewLoad_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data Source";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Initial Catalog";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Integrated Security";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User ID";
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butCancel.Location = new System.Drawing.Point(12, 354);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(120, 35);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butLoad
            // 
            this.butLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoad.Location = new System.Drawing.Point(293, 354);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(117, 35);
            this.butLoad.TabIndex = 2;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // FLoadConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 401);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.listViewLoad);
            this.Name = "FLoadConfig";
            this.Text = "FLoadConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLoad;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}