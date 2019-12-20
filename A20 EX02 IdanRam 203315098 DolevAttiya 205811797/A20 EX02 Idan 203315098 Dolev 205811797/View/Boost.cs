using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using System.Threading;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class Boost : Form
    {
        #region Data Members
        public BoostEngine BoostEn { get; set; }
        private bool m_InitialLogin;

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
            m_InitialLogin = false;
            InitializeComponent();
            boostFormInitialSetup();
            LoginPage.m_LoginEvent += FacebookLogin;
            userOptions.m_LogoutEvent += FacebookLogout;
        }
        #endregion

        #region Methods
        private void boostFormInitialSetup()
        {
            if (!m_InitialLogin)
            {
                // Add event handler to dynamically added buttons
                foreach (Button button in navbar.m_NavbarButtons)
                {
                    button.Click += new EventHandler(this.NavbarButton_Click);
                }
                navbar.m_UsernameButtonEvent += new UsernameButtonEventHandler(toggleUsernameOptionPanel);

                // Boost Frame properties
                this.MaximizeBox = false;
                this.MinimizeBox = true;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Margin = new Padding(0, 0, 0, 0);
                this.BackColor = Stylesheet.Color_BGColorA;
            }


            //// Adjust UI before login
            // Clear Charts
            foreach(var series in DashboardPage.ChartEngagement.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in DashboardPage.ChartFriends.Series)
            {
                series.Points.Clear();
            }

            // Sort elements for app startup
            NavbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); // Switch to the 1st button's page (App home page)
            welcomeScreen.Visible = false;
            welcomeScreen.BringToFront();
            navbar.SetButtonStyleToDefault(navbar.BtnUsername);
            userOptions.Visible = false;
            userOptions.AdjustUserOptionsSize();
            userOptions.Location = new System.Drawing.Point(navbar.BtnUsername.Right-userOptions.Width + (navbar.Location.X), navbar.BtnUsername.Bottom);
            initializeLoginPage();
            ////
        }

        private void initializeLoginPage()
        {
            LoginPage.CheckBoxRememberUser.Checked = BoostEn.m_BoostSettings.RememberUser;
            LoginPage.BringToFront();
            LoginPage.LabelLoading.Visible = false;
            LoginPage.Visible = true; // true
        }


        private void toggleUsernameOptionPanel()
        {
            userOptions.BringToFront();
            userOptions.Visible = !userOptions.Visible; // Toggle visibility
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
            navbar.SelectButton(i_Button);

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

            if(userOptions.Visible)
            {
                userOptions.BringToFront();
            }
        }

        public void FacebookLogout()
        {
            try
            {
                BoostEn.FacebookLogout();
                MessageBox.Show("Logout successful!");
                boostFormInitialSetup();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Logout failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                if(!m_InitialLogin)
                {
                    m_InitialLogin = true;
                }
                // Identify Login (Email as ID + First login)
                string currentUserEmail = BoostEn.LoggedInUser.Email;
                if(currentUserEmail != BoostEn.m_BoostSettings.LastLoggedInEmail)
                {
                    BoostEn.m_BoostSettings.LastLogin = null;
                    BoostEn.m_BoostSettings.FirstLogin = true;
                }

                /*if(BoostEn.m_BoostSettings.IsFirstLogin()) // TODO - remove welcome screen?
                {
                    welcomeScreen.Visible = true;
                    welcomeScreen.m_Start += new WelcomeScreenEventHandler(welcomeScreenStart);
                }*/

                // Fetch and load data
                FetchUserData();
                dashboardChartSetup();
                displayWhatsNewPopup();
                overwriteBoostSettings(currentUserEmail);
            }
            else
            {
                this.LoginPage.LabelLoading.Visible = true;
                FetchUserData();
            }
        }

        private void overwriteBoostSettings(string i_userEmail){
            // Overwrite Boost Settings
            BoostEn.m_BoostSettings.LastLoggedInEmail = i_userEmail;
            BoostEn.m_BoostSettings.FirstLogin = false;
            BoostEn.m_BoostSettings.LastAccessToken = BoostEn.LoginResult.AccessToken;
            BoostEn.m_BoostSettings.LastLogin = DateTime.Now;
            BoostEn.m_BoostSettings.RememberUser = this.LoginPage.CheckBoxRememberUser.Checked;
            BoostEn.m_BoostSettings.LastUsedVersion = BoostEngine.r_CurrentVersion;
        }

        private void displayWhatsNewPopup()
        {
            if (BoostEn.m_BoostSettings.LastUsedVersion != BoostEngine.r_CurrentVersion)
            {
                WhatsNew whatsNew = new WhatsNew();
                whatsNew.Visible = true;
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
                new Thread(new ThreadStart( () => {
                    AnalyticsPage.BestTimesPage.DrawBestTimesGrid(
                    (TimeAnalysis)BoostEn.TimeAnalysis.CreateAnalysisByTimeFrame(BoostEn.LoggedInUser));
                   }) ).Start();
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

            new Thread(new ThreadStart(() =>
            {
                fetchUserBioAndPhoto(k_Quotes, name);
            })).Start();

            ///Top Post
            fetchTopPost(k_Quotes);

            /// Friends Panel
            displayFriendChange();

            /// Engagement Panel
            DashboardPage.LabelEngagement.Text = $@"Engagement (Last {BoostEngine.k_NumOfPostsForEngagement} posts)";

            // Update dashboard UI after data fetch
            new Thread(DashboardPage.UpdateDashboardUI).Start();
        }

        private void fetchUserBioAndPhoto(string k_Quotes, string name)
        {
            Post lastStatus;
            try
            {
                this.Invoke(new Action(() =>
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

                }));
                
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
                DashboardPage.LabelTopPostLikes.Text = string.Format(@"Likes: {0}" ,topPost.LikedBy.Count);
                DashboardPage.LabelTopPostComments.Text = string.Format(@"Comments: {0}" ,topPost.Comments.Count);
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