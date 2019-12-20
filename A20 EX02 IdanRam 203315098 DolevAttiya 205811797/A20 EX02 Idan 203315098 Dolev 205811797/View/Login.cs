using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void LoginEventHandler();

    public partial class Login : UserControl
    {
        #region Data Members
        public const string k_LoginFailedMessage = "LOGIN FAILED! PLEASE TRY AGAIN!";
        public LoginEventHandler m_LoginEvent; 
        #endregion
        
        #region Ctor
        public Login()
        {
            InitializeComponent();
            loginPageSetup();
            PictureBoxFBLogin.MouseEnter += new EventHandler(PictureBoxFBLogin_MouseEnter);
            PictureBoxFBLogin.MouseLeave += new EventHandler(PictureBoxFBLogin_MouseLeave);
        }
        #endregion

        #region Methods
        private void loginPageSetup()
        {
            this.LabelLoading.Location = new Point(this.LabelLoading.Location.X, this.CheckBoxRememberUser.Bottom + 10);
            this.LabelLoginError.Location = new Point(this.LabelLoginError.Location.X, this.LabelLoading.Location.Y);
            this.LabelLoginError.Text = k_LoginFailedMessage;
        }

        private void PictureBoxFBLogin_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin;
        }

        private void PictureBoxFBLogin_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBoxFBLogin.BackgroundImage = (Image)Properties.Resources.fbLogin_rollover;
        }

        private void PictureBoxFBLogin_Click(object sender, EventArgs e)//TODO SINGELTON ?
        {
            this.LabelLoading.Visible = true;
            m_LoginEvent.Invoke();
            this.Visible = false;
        }
        #endregion
    }
}
