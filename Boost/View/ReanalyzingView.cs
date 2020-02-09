using System;
using System.Drawing;
using System.Windows.Forms;
using Boost.Model;

namespace Boost.View
{
    public partial class ReanalyzingView : UserControl
    {
        private readonly int r_PixelsPerMs = 100;
        private readonly int r_TimerInterval = 5;
        private readonly int r_AnimationEasingFactor = 3;
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

            this.panelReanalyzing.Size = new Size(0, 434);  // Set initial width to 0 before animation starts 
            this.panelReanalyzing.Location = new Point(0, 0);   // Set initial position to off-screen left
            m_AnalysisFinished = false;
        }

        public void AnimatePanel()
        {
            this.Visible = true;
            this.BringToFront();
            this.panelReanalyzing.BringToFront();
            this.panelReanalyzing.Visible = true;
            timerReanalyzing.Interval = r_TimerInterval;
            m_AnimationPhaseOne = true;
            timerReanalyzing.Start();
        }
        
        public void AnalysisFinishedNotification()
        {
            m_AnalysisFinished = true;
        }
        
        private void timerReanalyzing_Tick(object sender, EventArgs e)
        {
            //// Animate panel in
            if(m_AnimationPhaseOne)
            {
                //// animate in while panel hasn't reached user control width
                if (this.panelReanalyzing.Width < this.Width)
                {
                    this.panelReanalyzing.BringToFront();
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width + r_PixelsPerMs,
                        this.panelReanalyzing.Height);
                }
                else
                {
                    //// TODO lock?
                    while (!m_AnalysisFinished)
                    {
                      // Confirm analysis finished (Observer Pattern) and hold for the second phase of the animation
                    }

                    m_AnimationPhaseOne = false;
                }
            }
            else
            {
                //// Animate out
                if (this.panelReanalyzing.Width <= 0)
                {
                    // Panel completely shrunk back down - stop animation
                    timerReanalyzing.Stop();
                    setupReanalyzingPanel();
                }
                else if (this.panelReanalyzing.Width <= this.Width / r_AnimationEasingFactor)
                { 
                    // Out animation in its last 3rd - animate faster
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width - r_PixelsPerMs,
                        this.panelReanalyzing.Height);
                }
                else
                {
                    // Out animation in 1st 2/3 - animate slower
                    this.panelReanalyzing.Size = new Size(
                        this.panelReanalyzing.Width - (r_PixelsPerMs / r_AnimationEasingFactor),
                        this.panelReanalyzing.Height);
                }
            }
        }
    }
}