using System;
using System.Drawing;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void LoginEventHandler();

    public delegate void ContinueAsEventHandler();

    public delegate void SwitchUserEventHandler();

    public partial class Login : UserControl
    {
        #region Data Members
        public const string k_LoginFailedMessage = "LOGIN FAILED! PLEASE TRY AGAIN!";
        public LoginEventHandler m_LoginEvent;
        public ContinueAsEventHandler m_ContinueAsEvent;
        public SwitchUserEventHandler m_SwitchUserEvent;
        #endregion
        
        #region Ctor
        public Login()
        {
            InitializeComponent();
            LoginPageSetup();
            PictureBoxFBLogin.MouseEnter += new EventHandler(PictureBoxFBLogin_MouseEnter);
            PictureBoxFBLogin.MouseLeave += new EventHandler(PictureBoxFBLogin_MouseLeave);
        }
        #endregion

        #region Methods
        public void LoginPageSetup()
        {
            this.LabelLoading.Location = new Point(this.LabelLoading.Location.X, this.CheckBoxRememberUser.Bottom + 10);
            this.LabelLoginError.Location = new Point(this.LabelLoginError.Location.X, this.LabelLoading.Bottom + 10);
            this.LabelLoginError.Text = k_LoginFailedMessage;
            PictureBoxFBLogin.Visible = true;
            CheckBoxRememberUser.Visible = true;
            ButtonContinueAs.Visible = false;
            ButtonSwitchUser.Visible = false;
        }

        private void PictureBoxFBLogin_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin;
        }

        private void PictureBoxFBLogin_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin_rollover;
        }

        private void PictureBoxFBLogin_Click(object sender, EventArgs e) // TODO SINGELTON ?
        {
            this.LabelLoading.Visible = true;
            if(m_LoginEvent != null)
            {
                m_LoginEvent.Invoke();
            }
        }
        #endregion

        private void ButtonContinueAs_Click(object sender, EventArgs e)
        {
            this.LabelLoading.Visible = true;
            if (m_ContinueAsEvent != null)
            {
                m_ContinueAsEvent.Invoke();
            }
        }

        private void ButtonSwitchUser_Click(object sender, EventArgs e)
        {
            if (m_SwitchUserEvent != null)
            {
                BoostEngine.Instance.FacebookLogin(BoostEngine.Instance.m_BoostSettings.LastAccessToken, BoostEngine.Instance.m_BoostSettings.RememberUser);
                m_SwitchUserEvent.Invoke();
            }
            LoginPageSetup();
        }
    }
}
