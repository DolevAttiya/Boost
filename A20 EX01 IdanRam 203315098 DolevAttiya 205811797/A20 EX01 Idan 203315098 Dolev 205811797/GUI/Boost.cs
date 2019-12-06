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
            LoginPage.m_LoginEvent += FacebookLogin;
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
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new Padding(0, 0, 0, 0);
            this.BackColor = Stylesheet.Color_BGColorA;
            
            // Bring UI elements to front in sequence
            NavbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); // Switch to the 1st button's page (App home page)
            welcomeScreen.Visible = false;
            welcomeScreen.BringToFront();
            this.LoginPage.CheckBoxRememberUser.Checked = BoostEn.m_BoostSettings.RememberUser;
            this.LoginPage.Visible = true;
            this.LoginPage.BringToFront();
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
                button.Font = Stylesheet.Font_NavbarButtonDefault;
            }

            switch(i_Button.Name)
            {
                case "btnDashboard":
                    DashboardPage.BringToFront();
                    break;
                case "btnAnalytics":
                    AnalyticsPage.BringToFront();
                    break;
                case "btnAbout":
                    AboutPage.BringToFront();
                    break;
            }

            i_Button.Font = Stylesheet.Font_NavbarButtonSelected;
        }

        public void FacebookLogin()
        {
            try
            {
                BoostEn.FacebookLogin(BoostEn.m_BoostSettings.LastAccessToken, BoostEn.m_BoostSettings.RememberUser);
            }
            catch(Exception)
            {
                LoginPage.LabelLoginError.Visible = true;
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
                BoostEn.m_BoostSettings.RememberUser = this.LoginPage.CheckBoxRememberUser.Checked;

                // Fetch and load data
                FetchUserData();
                dashboardChartSetup();
            }
            else
            {
                this.LoginPage.LabelLoading.Visible = true;
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
                AnalyticsPage.BestTimesPage.DrawBestTimesGrid(
                    (TimeAnalysis)BoostEn.TimeAnalysis.CreateAnalysisByTimeFrame(BoostEn.LoggedInUser));
                ///BiggestFans

                AnalyticsPage.BiggestFansPage.DisplayBiggestFans(
                    (BiggestFanAnalysis)BoostEn.BiggestFanAnalysis.CreateAnalysisByTimeFrame(
                        BoostEn.LoggedInUser,
                        eTimeSelector.Month));
            }
            catch(Exception)
            {
                AnalyticsPage.DisplayAnalyticsErrorMessage();
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
            DashboardPage.LabelEngagement.Text += $@" (Last {BoostEngine.k_NumOfPostsForEngagement} posts)";

            // Update dashboard UI after data fetch
            DashboardPage.UpdateDashboardUI();
        }

        private void fetchUserBioAndPhoto(string k_Quotes, string name)
        {
            Post lastStatus;
            try
            {
                ///Navigation bar
                navbar.BtnUsername.Text = name;
                navbar.NavbarProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureSmallURL);
                navbar.NavbarProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                ///Bio Panel
                DashboardPage.LabelName.Text = name;
                DashboardPage.PictureBoxBioProfilePic.LoadAsync(BoostEn.LoggedInUser.PictureLargeURL);
                DashboardPage.PictureBoxBioProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                DashboardPage.LabelBio1.Text = $@"Location: {BoostEn.LoggedInUser.Location.Name}";
                DashboardPage.LabelBio2.Text = $@"Friends using Boost: {BoostEn.LoggedInUser.Friends.Count}";
                DashboardPage.LabelBio3.Text = $@"Verified?: {(BoostEn.LoggedInUser.Verfied == true ? "Yes" : "No")}";
                
                // Recent Status Update
                lastStatus = BoostEn.GetLastStatus();
                DashboardPage.LabelRecentStatusUpdateContent.Text = $@"{k_Quotes}{lastStatus.Message}{k_Quotes}";
                DashboardPage.LabelRecentStatusUpdateDateTime.Text = $@"- {lastStatus.CreatedTime.ToString()}";
            }
            catch (NullReferenceException)
            {
                DashboardPage.DisplayDashboardErrorMessage();
            }
        }

        private void displayFriendChange()
        {
            try
            {
                if (BoostEn.FriendChange != 0)
                {
                    DashboardPage.LabelFriendsChange.Visible = true;
                    if (BoostEn.FriendChange > 0)
                    {
                        DashboardPage.LabelFriendsChange.Text = "+" + BoostEn.FriendChange.ToString();
                        DashboardPage.LabelFriendsChange.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        DashboardPage.LabelFriendsChange.Text = BoostEn.FriendChange.ToString();
                        DashboardPage.LabelFriendsChange.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
            catch (Exception)
            {
                DashboardPage.DisplayDashboardErrorMessage();
                DashboardPage.LabelError.Text = "Could not fetch data from boostSettings.xml";
            }
        }

        private void fetchTopPost(string k_Quotes)
        {
            Post topPost;
            try
            {
                topPost = BoostEn.GetTopPost();
                DashboardPage.LabelTopPostLikes.Text += topPost.LikedBy.Count;
                DashboardPage.LabelTopPostComments.Text += topPost.Comments.Count;
                if (string.IsNullOrEmpty(topPost.Message))
                {
                    DashboardPage.LabelTopPostCaptionTitle.Visible = false;
                    DashboardPage.LabelTopPostCaptionContent.Visible = false;
                }
                else
                {
                    DashboardPage.LabelTopPostCaptionContent.Text = $@"{k_Quotes}{topPost.Message}{k_Quotes}";
                }

                DashboardPage.LabelTopPostCaptionDateTime.Text = $@"- {topPost.CreatedTime.ToString()}";
                if (!string.IsNullOrWhiteSpace(topPost.PictureURL))
                {
                    DashboardPage.PictureBoxTopPost.LoadAsync(topPost.PictureURL);
                }
            }
            catch (NullReferenceException)
            {
                DashboardPage.LabelTopPostError.Text = BoostEngine.k_PostErrorMessage;
                DashboardPage.LabelTopPostError.Visible = true;
                DashboardPage.LabelTopPostLikes.Visible = false;
                DashboardPage.LabelTopPostComments.Visible = false;
                DashboardPage.LabelTopPostCaptionDateTime.Visible = false;
                DashboardPage.PictureBoxTopPost.Visible = false;
            }
        }

        private void dashboardChartSetup()
        {
            // Friend Chart
            foreach(DateAndValue friendCounter in BoostEn.m_BoostSettings.FriendCounter)
            {
                this.DashboardPage.ChartFriends.Series[0].Points.AddXY(
                    friendCounter.Date.Date.ToString("d/M/yy"),
                    friendCounter.Value);
            }

            this.DashboardPage.ChartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;

            // Engagement Chart
            for(int i = 0; i < BoostEngine.k_NumOfPostsForEngagement; i++)
            {
                DateAndValue currentLikes = BoostEn.EngagementRecentPostLikes[i];
                DateAndValue currentComments = BoostEn.EngagementRecentPostComments[i];

                this.DashboardPage.ChartEngagement.Series["Likes"].Points.AddXY(
                    currentLikes.Date.ToString(),
                    currentLikes.Value);
                this.DashboardPage.ChartEngagement.Series["Comments"].Points.AddXY(
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