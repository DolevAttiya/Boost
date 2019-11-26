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

namespace A20_EX01_Idan_203315098_Dolev_205811797
{

    delegate void LoginDelegate();

    public partial class Login : UserControl
    {

        private Boost m_BoostForm;
        LoginDelegate m_LoginDelegate;

        public Login()
        {
            InitializeComponent();
            //m_BoostForm = i_BoostForm;
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
            m_LoginDelegate.Invoke();
            this.Visible = false;

        }

        public void AddLoginMethod(Boost i_BoostForm)
        {
            m_LoginDelegate += new LoginDelegate(i_BoostForm.FacebookLogin);
        }




    }
}
