namespace Balaio.Views
{
    partial class FConfigServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConfigServer));
            this.butConfig = new System.Windows.Forms.Button();
            this.propGridConfig = new System.Windows.Forms.PropertyGrid();
            this.butLoadSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butConfig
            // 
            this.butConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butConfig.Location = new System.Drawing.Point(12, 12);
            this.butConfig.Name = "butConfig";
            this.butConfig.Size = new System.Drawing.Size(360, 40);
            this.butConfig.TabIndex = 0;
            this.butConfig.Text = "SQL Server Connection Helper";
            this.butConfig.UseVisualStyleBackColor = true;
            this.butConfig.Click += new System.EventHandler(this.butConfig_Click);
            // 
            // propGridConfig
            // 
            this.propGridConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propGridConfig.Location = new System.Drawing.Point(12, 58);
            this.propGridConfig.Name = "propGridConfig";
            this.propGridConfig.Size = new System.Drawing.Size(455, 330);
            this.propGridConfig.TabIndex = 1;
            // 
            // butLoadSave
            // 
            this.butLoadSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoadSave.Location = new System.Drawing.Point(378, 12);
            this.butLoadSave.Name = "butLoadSave";
            this.butLoadSave.Size = new System.Drawing.Size(89, 40);
            this.butLoadSave.TabIndex = 2;
            this.butLoadSave.Text = "LOAD/SAVE Configuration";
            this.butLoadSave.UseVisualStyleBackColor = true;
            this.butLoadSave.Click += new System.EventHandler(this.butLoadSave_Click);
            // 
            // FConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 400);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.butLoadSave);
            this.Controls.Add(this.propGridConfig);
            this.Controls.Add(this.butConfig);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConfigServer";
            this.Text = "Data Base Configuration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butConfig;
        private System.Windows.Forms.PropertyGrid propGridConfig;
        private System.Windows.Forms.Button butLoadSave;
    }
}