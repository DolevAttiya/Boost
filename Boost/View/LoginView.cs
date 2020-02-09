using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Boost.Model;

namespace Boost.View
{
    public delegate void LoginEventHandler();

    public delegate void ContinueAsEventHandler();

    public delegate void SwitchUserEventHandler();

    public partial class LoginView : UserControl
    {
        #region Data Members
        public const string k_LoginFailedMessage = "LOGIN FAILED! PLEASE TRY AGAIN!";
        public LoginEventHandler m_LoginEvent;
        public ContinueAsEventHandler m_ContinueAsEvent;
        public SwitchUserEventHandler m_SwitchUserEvent;
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        #endregion
        
        #region Ctor
        public LoginView()
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
            LabelLoading.Location = new Point(LabelLoading.Location.X, CheckBoxRememberUser.Bottom + 10);
            LabelLoginError.Location = new Point(LabelLoginError.Location.X, LabelLoading.Bottom + 10);
            LabelLoginError.Text = k_LoginFailedMessage;
            PictureBoxFBLogin.Visible = true;
            CheckBoxRememberUser.Visible = true;
            ButtonContinueAs.Visible = false;
            ButtonSwitchUser.Visible = false;
            boostSettingsBindingSource.DataSource = r_BoostEn.m_BoostSettings;
        }

        public void UpdateLoginPage()
        {
            CheckBoxRememberUser.Checked = r_BoostEn.m_BoostSettings.RememberUser;
            if (r_BoostEn.m_BoostSettings.RememberUser == true
                && r_BoostEn.m_BoostSettings.FirstName != null)
            {
                ButtonContinueAs.Visible = true;
                ButtonContinueAs.BringToFront();
                ButtonContinueAs.Text = $@"Continue as {r_BoostEn.m_BoostSettings.FirstName}";
                ButtonSwitchUser.BringToFront();
                ButtonSwitchUser.Visible = true;

                // Extension methods from UITools
                ButtonContinueAs.centerControlHorizontally(this);
                ButtonSwitchUser.centerControlHorizontally(this);
                PictureBoxFBLogin.centerControlHorizontally(this);
                CheckBoxRememberUser.centerControlHorizontally(this);
                LabelLoading.centerControlHorizontally(this);
                PictureBoxLogo.centerControlHorizontally(this);

                PictureBoxFBLogin.Visible = false;
                CheckBoxRememberUser.Visible = false;
            }

            BringToFront();
            LabelLoading.Visible = false;
            this.Visible = true; // true
        }

        private void PictureBoxFBLogin_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin;
        }

        private void PictureBoxFBLogin_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin_rollover;
        }

        private void PictureBoxFBLogin_Click(object sender, EventArgs e)
        {
            LabelLoading.Visible = true;
            if(m_LoginEvent != null)
            {
                m_LoginEvent.Invoke();
            }
        }

        public void DisplayLoginErrorMessage()
        {
            Invoke(new Action(() => LabelLoginError.Visible = true));
        }

        public void HideLoginPage()
        {
            Invoke(new Action(() => Visible = false));
        }

        private void ButtonContinueAs_Click(object sender, EventArgs e)
        {
            LabelLoading.Visible = true;
            if (m_ContinueAsEvent != null)
            {
                new Thread(new ThreadStart(() => m_ContinueAsEvent.Invoke())).Start();
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
        #endregion
    }
}
