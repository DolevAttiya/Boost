using System.Drawing;
using A20_EX02_Idan_203315098_Dolev_205811797.View.UI_Controls;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
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
            System.Windows.Forms.Label defaultAnalysisDataBasisLabel;
            System.Windows.Forms.Label defaultAnalysisTimeFrameLabel;
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.panelAnalytics = new A20_EX02_Idan_203315098_Dolev_205811797.View.UI_Controls.StylizedPanel();
            this.BiggestFansPage = new A20_EX02_Idan_203315098_Dolev_205811797.View.BiggestFansView();
            this.BestTimesPage = new A20_EX02_Idan_203315098_Dolev_205811797.View.BestTimesView();
            this.buttonBestTimes = new System.Windows.Forms.Button();
            this.buttonBiggestFans = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.DataBasisComboBox = new System.Windows.Forms.ComboBox();
            this.TimeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.buttonReanalyze = new System.Windows.Forms.Button();
            this.buttonSaveToDefaults = new System.Windows.Forms.Button();
            defaultAnalysisDataBasisLabel = new System.Windows.Forms.Label();
            defaultAnalysisTimeFrameLabel = new System.Windows.Forms.Label();
            this.panelAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultAnalysisDataBasisLabel
            // 
            defaultAnalysisDataBasisLabel.AutoSize = true;
            defaultAnalysisDataBasisLabel.BackColor = System.Drawing.Color.Transparent;
            defaultAnalysisDataBasisLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalysisDataBasisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            defaultAnalysisDataBasisLabel.Location = new System.Drawing.Point(804, 12);
            defaultAnalysisDataBasisLabel.Name = "defaultAnalysisDataBasisLabel";
            defaultAnalysisDataBasisLabel.Size = new System.Drawing.Size(80, 16);
            defaultAnalysisDataBasisLabel.TabIndex = 17;
            defaultAnalysisDataBasisLabel.Text = "Data Basis:";
            // 
            // defaultAnalysisTimeFrameLabel
            // 
            defaultAnalysisTimeFrameLabel.AutoSize = true;
            defaultAnalysisTimeFrameLabel.BackColor = System.Drawing.Color.Transparent;
            defaultAnalysisTimeFrameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalysisTimeFrameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            defaultAnalysisTimeFrameLabel.Location = new System.Drawing.Point(573, 12);
            defaultAnalysisTimeFrameLabel.Name = "defaultAnalysisTimeFrameLabel";
            defaultAnalysisTimeFrameLabel.Size = new System.Drawing.Size(86, 16);
            defaultAnalysisTimeFrameLabel.TabIndex = 15;
            defaultAnalysisTimeFrameLabel.Text = "Time Frame:";
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
            // LabelError
            // 
            this.LabelError.BackColor = System.Drawing.Color.White;
            this.LabelError.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(12, 81);
            this.LabelError.Name = "LabelError";
            this.LabelError.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.LabelError.Size = new System.Drawing.Size(1001, 434);
            this.LabelError.TabIndex = 14;
            this.LabelError.Text = "Could not fetch/analyze user data!";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelError.Visible = false;
            // 
            // DataBasisComboBox
            // 
            this.DataBasisComboBox.DisplayMember = "DefaultAnalysisDataBasis";
            this.DataBasisComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataBasisComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.DataBasisComboBox.FormattingEnabled = true;
            this.DataBasisComboBox.Location = new System.Drawing.Point(890, 10);
            this.DataBasisComboBox.Name = "DataBasisComboBox";
            this.DataBasisComboBox.Size = new System.Drawing.Size(121, 21);
            this.DataBasisComboBox.TabIndex = 18;
            // 
            // TimeFrameComboBox
            // 
            this.TimeFrameComboBox.DisplayMember = "DefaultAnalysisTimeFrame";
            this.TimeFrameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeFrameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.TimeFrameComboBox.FormattingEnabled = true;
            this.TimeFrameComboBox.Location = new System.Drawing.Point(664, 10);
            this.TimeFrameComboBox.Name = "TimeFrameComboBox";
            this.TimeFrameComboBox.Size = new System.Drawing.Size(121, 21);
            this.TimeFrameComboBox.TabIndex = 16;
            // 
            // buttonReanalyze
            // 
            this.buttonReanalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(168)))));
            this.buttonReanalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReanalyze.FlatAppearance.BorderSize = 0;
            this.buttonReanalyze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonReanalyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.buttonReanalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReanalyze.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReanalyze.ForeColor = System.Drawing.Color.White;
            this.buttonReanalyze.Location = new System.Drawing.Point(576, 40);
            this.buttonReanalyze.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReanalyze.Name = "buttonReanalyze";
            this.buttonReanalyze.Size = new System.Drawing.Size(204, 25);
            this.buttonReanalyze.TabIndex = 19;
            this.buttonReanalyze.Text = "Reanalyze";
            this.buttonReanalyze.UseVisualStyleBackColor = false;
            // 
            // buttonSaveToDefaults
            // 
            this.buttonSaveToDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(168)))));
            this.buttonSaveToDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveToDefaults.FlatAppearance.BorderSize = 0;
            this.buttonSaveToDefaults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonSaveToDefaults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.buttonSaveToDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveToDefaults.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToDefaults.ForeColor = System.Drawing.Color.White;
            this.buttonSaveToDefaults.Location = new System.Drawing.Point(807, 40);
            this.buttonSaveToDefaults.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveToDefaults.Name = "buttonSaveToDefaults";
            this.buttonSaveToDefaults.Size = new System.Drawing.Size(204, 25);
            this.buttonSaveToDefaults.TabIndex = 20;
            this.buttonSaveToDefaults.Text = "Save To Defaults";
            this.buttonSaveToDefaults.UseVisualStyleBackColor = false;
            // 
            // AnalyticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonSaveToDefaults);
            this.Controls.Add(this.buttonReanalyze);
            this.Controls.Add(defaultAnalysisDataBasisLabel);
            this.Controls.Add(this.DataBasisComboBox);
            this.Controls.Add(defaultAnalysisTimeFrameLabel);
            this.Controls.Add(this.TimeFrameComboBox);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.buttonBiggestFans);
            this.Controls.Add(this.buttonBestTimes);
            this.Controls.Add(this.panelAnalytics);
            this.Controls.Add(this.labelAnalytics);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.Name = "AnalyticsView";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelAnalytics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnalytics;
        private StylizedPanel panelAnalytics;
        private System.Windows.Forms.Button buttonBestTimes;
        private System.Windows.Forms.Button buttonBiggestFans;
        public BestTimesView BestTimesPage;
        public BiggestFansView BiggestFansPage;
        public System.Windows.Forms.Label LabelError;
        public System.Windows.Forms.ComboBox DataBasisComboBox;
        public System.Windows.Forms.ComboBox TimeFrameComboBox;
        private System.Windows.Forms.Button buttonReanalyze;
        private System.Windows.Forms.Button buttonSaveToDefaults;
    }
}
