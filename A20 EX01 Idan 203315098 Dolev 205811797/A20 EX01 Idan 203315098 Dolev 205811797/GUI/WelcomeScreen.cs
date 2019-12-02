using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{

    public delegate void WelcomeScreenEventHandler();

    public partial class WelcomeScreen : UserControl
    {

        public WelcomeScreenEventHandler m_Start;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void PictureBoxStart_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            m_Start.Invoke();

        }

        private void PictureBoxStart_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage =
                ((Image)(Properties.Resources.WelcomeScreen_StartDefault));
        }

        private void PictureBoxStart_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage =
                ((Image)(Properties.Resources.WelcomeScreen_StartRollover));
        }

    }
}
