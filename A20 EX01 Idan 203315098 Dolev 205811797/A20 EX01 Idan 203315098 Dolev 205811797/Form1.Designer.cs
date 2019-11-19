using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bioPanel = new System.Windows.Forms.Panel();
            this.engagementPanel = new System.Windows.Forms.Panel();
            this.topLikesPanel = new System.Windows.Forms.Panel();
            this.bestTimesPanel = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_navbar;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(56, 20);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(75, 32);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(56, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 3);
            this.panel1.TabIndex = 1;
            // 
            // bioPanel
            // 
            this.bioPanel.BackColor = System.Drawing.Color.White;
            this.bioPanel.Location = new System.Drawing.Point(56, 89);
            this.bioPanel.Name = "bioPanel";
            this.bioPanel.Size = new System.Drawing.Size(250, 504);
            this.bioPanel.TabIndex = 2;
            // 
            // engagementPanel
            // 
            this.engagementPanel.BackColor = System.Drawing.Color.White;
            this.engagementPanel.Location = new System.Drawing.Point(329, 89);
            this.engagementPanel.Name = "engagementPanel";
            this.engagementPanel.Size = new System.Drawing.Size(748, 231);
            this.engagementPanel.TabIndex = 3;
            // 
            // topLikesPanel
            // 
            this.topLikesPanel.BackColor = System.Drawing.Color.White;
            this.topLikesPanel.Location = new System.Drawing.Point(329, 338);
            this.topLikesPanel.Name = "topLikesPanel";
            this.topLikesPanel.Size = new System.Drawing.Size(363, 255);
            this.topLikesPanel.TabIndex = 4;
            // 
            // bestTimesPanel
            // 
            this.bestTimesPanel.BackColor = System.Drawing.Color.White;
            this.bestTimesPanel.Location = new System.Drawing.Point(714, 338);
            this.bestTimesPanel.Name = "bestTimesPanel";
            this.bestTimesPanel.Size = new System.Drawing.Size(363, 255);
            this.bestTimesPanel.TabIndex = 5;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Transparent;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Font = new System.Drawing.Font("Pier Sans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.footer.Location = new System.Drawing.Point(0, 598);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1135, 40);
            this.footer.TabIndex = 6;
            this.footer.Text = "ALL RIGHTS RESERVED TO BOOST FOR FACEBOOK © 2019";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.bestTimesPanel);
            this.Controls.Add(this.topLikesPanel);
            this.Controls.Add(this.engagementPanel);
            this.Controls.Add(this.bioPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Form1";
            this.Text = "Boost for Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private PictureBox logoPictureBox;
        private Panel panel1;
        private Panel bioPanel;
        private Panel engagementPanel;
        private Panel topLikesPanel;
        private Panel bestTimesPanel;
        private Label footer;
    }
}

