using System.Drawing;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
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
            this.labelContent = new System.Windows.Forms.Label();
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
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelContent.Location = new System.Drawing.Point(6, 106);
            this.labelContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContent.MaximumSize = new System.Drawing.Size(1900, 962);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelContent.Size = new System.Drawing.Size(1557, 134);
            this.labelContent.TabIndex = 1;
            this.labelContent.Text = "Version: 0.1.0\r\n\r\nBoost for Facebook is a social media management app developed b" +
    "y Idan Ram and Dolev Attiya.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelAbout);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "About";
            this.Size = new System.Drawing.Size(2042, 1006);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelContent;
    }
}
