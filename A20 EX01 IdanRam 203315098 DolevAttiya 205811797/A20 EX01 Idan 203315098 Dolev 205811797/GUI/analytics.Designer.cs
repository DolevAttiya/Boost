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
            this.panelAnalytics = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.BiggestFansPage = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.BiggestFans();
            this.BestTimesPage = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.BestTimes();
            this.buttonBestTimes = new System.Windows.Forms.Button();
            this.buttonBiggestFans = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.panelAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAnalytics
            // 
            this.labelAnalytics.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelAnalytics.Location = new System.Drawing.Point(0, 0);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelAnalytics.Size = new System.Drawing.Size(230, 39);
            this.labelAnalytics.TabIndex = 0;
            this.labelAnalytics.Text = "ANALYTICS";
            // 
            // panelAnalytics
            // 
            this.panelAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelAnalytics.Controls.Add(this.BiggestFansPage);
            this.panelAnalytics.Controls.Add(this.BestTimesPage);
            this.panelAnalytics.GradientAngle = 90F;
            this.panelAnalytics.GradientColorA = System.Drawing.Color.White;
            this.panelAnalytics.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelAnalytics.Location = new System.Drawing.Point(9, 81);
            this.panelAnalytics.Margin = new System.Windows.Forms.Padding(0);
            this.panelAnalytics.Name = "panelAnalytics";
            this.panelAnalytics.Size = new System.Drawing.Size(1005, 434);
            this.panelAnalytics.TabIndex = 1;
            // 
            // biggestFans
            // 
            this.BiggestFansPage.BackColor = System.Drawing.Color.Transparent;
            this.BiggestFansPage.Location = new System.Drawing.Point(4, 4);
            this.BiggestFansPage.Name = "biggestFans";
            this.BiggestFansPage.Size = new System.Drawing.Size(1000, 430);
            this.BiggestFansPage.TabIndex = 1;
            // 
            // bestTimes
            // 
            this.BestTimesPage.BackColor = System.Drawing.Color.Transparent;
            this.BestTimesPage.Location = new System.Drawing.Point(4, 4);
            this.BestTimesPage.Name = "bestTimes";
            this.BestTimesPage.Size = new System.Drawing.Size(1000, 430);
            this.BestTimesPage.TabIndex = 0;
            // 
            // buttonBestTimes
            // 
            this.buttonBestTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.buttonBestTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBestTimes.FlatAppearance.BorderSize = 0;
            this.buttonBestTimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonBestTimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.buttonBestTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestTimes.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestTimes.ForeColor = System.Drawing.Color.White;
            this.buttonBestTimes.Location = new System.Drawing.Point(9, 49);
            this.buttonBestTimes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBestTimes.Name = "buttonBestTimes";
            this.buttonBestTimes.Size = new System.Drawing.Size(221, 32);
            this.buttonBestTimes.TabIndex = 2;
            this.buttonBestTimes.Text = "Best Times to Post";
            this.buttonBestTimes.UseVisualStyleBackColor = false;
            this.buttonBestTimes.Click += new System.EventHandler(this.ButtonBestTimes_Click);
            // 
            // buttonBiggestFans
            // 
            this.buttonBiggestFans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.buttonBiggestFans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBiggestFans.FlatAppearance.BorderSize = 0;
            this.buttonBiggestFans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonBiggestFans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.buttonBiggestFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiggestFans.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBiggestFans.ForeColor = System.Drawing.Color.White;
            this.buttonBiggestFans.Location = new System.Drawing.Point(230, 49);
            this.buttonBiggestFans.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBiggestFans.Name = "buttonBiggestFans";
            this.buttonBiggestFans.Size = new System.Drawing.Size(221, 32);
            this.buttonBiggestFans.TabIndex = 3;
            this.buttonBiggestFans.Text = "Biggest Fans";
            this.buttonBiggestFans.UseVisualStyleBackColor = false;
            this.buttonBiggestFans.Click += new System.EventHandler(this.ButtonBiggestFans_Click);
            // 
            // labelError
            // 
            this.LabelError.BackColor = System.Drawing.Color.White;
            this.LabelError.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(12, 81);
            this.LabelError.Name = "labelError";
            this.LabelError.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.LabelError.Size = new System.Drawing.Size(1001, 434);
            this.LabelError.TabIndex = 14;
            this.LabelError.Text = "Could not fetch/analyze user data!";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelError.Visible = false;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.buttonBiggestFans);
            this.Controls.Add(this.buttonBestTimes);
            this.Controls.Add(this.panelAnalytics);
            this.Controls.Add(this.labelAnalytics);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelAnalytics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAnalytics;
        private GradientPanel panelAnalytics;
        private System.Windows.Forms.Button buttonBestTimes;
        private System.Windows.Forms.Button buttonBiggestFans;
        public BestTimes BestTimesPage;
        public BiggestFans BiggestFansPage;
        public System.Windows.Forms.Label LabelError;
    }
}
