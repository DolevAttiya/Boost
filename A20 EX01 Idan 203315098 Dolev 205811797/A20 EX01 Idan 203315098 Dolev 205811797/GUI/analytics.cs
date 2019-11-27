using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Analytics : UserControl
    {
        public Analytics()
        {
            InitializeComponent();
            analyticsSetup();
        }

        private void analyticsSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.bestTimes.BringToFront();
            this.buttonBestTimes.BackColor = UI_Elements.color_Secondary;
            this.buttonBiggestFans.BackColor = UI_Elements.color_Main;
        }

        private void ButtonBestTimes_Click(object sender, EventArgs e)
        {
            this.bestTimes.BringToFront();
            this.buttonBestTimes.BackColor = UI_Elements.color_Secondary;
            this.buttonBiggestFans.BackColor = UI_Elements.color_Main;
        }

        private void ButtonBiggestFans_Click(object sender, EventArgs e)
        {
            this.biggestFans.BringToFront();
            this.buttonBiggestFans.BackColor = UI_Elements.color_Secondary;
            this.buttonBestTimes.BackColor = UI_Elements.color_Main;
        }
    }
}
