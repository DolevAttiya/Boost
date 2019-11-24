namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    partial class Analytics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.biggestFans = new A20_EX01_Idan_203315098_Dolev_205811797.BiggestFans();
            this.bestTimes = new A20_EX01_Idan_203315098_Dolev_205811797.BestTimes();
            this.buttonBestTimes = new System.Windows.Forms.Button();
            this.buttonBiggestFans = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(255,255,255);
            this.panel1.Controls.Add(this.biggestFans);
            this.panel1.Controls.Add(this.bestTimes);
            this.panel1.Location = new System.Drawing.Point(9, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 434);
            this.panel1.TabIndex = 1;
            // 
            // biggestFans
            // 
            this.biggestFans.BackColor = System.Drawing.Color.Transparent;
            this.biggestFans.Location = new System.Drawing.Point(4, 4);
            this.biggestFans.Name = "biggestFans";
            this.biggestFans.Size = new System.Drawing.Size(1000, 430);
            this.biggestFans.TabIndex = 1;
            // 
            // bestTimes
            // 
            this.bestTimes.BackColor = System.Drawing.Color.Transparent;
            this.bestTimes.Location = new System.Drawing.Point(4, 4);
            this.bestTimes.Name = "bestTimes";
            this.bestTimes.Size = new System.Drawing.Size(1000, 430);
            this.bestTimes.TabIndex = 0;
            // 
            // buttonBestTimes
            // 
            this.buttonBestTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.buttonBestTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBestTimes.FlatAppearance.BorderSize = 0;
            this.buttonBestTimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonBestTimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.buttonBestTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestTimes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonBiggestFans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.buttonBiggestFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiggestFans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonBiggestFans);
            this.Controls.Add(this.buttonBestTimes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAnalytics);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBestTimes;
        private System.Windows.Forms.Button buttonBiggestFans;
        public BestTimes bestTimes;
        public BiggestFans biggestFans;
    }
}
