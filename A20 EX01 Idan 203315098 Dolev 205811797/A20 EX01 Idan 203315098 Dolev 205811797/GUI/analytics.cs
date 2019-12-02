using System;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Analytics : UserControl
    {
        public Analytics()
        {
            InitializeComponent();
            analyticsInitialSetup();
        }

        public void DisplayAnalyticsErrorMessage()
        {
            this.panel1.Visible = false;
            this.labelError.Visible = true;
        }

        private void analyticsInitialSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.bestTimes.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.color_Main;
            this.labelAnalytics.Font = Stylesheet.font_Header1;
        }

        private void ButtonBestTimes_Click(object sender, EventArgs e)
        {
            this.bestTimes.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.color_Main;
        }

        private void ButtonBiggestFans_Click(object sender, EventArgs e)
        {
            this.biggestFans.BringToFront();
            this.buttonBiggestFans.BackColor = Stylesheet.color_Secondary;
            this.buttonBestTimes.BackColor = Stylesheet.color_Main;
        }
    }
}
