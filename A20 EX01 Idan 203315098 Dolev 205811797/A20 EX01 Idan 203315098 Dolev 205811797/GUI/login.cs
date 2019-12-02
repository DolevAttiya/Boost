using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
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
            pictureBoxFBLogin.MouseEnter += new EventHandler(PictureBoxFBLogin_MouseEnter);
            pictureBoxFBLogin.MouseLeave += new EventHandler(PictureBoxFBLogin_MouseLeave);
        }
        #endregion

        #region Methods
        private void loginPageSetup()
        {
            this.labelLoading.Location = new Point(this.labelLoading.Location.X, this.checkBoxRememberUser.Bottom + 10);
            this.labelLoginError.Location = new Point(this.labelLoginError.Location.X, this.labelLoading.Location.Y);
            this.labelLoginError.Text = k_LoginFailedMessage;
        }

        private void PictureBoxFBLogin_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxFBLogin.BackgroundImage = ((Image)(Properties.Resources.fbLogin));
        }
        private void PictureBoxFBLogin_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxFBLogin.BackgroundImage = ((Image)(Properties.Resources.fbLogin_rollover));
        }

        private void PictureBoxFBLogin_Click(object sender, EventArgs e)
        {
            this.labelLoading.Visible = true;
            m_LoginEvent.Invoke(); // ? invoke login method from engine?
            this.Visible = false;
        }
        #endregion
    }
}
