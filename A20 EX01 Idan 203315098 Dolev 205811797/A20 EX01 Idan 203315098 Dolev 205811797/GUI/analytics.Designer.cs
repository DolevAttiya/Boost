using System.Drawing;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Analytics
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
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.panel1 = new GradientPanel();
            this.biggestFans = new BiggestFans();
            this.bestTimes = new BestTimes();
            this.buttonBestTimes = new System.Windows.Forms.Button();
            this.buttonBiggestFans = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAnalytics
            // 
            this.labelAnalytics.Font = UI_Elements.font_Header1;
            this.labelAnalytics.ForeColor = UI_Elements.color_Main;
            this.labelAnalytics.Location = new  Point(0, 0);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelAnalytics.Size = new  Size(230, 39);
            this.labelAnalytics.TabIndex = 0;
            this.labelAnalytics.Text = "ANALYTICS";
            // 
            // panel1
            // 
            this.panel1.BackColor =  Color.FromArgb(255,255,255);
            this.panel1.Controls.Add(this.biggestFans);
            this.panel1.Controls.Add(this.bestTimes);
            this.panel1.Location = new  Point(9, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new  Size(1005, 434);
            this.panel1.TabIndex = 1;
            this.panel1.GradientAngle = 90F;
            this.panel1.GradientColorA = UI_Elements.color_PanelColorA;
            this.panel1.GradientColorB = UI_Elements.color_PanelColorB;

            // 
            // biggestFans
            // 
            this.biggestFans.BackColor =  Color.Transparent;
            this.biggestFans.Location = new  Point(4, 4);
            this.biggestFans.Name = "biggestFans";
            this.biggestFans.Size = new  Size(1000, 430);
            this.biggestFans.TabIndex = 1;
            // 
            // bestTimes
            // 
            this.bestTimes.BackColor =  Color.Transparent;
            this.bestTimes.Location = new  Point(4, 4);
            this.bestTimes.Name = "bestTimes";
            this.bestTimes.Size = new  Size(1000, 430);
            this.bestTimes.TabIndex = 0;
            // 
            // buttonBestTimes
            // 
            this.buttonBestTimes.BackColor = UI_Elements.color_Main;
            this.buttonBestTimes.FlatAppearance.MouseDownBackColor = UI_Elements.color_Secondary;
            this.buttonBestTimes.FlatAppearance.MouseOverBackColor = UI_Elements.color_NavbarRollover;
            this.buttonBestTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBestTimes.FlatAppearance.BorderSize = 0;
            this.buttonBestTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestTimes.Font = UI_Elements.font_Header2;
            this.buttonBestTimes.ForeColor =  Color.White;
            this.buttonBestTimes.Location = new  Point(9, 49);
            this.buttonBestTimes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBestTimes.Name = "buttonBestTimes";
            this.buttonBestTimes.Size = new  Size(221, 32);
            this.buttonBestTimes.TabIndex = 2;
            this.buttonBestTimes.Text = "Best Times to Post";
            this.buttonBestTimes.UseVisualStyleBackColor = false;
            this.buttonBestTimes.Click += new System.EventHandler(this.ButtonBestTimes_Click);
            // 
            // buttonBiggestFans
            // 
            this.buttonBiggestFans.BackColor = UI_Elements.color_Main;
            this.buttonBiggestFans.FlatAppearance.MouseDownBackColor = UI_Elements.color_Secondary;
            this.buttonBiggestFans.FlatAppearance.MouseOverBackColor = UI_Elements.color_NavbarRollover;
            this.buttonBiggestFans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBiggestFans.FlatAppearance.BorderSize = 0;
            this.buttonBiggestFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiggestFans.Font = UI_Elements.font_Header2;
            this.buttonBiggestFans.ForeColor =  Color.White;
            this.buttonBiggestFans.Location = new  Point(230, 49);
            this.buttonBiggestFans.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBiggestFans.Name = "buttonBiggestFans";
            this.buttonBiggestFans.Size = new  Size(221, 32);
            this.buttonBiggestFans.TabIndex = 3;
            this.buttonBiggestFans.Text = "Biggest Fans";
            this.buttonBiggestFans.UseVisualStyleBackColor = false;
            this.buttonBiggestFans.Click += new System.EventHandler(this.ButtonBiggestFans_Click);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new  SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =  SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonBiggestFans);
            this.Controls.Add(this.buttonBestTimes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAnalytics);
            this.Name = "Analytics";
            this.Size = new  Size(1021, 523);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAnalytics;
        private GradientPanel panel1;
        private System.Windows.Forms.Button buttonBestTimes;
        private System.Windows.Forms.Button buttonBiggestFans;
        public BestTimes bestTimes;
        public BiggestFans biggestFans;
    }
}
