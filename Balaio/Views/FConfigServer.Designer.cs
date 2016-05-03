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
            this.propGridConfig = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propGridConfig
            // 
            this.propGridConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propGridConfig.Location = new System.Drawing.Point(12, 12);
            this.propGridConfig.Name = "propGridConfig";
            this.propGridConfig.Size = new System.Drawing.Size(315, 384);
            this.propGridConfig.TabIndex = 1;
            // 
            // FConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 408);
            this.Controls.Add(this.propGridConfig);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConfigServer";
            this.Text = "Data Base Configuration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propGridConfig;
    }
}