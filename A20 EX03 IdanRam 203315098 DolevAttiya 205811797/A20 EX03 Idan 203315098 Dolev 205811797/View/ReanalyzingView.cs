using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class ReanalyzingView : UserControl
    {

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        private readonly int r_PixelsPerMs = 15;

        public ReanalyzingView()
        {
            InitializeComponent();
            setupReanalyzingPanel();
        }

        private void setupReanalyzingPanel()
        {
            this.labelReanalyzing.Font = Stylesheet.Font_Header1;
            this.labelReanalyzing.Visible = false;
            //this.panelReanalyzing.Visible = false;
            this.panelReanalyzing.BackColor = Stylesheet.Color_Main;
            // Set initial position to off-screen left
            this.panelReanalyzing.Size = new Size(0,this.Size.Height);
        }

        public void AnimatePanel()
        {
            this.BringToFront();
            this.panelReanalyzing.BringToFront();
            //// TODO - animation
            // 1. Animate panel in
            this.panelReanalyzing.Visible = true;
            timerReanalyzingIn.Interval = 1;
            timerReanalyzingIn.Start();

            // 2. After X sec display label

            // 3. Get notified reanalysis is complete

            // 4. Animate out
            while (!timerReanalyzingIn.Enabled)
            {
                labelReanalyzing.Visible = true;
            }
            timerReanalyzingOut.Interval = 1;
            timerReanalyzingOut.Start();
            // 5. Reset panel
            setupReanalyzingPanel();
        }

        public void HideReanalyzingPanel()
        {
            Invoke(new Action(() => this.panelReanalyzing.Visible = false));
        }

        private void timerReanalyzingIn_Tick(object sender, EventArgs e)
        {
            
            if (this.panelReanalyzing.Width == this.Width)
            {
                timerReanalyzingIn.Stop();
            }
            else
            {
                this.panelReanalyzing.BringToFront();
                this.panelReanalyzing.Size = new Size(this.panelReanalyzing.Width+r_PixelsPerMs, this.panelReanalyzing.Height);
            }
        }
        private void timerReanalyzingOut_Tick(object sender, EventArgs e)
        {
            
            if (this.panelReanalyzing.Width == 0)
            {
                timerReanalyzingIn.Stop();
            }
            else
            {
                this.panelReanalyzing.BringToFront();
                this.panelReanalyzing.Size = new Size(this.panelReanalyzing.Width-r_PixelsPerMs, this.panelReanalyzing.Height);
            }
        }
    }
}
