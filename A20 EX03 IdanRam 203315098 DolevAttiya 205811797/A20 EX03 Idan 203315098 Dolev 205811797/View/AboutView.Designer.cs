using System.Drawing;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class AboutView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelAbout.Location = new System.Drawing.Point(0, 0);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelAbout.Size = new System.Drawing.Size(460, 75);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "ABOUT BOOST";
            // 
            // labelContent
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelVersion.Location = new System.Drawing.Point(6, 106);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(1900, 962);
            this.labelVersion.Name = "labelContent";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(10);
            this.labelVersion.Size = new System.Drawing.Size(240, 58);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version: 0.1.0";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 178);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(2008, 798);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Visible = false;
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAbout);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(2042, 1006);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
