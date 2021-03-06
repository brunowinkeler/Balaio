﻿namespace Balaio.Views
{
    partial class FDataBaseManipulation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDataBaseManipulation));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butAddTable = new System.Windows.Forms.ToolStripButton();
            this.butAddTableTemplate = new System.Windows.Forms.ToolStripButton();
            this.butEditTable = new System.Windows.Forms.ToolStripButton();
            this.butDeleteTable = new System.Windows.Forms.ToolStripButton();
            this.butInsertQuery = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(444, 295);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTable.Size = new System.Drawing.Size(444, 266);
            this.dataGridTable.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butAddTable,
            this.butAddTableTemplate,
            this.butEditTable,
            this.butDeleteTable,
            this.butInsertQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butAddTable
            // 
            this.butAddTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butAddTable.Image = global::Balaio.Properties.Resources.plus_2;
            this.butAddTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butAddTable.Name = "butAddTable";
            this.butAddTable.Size = new System.Drawing.Size(23, 22);
            this.butAddTable.Text = "toolStripButton1";
            this.butAddTable.Click += new System.EventHandler(this.butAddTable_Click);
            // 
            // butAddTableTemplate
            // 
            this.butAddTableTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butAddTableTemplate.Image = global::Balaio.Properties.Resources.plus;
            this.butAddTableTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butAddTableTemplate.Name = "butAddTableTemplate";
            this.butAddTableTemplate.Size = new System.Drawing.Size(23, 22);
            this.butAddTableTemplate.Text = "toolStripButton2";
            // 
            // butEditTable
            // 
            this.butEditTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butEditTable.Image = global::Balaio.Properties.Resources.pencil_edit;
            this.butEditTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butEditTable.Name = "butEditTable";
            this.butEditTable.Size = new System.Drawing.Size(23, 22);
            this.butEditTable.Text = "toolStripButton3";
            // 
            // butDeleteTable
            // 
            this.butDeleteTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butDeleteTable.Image = global::Balaio.Properties.Resources.close_delete_2;
            this.butDeleteTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDeleteTable.Name = "butDeleteTable";
            this.butDeleteTable.Size = new System.Drawing.Size(23, 22);
            this.butDeleteTable.Text = "toolStripButton4";
            this.butDeleteTable.Click += new System.EventHandler(this.butDeleteTable_Click);
            // 
            // butInsertQuery
            // 
            this.butInsertQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butInsertQuery.Image = global::Balaio.Properties.Resources.document_file;
            this.butInsertQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butInsertQuery.Name = "butInsertQuery";
            this.butInsertQuery.Size = new System.Drawing.Size(23, 22);
            this.butInsertQuery.Text = "toolStripButton5";
            // 
            // FDataBaseManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 295);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDataBaseManipulation";
            this.Text = "Data Tables from DB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butAddTable;
        private System.Windows.Forms.ToolStripButton butAddTableTemplate;
        private System.Windows.Forms.ToolStripButton butEditTable;
        private System.Windows.Forms.ToolStripButton butDeleteTable;
        private System.Windows.Forms.ToolStripButton butInsertQuery;
        private System.Windows.Forms.DataGridView dataGridTable;


    }
}