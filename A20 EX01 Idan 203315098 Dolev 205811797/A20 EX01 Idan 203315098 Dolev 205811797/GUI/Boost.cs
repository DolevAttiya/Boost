using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost : Form
    {
        #region Data Members
        public BoostEngine BoostEn { get; set; }

        public enum eBoostPages : byte
        {
            Dashboard = 0,
            Analytics,
            About
        }
        #endregion

        #region Ctor
        public Boost()
        {
            BoostEn = new BoostEngine();
            InitializeComponent();
            boostFormInitialSetup();
            login.m_LoginEvent += FacebookLogin;
        }
        #endregion

        #region Methods
        private void boostFormInitialSetup()
        {
            // Add event handler to dynamically added buttons
            foreach(Button button in navbar.m_NavbarButtons)
            {
                button.Click += new EventHandler(this.NavbarButton_Click);
            }

            // Boost Frame properties
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new Padding(0, 0, 0, 0);
            this.BackColor = Stylesheet.color_BGColorA;
            
            // Bring UI elements to front in sequence
            navbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); // Switch to the 1st button's page (App home page)
            welcomeScreen.Visible = false;
            welcomeScreen.BringToFront();
            this.login.checkBoxRememberUser.Checked = BoostEn.m_BoostSettings.RememberUser;
            this.login.Visible = true;
            this.login.BringToFront();
        }

        private void Boost_FormClosing(object sender, FormClosingEventArgs e)
        {
            BoostEn.m_BoostSettings.SaveAppSettingsToFile();
        }

        public void NavbarButton_Click(object sender, EventArgs e)
        {
            switchPage((Button)sender);
        }

        private void switchPage(Button i_Button)
        {
            foreach(Button button in navbar.m_NavbarButtons)
            {
                button.Font = Stylesheet.font_NavbarButtonDefault;
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

            i_Button.Font = Stylesheet.font_NavbarButtonSelected;
        }

        public void FacebookLogin()
        {
            try
            {
                BoostEn.FacebookLogin(BoostEn.m_BoostSettings.LastAccessToken, BoostEn.m_BoostSettings.RememberUser);
            }
            catch(Exception)
            {
                login.labelLoginError.Visible = true;
            }

            bool isTheUserLoggedIn = BoostEn.LoggedInUser != null;
            if(isTheUserLoggedIn)
            {
                // Identify Login (Email as ID + First login)
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

                // Overwrite Boost Settings
                BoostEn.m_BoostSettings.LastLoggedInEmail = currentUserEmail;
                BoostEn.m_BoostSettings.FirstLogin = false;
                BoostEn.m_BoostSettings.LastAccessToken = BoostEn.LoginResult.AccessToken;
                BoostEn.m_BoostSettings.LastLogin = DateTime.Now;
                BoostEn.m_BoostSettings.RememberUser = this.login.checkBoxRememberUser.Checked;

                // Fetch and load data
                FetchUserData();
                dashboardChartSetup();
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

                analytics.biggestFans.DisplayBiggestFans(
                    (BiggestFanAnalysis)BoostEn.BiggestFanAnalysis.CreateAnalysisByTimeFrame(
                        BoostEn.LoggedInUser,
                        eTimeSelector.Month));
            }
            catch(Exception)
            {
                analytics.DisplayAnalyticsErrorMessage();
            }
        }

        private void fetchDashboardData()
        {
            const string k_Quotes = "\"";
            string name = BoostEn.LoggedInUser.Name;

            fetchUserBioAndPhoto(k_Quotes, name);

            ///Top Post
            fetchTopPost(k_Quotes);

            /// Friends Panel
            displayFriendChange();

            /// Engagement Panel
            dashboard.labelEngagement.Text += $@" (Last {BoostEngine.k_NumOfPostsForEngagement} posts)";

            // Update dashboard UI after data fetch
            dashboard.UpdateDashboardUI();
        }

        private void fetchUserBioAndPhoto(string k_Quotes, string name)
        {
            Post lastStatus;
            try
            {
                ///Navigation bar
                navbar.btnUsername.Text = name;
                navbar.navbarProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureSmallURL);
                navbar.navbarProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                ///Bio Panel
                dashboard.labelName.Text = name;
                dashboard.pictureBoxBioProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureLargeURL);
                dashboard.pictureBoxBioProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                dashboard.labelBio1.Text = $@"Location: {BoostEn.LoggedInUser.Location.Name}";
                dashboard.labelBio2.Text = $@"Friends using Boost: {BoostEn.LoggedInUser.Friends.Count}";
                dashboard.labelBio3.Text = $@"Verified?: {(BoostEn.LoggedInUser.Verfied == true ? "Yes" : "No")}";
                
                // Recent Status Update
                lastStatus = BoostEn.GetLastStatus();
                dashboard.labelRecentStatusUpdateContent.Text = $@"{k_Quotes}{lastStatus.Message}{k_Quotes}";
                dashboard.labelRecentStatusUpdateDateTime.Text = $@"- {lastStatus.CreatedTime.ToString()}";
            }
            catch (NullReferenceException)
            {
                dashboard.DisplayDashboardErrorMessage();
            }
        }

        private void displayFriendChange()
        {
            try
            {
                if (BoostEn.FriendChange != 0)
                {
                    dashboard.labelFriendsChange.Visible = true;
                    if (BoostEn.FriendChange > 0)
                    {
                        dashboard.labelFriendsChange.Text = "+" + BoostEn.FriendChange.ToString();
                        dashboard.labelFriendsChange.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        dashboard.labelFriendsChange.Text = BoostEn.FriendChange.ToString();
                        dashboard.labelFriendsChange.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
            catch (Exception)
            {
                dashboard.DisplayDashboardErrorMessage();
                dashboard.labelError.Text = "Could not fetch data from boostSettings.xml";
            }
        }

        private void fetchTopPost(string k_Quotes)
        {
            Post topPost;
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
                if (!string.IsNullOrWhiteSpace(topPost.PictureURL))
                {
                    dashboard.pictureBoxTopPost.LoadAsync(topPost.PictureURL);
                }
            }
            catch (NullReferenceException)
            {
                dashboard.labelTopPostError.Text = BoostEngine.k_PostErrorMessage;
                dashboard.labelTopPostError.Visible = true;
                dashboard.labelTopPostLikes.Visible = false;
                dashboard.labelTopPostComments.Visible = false;
                dashboard.labelTopPostCaptionDateTime.Visible = false;
                dashboard.pictureBoxTopPost.Visible = false;
            }
        }

        private void dashboardChartSetup()
        {
            // Friend Chart
            foreach(DateAndValue friendCounter in BoostEn.m_BoostSettings.FriendCounter)
            {
                this.dashboard.chartFriends.Series[0].Points.AddXY(
                    friendCounter.Date.Date.ToString("d/M/yy"),
                    friendCounter.Value);
            }

            this.dashboard.chartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;

            // Engagement Chart
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
        #endregion
    }
}