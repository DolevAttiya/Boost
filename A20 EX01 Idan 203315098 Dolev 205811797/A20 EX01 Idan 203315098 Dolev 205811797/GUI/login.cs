using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{

    public delegate void LoginEventHandler(); //?

    public partial class Login : UserControl
    {

        private LoginEventHandler m_LoginEvent; //? 

        public Login()
        {
            InitializeComponent();
            pictureBoxFBLogin.MouseEnter += new EventHandler(PictureBoxFBLogin_MouseEnter);
            pictureBoxFBLogin.MouseLeave += new EventHandler(PictureBoxFBLogin_MouseLeave);
        }

        void PictureBoxFBLogin_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxFBLogin.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.fbLogin));
        }


        void PictureBoxFBLogin_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxFBLogin.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.fbLogin_rollover));
        }

        private void PictureBoxFBLogin_Click(object sender, EventArgs e)
        {
            m_LoginEvent.Invoke();// ? invoke login method from engine?
            this.Visible = false;

        }

        public void RegisterLoginMethod(BoostEngine i_BoostForm) //TODO invoke login method from engine
        {
            m_LoginEvent += new LoginEventHandler(i_BoostForm.FacebookLogin);
        }

    }
}
