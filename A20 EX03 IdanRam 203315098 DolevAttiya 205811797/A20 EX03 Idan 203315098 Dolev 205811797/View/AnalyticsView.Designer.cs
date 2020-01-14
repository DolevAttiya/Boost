using System.Drawing;
using A20_EX03_Idan_203315098_Dolev_205811797.View.UI_Controls;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class AnalyticsView
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
            this.ButtonTabBestTimes = new System.Windows.Forms.Button();
            this.ButtonTabBiggestFans = new System.Windows.Forms.Button();
            this.ButtonSaveToDefaults = new System.Windows.Forms.Button();
            this.ButtonBasisCombined = new System.Windows.Forms.Button();
            this.ButtonBasisStatus = new System.Windows.Forms.Button();
            this.ButtonBasisPhotos = new System.Windows.Forms.Button();
            this.ButtonBasisVideos = new System.Windows.Forms.Button();
            this.ButtonTimeFrameYear = new System.Windows.Forms.Button();
            this.ButtonTimeFrameMonth = new System.Windows.Forms.Button();
            this.ButtonTimeFrameWeek = new System.Windows.Forms.Button();
            this.reanalyzingOverlay = new A20_EX03_Idan_203315098_Dolev_205811797.View.ReanalyzingView();
            this.panelAnalytics = new A20_EX03_Idan_203315098_Dolev_205811797.View.UI_Controls.StylizedPanel();
            this.BiggestFansPage = new A20_EX03_Idan_203315098_Dolev_205811797.View.BiggestFansView();
            this.BestTimesPage = new A20_EX03_Idan_203315098_Dolev_205811797.View.BestTimesView();
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
            // ButtonTabBestTimes
            // 
            this.ButtonTabBestTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonTabBestTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTabBestTimes.FlatAppearance.BorderSize = 0;
            this.ButtonTabBestTimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonTabBestTimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonTabBestTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTabBestTimes.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTabBestTimes.ForeColor = System.Drawing.Color.White;
            this.ButtonTabBestTimes.Location = new System.Drawing.Point(9, 43);
            this.ButtonTabBestTimes.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTabBestTimes.Name = "ButtonTabBestTimes";
            this.ButtonTabBestTimes.Size = new System.Drawing.Size(221, 38);
            this.ButtonTabBestTimes.TabIndex = 2;
            this.ButtonTabBestTimes.Text = "Best Times to Post";
            this.ButtonTabBestTimes.UseVisualStyleBackColor = false;
            this.ButtonTabBestTimes.Click += new System.EventHandler(this.analysisTab_Click);
            // 
            // ButtonTabBiggestFans
            // 
            this.ButtonTabBiggestFans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonTabBiggestFans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTabBiggestFans.FlatAppearance.BorderSize = 0;
            this.ButtonTabBiggestFans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonTabBiggestFans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonTabBiggestFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTabBiggestFans.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTabBiggestFans.ForeColor = System.Drawing.Color.White;
            this.ButtonTabBiggestFans.Location = new System.Drawing.Point(230, 43);
            this.ButtonTabBiggestFans.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTabBiggestFans.Name = "ButtonTabBiggestFans";
            this.ButtonTabBiggestFans.Size = new System.Drawing.Size(221, 38);
            this.ButtonTabBiggestFans.TabIndex = 3;
            this.ButtonTabBiggestFans.Text = "Biggest Fans";
            this.ButtonTabBiggestFans.UseVisualStyleBackColor = false;
            this.ButtonTabBiggestFans.Click += new System.EventHandler(this.analysisTab_Click);
            // 
            // ButtonSaveToDefaults
            // 
            this.ButtonSaveToDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.ButtonSaveToDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSaveToDefaults.FlatAppearance.BorderSize = 0;
            this.ButtonSaveToDefaults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonSaveToDefaults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonSaveToDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveToDefaults.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonSaveToDefaults.ForeColor = System.Drawing.Color.Black;
            this.ButtonSaveToDefaults.Location = new System.Drawing.Point(899, 12);
            this.ButtonSaveToDefaults.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSaveToDefaults.Name = "ButtonSaveToDefaults";
            this.ButtonSaveToDefaults.Size = new System.Drawing.Size(115, 24);
            this.ButtonSaveToDefaults.TabIndex = 20;
            this.ButtonSaveToDefaults.Text = "Save To Defaults";
            this.ButtonSaveToDefaults.UseVisualStyleBackColor = false;
            this.ButtonSaveToDefaults.Click += new System.EventHandler(this.buttonSaveToDefaults_Click);
            // 
            // ButtonBasisCombined
            // 
            this.ButtonBasisCombined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(168)))));
            this.ButtonBasisCombined.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBasisCombined.FlatAppearance.BorderSize = 0;
            this.ButtonBasisCombined.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonBasisCombined.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonBasisCombined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBasisCombined.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBasisCombined.ForeColor = System.Drawing.Color.White;
            this.ButtonBasisCombined.Location = new System.Drawing.Point(533, 44);
            this.ButtonBasisCombined.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBasisCombined.Name = "ButtonBasisCombined";
            this.ButtonBasisCombined.Size = new System.Drawing.Size(115, 24);
            this.ButtonBasisCombined.TabIndex = 21;
            this.ButtonBasisCombined.Text = "Combined";
            this.ButtonBasisCombined.UseVisualStyleBackColor = false;
            this.ButtonBasisCombined.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonBasisStatus
            // 
            this.ButtonBasisStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonBasisStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBasisStatus.FlatAppearance.BorderSize = 0;
            this.ButtonBasisStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonBasisStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonBasisStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBasisStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBasisStatus.ForeColor = System.Drawing.Color.White;
            this.ButtonBasisStatus.Location = new System.Drawing.Point(655, 44);
            this.ButtonBasisStatus.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBasisStatus.Name = "ButtonBasisStatus";
            this.ButtonBasisStatus.Size = new System.Drawing.Size(115, 24);
            this.ButtonBasisStatus.TabIndex = 22;
            this.ButtonBasisStatus.Text = "Status";
            this.ButtonBasisStatus.UseVisualStyleBackColor = false;
            this.ButtonBasisStatus.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonBasisPhotos
            // 
            this.ButtonBasisPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonBasisPhotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBasisPhotos.FlatAppearance.BorderSize = 0;
            this.ButtonBasisPhotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonBasisPhotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonBasisPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBasisPhotos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBasisPhotos.ForeColor = System.Drawing.Color.White;
            this.ButtonBasisPhotos.Location = new System.Drawing.Point(777, 44);
            this.ButtonBasisPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBasisPhotos.Name = "ButtonBasisPhotos";
            this.ButtonBasisPhotos.Size = new System.Drawing.Size(115, 24);
            this.ButtonBasisPhotos.TabIndex = 23;
            this.ButtonBasisPhotos.Text = "Photos";
            this.ButtonBasisPhotos.UseVisualStyleBackColor = false;
            this.ButtonBasisPhotos.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonBasisVideos
            // 
            this.ButtonBasisVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonBasisVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBasisVideos.FlatAppearance.BorderSize = 0;
            this.ButtonBasisVideos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonBasisVideos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonBasisVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBasisVideos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBasisVideos.ForeColor = System.Drawing.Color.White;
            this.ButtonBasisVideos.Location = new System.Drawing.Point(899, 44);
            this.ButtonBasisVideos.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBasisVideos.Name = "ButtonBasisVideos";
            this.ButtonBasisVideos.Size = new System.Drawing.Size(115, 24);
            this.ButtonBasisVideos.TabIndex = 24;
            this.ButtonBasisVideos.Text = "Videos";
            this.ButtonBasisVideos.UseVisualStyleBackColor = false;
            this.ButtonBasisVideos.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonTimeFrameYear
            // 
            this.ButtonTimeFrameYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonTimeFrameYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTimeFrameYear.FlatAppearance.BorderSize = 0;
            this.ButtonTimeFrameYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonTimeFrameYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonTimeFrameYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimeFrameYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonTimeFrameYear.ForeColor = System.Drawing.Color.White;
            this.ButtonTimeFrameYear.Location = new System.Drawing.Point(777, 12);
            this.ButtonTimeFrameYear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTimeFrameYear.Name = "ButtonTimeFrameYear";
            this.ButtonTimeFrameYear.Size = new System.Drawing.Size(115, 24);
            this.ButtonTimeFrameYear.TabIndex = 27;
            this.ButtonTimeFrameYear.Text = "Year";
            this.ButtonTimeFrameYear.UseVisualStyleBackColor = false;
            this.ButtonTimeFrameYear.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonTimeFrameMonth
            // 
            this.ButtonTimeFrameMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ButtonTimeFrameMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTimeFrameMonth.FlatAppearance.BorderSize = 0;
            this.ButtonTimeFrameMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonTimeFrameMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonTimeFrameMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimeFrameMonth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonTimeFrameMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonTimeFrameMonth.Location = new System.Drawing.Point(655, 12);
            this.ButtonTimeFrameMonth.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTimeFrameMonth.Name = "ButtonTimeFrameMonth";
            this.ButtonTimeFrameMonth.Size = new System.Drawing.Size(115, 24);
            this.ButtonTimeFrameMonth.TabIndex = 26;
            this.ButtonTimeFrameMonth.Text = "Month";
            this.ButtonTimeFrameMonth.UseVisualStyleBackColor = false;
            this.ButtonTimeFrameMonth.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // ButtonTimeFrameWeek
            // 
            this.ButtonTimeFrameWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(168)))));
            this.ButtonTimeFrameWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTimeFrameWeek.FlatAppearance.BorderSize = 0;
            this.ButtonTimeFrameWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonTimeFrameWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.ButtonTimeFrameWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimeFrameWeek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonTimeFrameWeek.ForeColor = System.Drawing.Color.White;
            this.ButtonTimeFrameWeek.Location = new System.Drawing.Point(533, 12);
            this.ButtonTimeFrameWeek.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTimeFrameWeek.Name = "ButtonTimeFrameWeek";
            this.ButtonTimeFrameWeek.Size = new System.Drawing.Size(115, 24);
            this.ButtonTimeFrameWeek.TabIndex = 25;
            this.ButtonTimeFrameWeek.Text = "Week";
            this.ButtonTimeFrameWeek.UseVisualStyleBackColor = false;
            this.ButtonTimeFrameWeek.Click += new System.EventHandler(this.analysisElementButton_Click);
            // 
            // reanalyzingOverlay
            // 
            this.reanalyzingOverlay.BackColor = System.Drawing.Color.Transparent;
            this.reanalyzingOverlay.Location = new System.Drawing.Point(0, 0);
            this.reanalyzingOverlay.MaximumSize = new System.Drawing.Size(1005, 434);
            this.reanalyzingOverlay.MinimumSize = new System.Drawing.Size(1005, 434);
            this.reanalyzingOverlay.Name = "reanalyzingOverlay";
            this.reanalyzingOverlay.Size = new System.Drawing.Size(1005, 434);
            this.reanalyzingOverlay.TabIndex = 28;
            // 
            // panelAnalytics
            // 
            this.panelAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelAnalytics.Controls.Add(this.reanalyzingOverlay);
            this.panelAnalytics.Controls.Add(this.BiggestFansPage);
            this.panelAnalytics.Controls.Add(this.BestTimesPage);
            this.panelAnalytics.Controls.Add(this.LabelError);
            this.panelAnalytics.GradientAngle = 90F;
            this.panelAnalytics.GradientColorA = System.Drawing.Color.White;
            this.panelAnalytics.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelAnalytics.Location = new System.Drawing.Point(9, 81);
            this.panelAnalytics.Margin = new System.Windows.Forms.Padding(0);
            this.panelAnalytics.Name = "panelAnalytics";
            this.panelAnalytics.Size = new System.Drawing.Size(1005, 434);
            this.panelAnalytics.TabIndex = 1;
            // 
            // BiggestFansPage
            // 
            this.BiggestFansPage.BackColor = System.Drawing.Color.Transparent;
            this.BiggestFansPage.Location = new System.Drawing.Point(4, 4);
            this.BiggestFansPage.Name = "BiggestFansPage";
            this.BiggestFansPage.Size = new System.Drawing.Size(1000, 430);
            this.BiggestFansPage.TabIndex = 1;
            // 
            // BestTimesPage
            // 
            this.BestTimesPage.BackColor = System.Drawing.Color.Transparent;
            this.BestTimesPage.Location = new System.Drawing.Point(4, 4);
            this.BestTimesPage.Name = "BestTimesPage";
            this.BestTimesPage.Size = new System.Drawing.Size(1000, 430);
            this.BestTimesPage.TabIndex = 0;
            // 
            // LabelError
            // 
            this.LabelError.BackColor = System.Drawing.Color.White;
            this.LabelError.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(8, 8);
            this.LabelError.Name = "LabelError";
            this.LabelError.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.LabelError.Size = new System.Drawing.Size(1001, 434);
            this.LabelError.TabIndex = 14;
            this.LabelError.Text = "Could not fetch/analyze user data!";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelError.Visible = false;
            // 
            // AnalyticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ButtonTimeFrameYear);
            this.Controls.Add(this.ButtonTimeFrameMonth);
            this.Controls.Add(this.ButtonTimeFrameWeek);
            this.Controls.Add(this.ButtonBasisVideos);
            this.Controls.Add(this.ButtonBasisPhotos);
            this.Controls.Add(this.ButtonBasisStatus);
            this.Controls.Add(this.ButtonBasisCombined);
            this.Controls.Add(this.ButtonSaveToDefaults);
            this.Controls.Add(this.ButtonTabBiggestFans);
            this.Controls.Add(this.ButtonTabBestTimes);
            this.Controls.Add(this.panelAnalytics);
            this.Controls.Add(this.labelAnalytics);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.Name = "AnalyticsView";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelAnalytics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public BestTimesView BestTimesPage;
        public BiggestFansView BiggestFansPage;
        public System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Label labelAnalytics;
        private StylizedPanel panelAnalytics;
        public System.Windows.Forms.Button ButtonTabBestTimes;
        public System.Windows.Forms.Button ButtonTabBiggestFans;
        public System.Windows.Forms.Button ButtonSaveToDefaults;
        public System.Windows.Forms.Button ButtonBasisCombined;
        public System.Windows.Forms.Button ButtonBasisStatus;
        public System.Windows.Forms.Button ButtonBasisPhotos;
        public System.Windows.Forms.Button ButtonBasisVideos;
        public System.Windows.Forms.Button ButtonTimeFrameYear;
        public System.Windows.Forms.Button ButtonTimeFrameMonth;
        public System.Windows.Forms.Button ButtonTimeFrameWeek;
        private ReanalyzingView reanalyzingOverlay;
    }
}
