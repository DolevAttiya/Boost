﻿namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    partial class WhatsNew
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
            this.webBrowserWhatNew = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowserWhatNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWhatNew.Location = new System.Drawing.Point(0, 0);
            this.webBrowserWhatNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowserWhatNew.MinimumSize = new System.Drawing.Size(10, 10);
            this.webBrowserWhatNew.Name = "webBrowser1";
            this.webBrowserWhatNew.Size = new System.Drawing.Size(814, 461);
            this.webBrowserWhatNew.TabIndex = 0;
            // 
            // WhatsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.webBrowserWhatNew);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 500);
            this.Name = "WhatsNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s New";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserWhatNew;
    }
}