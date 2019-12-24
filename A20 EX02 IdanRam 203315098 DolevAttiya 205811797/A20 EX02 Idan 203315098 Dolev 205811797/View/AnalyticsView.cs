﻿using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class AnalyticsView : UserControl
    {
        #region Ctor
        public AnalyticsView()
        {
            InitializeComponent();
            analyticsInitialSetup();
        }
        #endregion

        #region Methods

        public void DisplayAnalyticsErrorMessage()
        {
            this.panelAnalytics.Visible = false;
            this.LabelError.Visible = true;
        }

        private void analyticsInitialSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.panelAnalytics.GradientColorA = Stylesheet.Color_PanelColorA;
            this.panelAnalytics.GradientColorB = Stylesheet.Color_PanelColorB;
            this.panelAnalytics.GradientAngle = 90F;
            this.BestTimesPage.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Main;
            this.buttonBestTimes.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            this.buttonBiggestFans.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            this.labelAnalytics.Font = Stylesheet.Font_Header1;
            populateComboBoxes();
        }


        private void populateComboBoxes()
        {
            List<eTimeSelector> analysisTimeFrames = Analysis.GetAnalysisTimeFrames();
            List<Analysis.eAnalysisDataBasis> analysisDataBases = Analysis.GetAnalysisDataBases();

            foreach(eTimeSelector timeFrame in analysisTimeFrames)
            {
                TimeFrameComboBox.Items.Add(timeFrame.ToString());
            }

            foreach (Analysis.eAnalysisDataBasis dataBasis in analysisDataBases)
            {
                DataBasisComboBox.Items.Add(dataBasis.ToString());
            }
        }

        private void ButtonBestTimes_Click(object sender, EventArgs e)
        {
            this.BestTimesPage.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Main;
        }

        private void ButtonBiggestFans_Click(object sender, EventArgs e)
        {
            this.BiggestFansPage.BringToFront();
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Secondary;
            this.buttonBestTimes.BackColor = Stylesheet.Color_Main;
        }
        #endregion
    }
}
