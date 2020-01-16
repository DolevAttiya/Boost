using System;
using System.Drawing;
using System.Windows.Forms;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class ReanalyzingView : UserControl
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        private readonly int r_PixelsPerMs = 100;
        private bool m_AnimationPhaseOne = false;
        private bool m_AnalysisFinished = false;

        public ReanalyzingView()
        {
            InitializeComponent();
            setupReanalyzingPanel();
        }

        private void setupReanalyzingPanel()
        {
            this.Visible = false;
            this.panelReanalyzing.SendToBack();
            this.labelReanalyzing.Font = Stylesheet.Font_Header1;
            this.panelReanalyzing.BackColor = Stylesheet.Color_Main;

            // Set initial position to off-screen left
            this.panelReanalyzing.Size = new Size(0, 434);
            this.panelReanalyzing.Location = new Point(0, 0);
            m_AnalysisFinished = false;
        }

        public void AnimatePanel()
        {
            this.Visible = true;
            this.BringToFront();
            this.panelReanalyzing.BringToFront();
            //// 1. Animate panel in
            this.panelReanalyzing.Visible = true;
            timerReanalyzing.Interval = 5;
            m_AnimationPhaseOne = true;
            //// TODO - fix transparency issue
            timerReanalyzing.Start();
        }
        
        public void AnalysisFinishedNotification()
        {
            m_AnalysisFinished = true;
        }
        
        private void timerReanalyzing_Tick(object sender, EventArgs e)
        {
            if(m_AnimationPhaseOne)
            {
                if(this.panelReanalyzing.Width >= this.Width)
                {
                    while (!m_AnalysisFinished)
                    {
                        // Wait for notification from prioritized analysis thread
                    }

                    m_AnimationPhaseOne = false;
                }
                else
                {
                    this.panelReanalyzing.BringToFront();
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width + r_PixelsPerMs,
                        this.panelReanalyzing.Height);
                }
            }
            else
            {
                if (this.panelReanalyzing.Width <= 0)
                {
                    timerReanalyzing.Stop();
                    setupReanalyzingPanel();
                }
                else if (this.panelReanalyzing.Width <= (this.Width ) / 3)
                { 
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width - r_PixelsPerMs,
                        this.panelReanalyzing.Height);
                }
                else
                {
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width - (r_PixelsPerMs / 3),
                        this.panelReanalyzing.Height);
                }
            }
        }
    }
}