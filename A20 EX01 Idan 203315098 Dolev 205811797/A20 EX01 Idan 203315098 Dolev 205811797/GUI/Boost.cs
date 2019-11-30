using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost : Form
    {

        //// need to think what to do with it
        public BoostEngine BoostEn { get; set; }

        public Boost()
        {
            BoostEn = new BoostEngine();
            InitializeComponent();
            setup();
            login.m_LoginEvent += FacebookLogin;
        }

        public enum eBoostPages : byte
        {
            Dashboard = 0,
            Analytics,
        }

        private void setup()
        {
            ////Add event handler to dynamically added buttons
            foreach (Button button in navbar.m_NavbarButtons) 
            {
                button.Click += new System.EventHandler(this.NavbarButton_Click);
            }

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = UI_Elements.color_BGColorA;
            navbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); ////1st button represents home page
            welcomeScreen.Visible = false;
            welcomeScreen.BringToFront();
            this.login.checkBoxRememberUser.Checked = BoostEn.m_AppSettings.RememberUser;
            this.login.Visible = true;
            this.login.BringToFront();
        }

        public void NavbarButton_Click(object sender, EventArgs e)
        {
            switchPage((Button)sender);
        }

        private void switchPage(Button i_Button)
        {
            foreach(Button button in navbar.m_NavbarButtons)
            {
                button.Font = UI_Elements.font_NavbarButtonDefault;
            }

            switch(i_Button.Name)
            {
                case "btnDashboard":
                    dashboard.BringToFront();
                    break;
                case "btnAnalytics":
                    analytics.BringToFront();
                    break;
            }

            i_Button.Font = UI_Elements.font_NavbarButtonSelected;
        }

        public void FacebookLogin()
        {
            BoostEn.FacebookLogin(BoostEn.m_AppSettings.LastAccessToken, BoostEn.m_AppSettings.RememberUser);
            bool isTheUserLoggedIn = BoostEn.LoggedInUser != null;
            if(isTheUserLoggedIn)
            {
                string currentUserEmail = BoostEn.LoggedInUser.Email;
                if (currentUserEmail != BoostEn.m_AppSettings.LastLoggedInEmail)
                {
                    BoostEn.m_AppSettings.LastLogin = null;
                    BoostEn.m_AppSettings.FirstLogin = true;
                }
                if (BoostEn.m_AppSettings.IsFirstLogin())
                {
                    welcomeScreen.Visible = true;
                    welcomeScreen.m_Start += new WelcomeScreenEventHandler(welcomeScreenStart);
                }
                BoostEn.m_AppSettings.LastLoggedInEmail = currentUserEmail;
                BoostEn.m_AppSettings.FirstLogin = false;
                BoostEn.m_AppSettings.LastAccessToken = BoostEn.LoginResult.AccessToken;
                BoostEn.m_AppSettings.LastLogin = DateTime.Now;
                BoostEn.m_AppSettings.RememberUser = this.login.checkBoxRememberUser.Checked;
                FetchUserData();
                BoostEn.FriendCountSetup();
                chartSetup();
            }
            else
            {
                this.login.labelLoading.Visible = true;
                FetchUserData();
            }
        }

        public void FetchUserData()
        {
            const string k_Quotes = "\"";
            string name = BoostEn.LoggedInUser.Name;
            Post lastStatus, topPost;

            navbar.btnUsername.Text = name;
            navbar.navbarProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureSmallURL);
            navbar.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            dashboard.labelName.Text = name;
            dashboard.pictureBoxBioProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            dashboard.labelBio1.Text = $@"Location: {BoostEn.LoggedInUser.Location.Name}";
            dashboard.labelBio2.Text = $@"Friends using Boost: {BoostEn.LoggedInUser.Friends.Count}";
            dashboard.labelBio3.Text = $@"Verified?: {(BoostEn.LoggedInUser.Verfied == true ? "Yes" : "No")}";

            lastStatus = BoostEn.GetLastStatus();

            dashboard.labelRecentStatusUpdateContent.Text = $@"{k_Quotes}{lastStatus.Message}{k_Quotes}";
            dashboard.labelRecentStatusUpdateDateTime.Text = $@"- {lastStatus.CreatedTime.ToString()}";

            try
            {
                topPost = BoostEn.GetTopPost();
                dashboard.labelTopPostLikes.Text += topPost.LikedBy.Count;
                dashboard.labelTopPostComments.Text += topPost.Comments.Count;
                if (string.IsNullOrEmpty(topPost.Message))
                {
                    dashboard.labelTopPostCaptionTitle.Visible = false;
                    dashboard.labelTopPostCaptionContent.Visible = false;
                }
                else
                {
                    dashboard.labelTopPostCaptionContent.Text = $@"{k_Quotes}{topPost.Message}{k_Quotes}";
                }

                dashboard.labelTopPostCaptionDateTime.Text = $@"- {topPost.CreatedTime.ToString()}";
                dashboard.pictureBoxTopPost.LoadAsync(topPost.PictureURL);
            }
            catch(NullReferenceException e)
            {

            }

           dashboard.DashboardUpdate();
            ////analytics.bestTimes.PopulateBestTimes(BoostEn.LoggedInUser.Posts); Not Really needed anymore
            analytics.bestTimes.DrawBestTimesGrid(
                ((TimeAnalysis)BoostEn.TimeAnalysis).GetAnalysisByTimeStrict(BoostEn.LoggedInUser));
        }
                BoostEn.TimeAnalysis.GetAnalysisByTimeStrict(BoostEn.LoggedInUser, eTimerSelector.Month) as
                    TimeAnalysis); ////TODO For grid need to make a new method withoutCalculate
        }

        private void TimerWelcomeScreen_Tick(object sender, EventArgs e)
        {
            int currentY = this.welcomeScreen.Location.Y;
            if (currentY >= 1300)
            {
                timerWelcomeScreen.Stop();
                this.welcomeScreen.Visible = false;
            }
            else
            {
                currentY += 30;
                this.welcomeScreen.Location = new System.Drawing.Point(this.welcomeScreen.Location.X, currentY);
            }
        }

        private void welcomeScreenStart()
        {
            timerWelcomeScreen.Interval = 1;
            timerWelcomeScreen.Start();
        }

        private void Boost_FormClosing(object sender, FormClosingEventArgs e)
        {
            BoostEn.m_AppSettings.SaveAppSettingsToFile();
        }

        private void chartSetup()
        {
            foreach(DateAndValue friendCounter in BoostEn.m_AppSettings.FriendCounter)
            {
                this.dashboard.chartFriends.Series[0].Points.AddXY(friendCounter.Date.Date.ToString("d/M/yy"), friendCounter.Value);
            }
            //this.dashboard.chartFriends.ChartAreas[0].AxisY.Minimum = (this.dashboard.chartFriends.Series[0].Points[0].YValues[0]) - 200 > 0 ? (this.dashboard.chartFriends.Series[0].Points[0].YValues[0]) - 200 : 0;
            //this.dashboard.chartFriends.ChartAreas[0].AxisY.Maximum = (this.dashboard.chartFriends.Series[0].Points[(this.dashboard.chartFriends.Series[0].Points.Count) - 1].YValues[0]) + 200;
            this.dashboard.chartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;
            this.dashboard.chartFriends.AlignDataPointsByAxisLabel(); 
        }
    }
}