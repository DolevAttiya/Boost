using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost : Form
    {
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
            About
        }

        private void setup()
        {
            //Add event handler to dynamically added buttons
            foreach(Button button in navbar.m_NavbarButtons)
            {
                button.Click += new System.EventHandler(this.NavbarButton_Click);
            }

            //
            //Boost Frame properties
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = UI_Elements.color_BGColorA;
            //
            //Startup operations
            navbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); ////1st button represents home page
            welcomeScreen.Visible = false;
            welcomeScreen.BringToFront();
            this.login.checkBoxRememberUser.Checked = BoostEn.m_BoostSettings.RememberUser;
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
                case "btnAbout":
                    about.BringToFront();
                    break;

            }

            i_Button.Font = UI_Elements.font_NavbarButtonSelected;
        }

        public void FacebookLogin()
        {
            BoostEn.FacebookLogin(BoostEn.m_BoostSettings.LastAccessToken, BoostEn.m_BoostSettings.RememberUser);
            bool isTheUserLoggedIn = BoostEn.LoggedInUser != null;
            if(isTheUserLoggedIn)
            {
                //Identify Login (Email as ID + First login)
                string currentUserEmail = BoostEn.LoggedInUser.Email;
                if(currentUserEmail != BoostEn.m_BoostSettings.LastLoggedInEmail)
                {
                    BoostEn.m_BoostSettings.LastLogin = null;
                    BoostEn.m_BoostSettings.FirstLogin = true;
                }

                if(BoostEn.m_BoostSettings.IsFirstLogin())
                {
                    welcomeScreen.Visible = true;
                    welcomeScreen.m_Start += new WelcomeScreenEventHandler(welcomeScreenStart);
                }

                //
                //Overwrite Boost Settings
                BoostEn.m_BoostSettings.LastLoggedInEmail = currentUserEmail;
                BoostEn.m_BoostSettings.FirstLogin = false;
                BoostEn.m_BoostSettings.LastAccessToken = BoostEn.LoginResult.AccessToken;
                BoostEn.m_BoostSettings.LastLogin = DateTime.Now;
                BoostEn.m_BoostSettings.RememberUser = this.login.checkBoxRememberUser.Checked;
                //Fetch and load data
                FetchUserData();
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
            BoostEn.FriendCountSetup();
            BoostEn.SetupEngagementArrays();
            fetchDashboardData();
            fetchAnalyticsPageData();

        }

        private void fetchAnalyticsPageData()
        {
            try
            {
                ///BestTimes
                analytics.bestTimes.DrawBestTimesGrid(
                    (TimeAnalysis)BoostEn.TimeAnalysis.CreateAnalysisByTimeFrame(BoostEn.LoggedInUser));
                ///BiggestFans

                analytics.biggestFans.DrawBiggestFans(
                    (BiggestFanAnalysis)BoostEn.BiggestFanAnalysis.CreateAnalysisByTimeFrame(
                        BoostEn.LoggedInUser,
                        eTimeSelector.Month));
            }
            catch(NullReferenceException e)
            {
                //Display error message
            }
        }

        private void fetchDashboardData()
        {
            const string k_Quotes = "\"";
            string name = BoostEn.LoggedInUser.Name;
            Post lastStatus, topPost;

            ///Navbar
            navbar.btnUsername.Text = name;
            navbar.navbarProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureSmallURL);
            navbar.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ///Bio Panel
            dashboard.labelName.Text = name;
            dashboard.pictureBoxBioProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            dashboard.labelBio1.Text = $@"Location: {BoostEn.LoggedInUser.Location.Name}";
            dashboard.labelBio2.Text = $@"Friends using Boost: {BoostEn.LoggedInUser.Friends.Count}";
            dashboard.labelBio3.Text = $@"Verified?: {(BoostEn.LoggedInUser.Verfied == true ? "Yes" : "No")}";
            //Recent Status Update
            lastStatus = BoostEn.GetLastStatus();
            dashboard.labelRecentStatusUpdateContent.Text = $@"{k_Quotes}{lastStatus.Message}{k_Quotes}";
            dashboard.labelRecentStatusUpdateDateTime.Text = $@"- {lastStatus.CreatedTime.ToString()}";

            ///Top Post
            try
            {
                topPost = BoostEn.GetTopPost();
                dashboard.labelTopPostLikes.Text += topPost.LikedBy.Count;
                dashboard.labelTopPostComments.Text += topPost.Comments.Count;
                if(string.IsNullOrEmpty(topPost.Message))
                {
                    dashboard.labelTopPostCaptionTitle.Visible = false;
                    dashboard.labelTopPostCaptionContent.Visible = false;
                }
                else
                {
                    dashboard.labelTopPostCaptionContent.Text = $@"{k_Quotes}{topPost.Message}{k_Quotes}";
                }

                dashboard.labelTopPostCaptionDateTime.Text = $@"- {topPost.CreatedTime.ToString()}";
                if(!string.IsNullOrWhiteSpace(topPost.PictureURL))
                {
                    dashboard.pictureBoxTopPost.LoadAsync(topPost.PictureURL);
                }
            }
            catch(NullReferenceException e)
            {
                dashboard.labelTopPostError.Text = BoostEngine.k_TopPostErrorMessage;
                dashboard.labelTopPostError.Visible = true;
                dashboard.labelTopPostLikes.Visible = false;
                dashboard.labelTopPostComments.Visible = false;
                dashboard.labelTopPostCaptionDateTime.Visible = false;
                dashboard.pictureBoxTopPost.Visible = false;
            }


            ///Friends Panel
            if(BoostEn.m_FriendChange != 0)
            {
                dashboard.labelFriendsChange.Visible = true;
                if(BoostEn.m_FriendChange > 0)
                {
                    dashboard.labelFriendsChange.Text = "+" + BoostEn.m_FriendChange.ToString();
                    dashboard.labelFriendsChange.ForeColor = System.Drawing.Color.ForestGreen;
                }
                else
                {
                    dashboard.labelFriendsChange.Text = BoostEn.m_FriendChange.ToString();
                    dashboard.labelFriendsChange.ForeColor = System.Drawing.Color.DarkRed;
                }
            }

            ///Engagement Panel
            dashboard.labelEngagement.Text += $@" (Last {BoostEngine.k_NumOfPostsForEngagement} posts)";
            dashboard.DashboardUpdate();

            ///Biggest Fan Panel

        }

        private void TimerWelcomeScreen_Tick(object sender, EventArgs e)
        {
            int currentY = this.welcomeScreen.Location.Y;
            if(currentY >= 1300)
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
            BoostEn.m_BoostSettings.SaveAppSettingsToFile();
        }

        private void chartSetup()
        {
            //Friend Chart
            foreach(DateAndValue friendCounter in BoostEn.m_BoostSettings.FriendCounter)
            {
                this.dashboard.chartFriends.Series[0].Points.AddXY(
                    friendCounter.Date.Date.ToString("d/M/yy"),
                    friendCounter.Value);
            }

            this.dashboard.chartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;
            //this.dashboard.chartFriends.AlignDataPointsByAxisLabel(); 

            //Engagement Chart
            for(int i = 0; i < BoostEngine.k_NumOfPostsForEngagement; i++)
            {
                DateAndValue currentLikes = BoostEn.EngagementRecentPostLikes[i];
                DateAndValue currentComments = BoostEn.EngagementRecentPostComments[i];

                this.dashboard.chartEngagement.Series["Likes"].Points.AddXY(
                    currentLikes.Date.ToString(),
                    currentLikes.Value);
                this.dashboard.chartEngagement.Series["Comments"].Points.AddXY(
                    currentComments.Date.ToString(),
                    currentComments.Value);

            }
        }
    }
}