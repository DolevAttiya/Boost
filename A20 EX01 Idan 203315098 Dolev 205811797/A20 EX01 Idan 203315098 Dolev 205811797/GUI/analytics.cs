using System;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Analytics : UserControl
    {
        #region Ctor
        public Analytics()
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
            this.labelAnalytics.Font = Stylesheet.Font_Header1;
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
