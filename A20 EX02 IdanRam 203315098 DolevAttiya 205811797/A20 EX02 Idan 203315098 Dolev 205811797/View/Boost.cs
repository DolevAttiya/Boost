using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class Boost : Form
    {
        #region Data Members

        public BoostEngine m_BoostEn;
        private bool m_InitialLogin;
        private Settings m_SettingsPopup = null;

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
            m_BoostEn = BoostEngine.Instance;
            m_InitialLogin = false;
            InitializeComponent();
            boostFormInitialSetup();
            LoginPage.m_LoginEvent += FacebookLogin;
            userOptions.m_LogoutEvent += FacebookLogout;
            userOptions.m_SettingsEvent += displaySettingsPopup;
            userOptions.m_OptionClickEvent += navbar.DeselectBtnUsername;
        }
        #endregion

        #region Methods
        private void boostFormInitialSetup()
        {
            if(!m_InitialLogin)
            {
                // Add event handler to dynamically added buttons
                foreach(Button button in navbar.m_NavbarButtons)
                {
                    button.Click += new EventHandler(this.NavbarButton_Click);
                }

                navbar.m_UsernameButtonEvent += new UsernameButtonEventHandler(toggleUserOptionPanel);

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
            navbar.SetButtonStyleToDefault(navbar.BtnUsername);
            userOptions.Visible = false;
            userOptions.AdjustUserOptionsSize();
            userOptions.Location = new System.Drawing.Point(
                navbar.BtnUsername.Right - userOptions.Width + navbar.Location.X,
                navbar.BtnUsername.Bottom);
            initializeLoginPage();
            ////
        }

        private void initializeLoginPage()
        {
            LoginPage.CheckBoxRememberUser.Checked = m_BoostEn.m_BoostSettings.RememberUser;
            LoginPage.BringToFront();
            LoginPage.LabelLoading.Visible = false;
            LoginPage.Visible = true; // true
        }

        private void initializeSettingsPopUp()
        {
            m_SettingsPopup = new Settings();
            m_SettingsPopup.BoostSettingsBindingSource.DataSource = m_BoostEn.m_BoostSettings;
        }

        private void toggleUserOptionPanel()
        {
            userOptions.BringToFront();
            userOptions.Visible = !userOptions.Visible; // Toggle visibility
        }

        private void Boost_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_BoostEn.m_BoostSettings.SaveAppSettingsToFile();
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
                m_BoostEn.FacebookLogout();
                MessageBox.Show(@"Logout successful!");
                boostFormInitialSetup();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, @"Logout failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void FacebookLogin()
        {
            try
            {
                m_BoostEn.FacebookLogin(m_BoostEn.m_BoostSettings.LastAccessToken, m_BoostEn.m_BoostSettings.RememberUser);
            }
            catch(Exception)
            {
                LoginPage.LabelLoginError.Visible = true;
            }

            bool isTheUserLoggedIn = m_BoostEn.LoggedInUser != null;
            if(isTheUserLoggedIn)
            {
                fetchAndInitialize();
                LoginPage.Visible = false;
            }
        }

        private void fetchAndInitialize()
        {
            try
            {
                if (!m_InitialLogin)
                {
                    m_InitialLogin = true;
                }

                // Identify Login (Email as ID + First login)
                string currentUserEmail = m_BoostEn.LoggedInUser.Email;
                if (currentUserEmail != m_BoostEn.m_BoostSettings.LastLoggedInEmail)
                {
                    m_BoostEn.m_BoostSettings.LastLogin = null;
                    m_BoostEn.m_BoostSettings.FirstLogin = true;
                }

                // Fetch and load data
                FetchUserData();
                initializeSettingsPopUp();
                dashboardChartSetup();
                displayWhatsNewPopup();
                overwriteBoostSettings(currentUserEmail);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void overwriteBoostSettings(string i_userEmail)
        {
            // Overwrite Boost Settings
            m_BoostEn.m_BoostSettings.LastLoggedInEmail = i_userEmail;
            m_BoostEn.m_BoostSettings.FirstLogin = false;
            m_BoostEn.m_BoostSettings.LastAccessToken = m_BoostEn.LoginResult.AccessToken;
            m_BoostEn.m_BoostSettings.LastLogin = DateTime.Now;
            m_BoostEn.m_BoostSettings.RememberUser = this.LoginPage.CheckBoxRememberUser.Checked;
            m_BoostEn.m_BoostSettings.LastUsedVersion = BoostEngine.R_CurrentVersion;
        }

        private void displayWhatsNewPopup()
        {
            if (m_BoostEn.m_BoostSettings.LastUsedVersion != BoostEngine.R_CurrentVersion)
            {
                WhatsNew whatsNew = new WhatsNew();
                whatsNew.Visible = true;
            }
        }

        private void displaySettingsPopup()
        {
            m_SettingsPopup.Show();
        }

        public void FetchUserData()
        {
            m_BoostEn.FriendCountSetup();
            m_BoostEn.SetupEngagementArrays();
            fetchDashboardData();
            fetchAnalyticsPageData();
        }

        private void fetchAnalyticsPageData()
        {
            try
            {
                ///BestTimes
                new Thread(new ThreadStart(() => { AnalyticsPage.BestTimesPage.DrawBestTimesGrid(); })).Start();
                
                ///BiggestFans
                this.Invoke(new Action(() => AnalyticsPage.BiggestFansPage.DisplayBiggestFans()));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                AnalyticsPage.DisplayAnalyticsErrorMessage();
            }
        }

        private void fetchDashboardData()
        {
            const string k_Quotes = "\"";
            string name = m_BoostEn.LoggedInUser.Name;

            fetchUserBioAndPhoto(k_Quotes, name);

            ///Top Post
            fetchTopPost(k_Quotes);

            /// Friends Panel
            displayFriendChange();

            /// Engagement Panel
            this.Invoke(
                new Action(
                    () => DashboardPage.LabelEngagement.Text =
                              $@"Engagement (Last {BoostEngine.k_NumOfPostsForEngagement} posts)"));

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
                    navbar.NavbarProfilePic.LoadAsync(m_BoostEn.LoggedInUser.PictureSmallURL);
                    navbar.NavbarProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                    ///Bio Panel
                    DashboardPage.LabelName.Text = name;
                    DashboardPage.PictureBoxBioProfilePic.LoadAsync(m_BoostEn.LoggedInUser.PictureLargeURL);
                    DashboardPage.PictureBoxBioProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                    DashboardPage.LabelBio1.Text = $@"Location: {m_BoostEn.LoggedInUser.Location.Name}";
                    DashboardPage.LabelBio2.Text = $@"Friends using Boost: {m_BoostEn.LoggedInUser.Friends.Count}";
                    DashboardPage.LabelBio3.Text = $@"Verified?: {(m_BoostEn.LoggedInUser.Verfied == true ? "Yes" : "No")}";

                    // Recent Status Update
                    lastStatus = m_BoostEn.GetLastStatus();
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
                if (m_BoostEn.FriendChange != 0)
                {
                    DashboardPage.LabelFriendsChange.Visible = true;
                    if (m_BoostEn.FriendChange > 0)
                    {
                        DashboardPage.LabelFriendsChange.Text = "+" + m_BoostEn.FriendChange.ToString();
                        DashboardPage.LabelFriendsChange.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        DashboardPage.LabelFriendsChange.Text = m_BoostEn.FriendChange.ToString();
                        DashboardPage.LabelFriendsChange.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
            catch (Exception)
            {
                DashboardPage.DisplayDashboardErrorMessage();
                DashboardPage.LabelError.Text = @"Could not fetch data from boostSettings.xml";
            }
        }

        private void fetchTopPost(string k_Quotes)
        {
            Post topPost;
            try
            {
                this.Invoke(
                    new Action(
                        () =>
                            {
                                topPost = m_BoostEn.GetTopPost();
                                DashboardPage.LabelTopPostLikes.Text = $@"Likes: {topPost.LikedBy.Count}";
                                DashboardPage.LabelTopPostComments.Text = $@"Comments: {topPost.Comments.Count}";
                                if(string.IsNullOrEmpty(topPost.Message))
                                {
                                    DashboardPage.LabelTopPostCaptionTitle.Visible = false;
                                    DashboardPage.LabelTopPostCaptionContent.Visible = false;
                                }
                                else
                                {
                                    DashboardPage.LabelTopPostCaptionContent.Text =
                                        $@"{k_Quotes}{topPost.Message}{k_Quotes}";
                                }

                                DashboardPage.LabelTopPostCaptionDateTime.Text = $@"- {topPost.CreatedTime.ToString()}";
                                if(!string.IsNullOrWhiteSpace(topPost.PictureURL))
                                {
                                    DashboardPage.PictureBoxTopPost.LoadAsync(topPost.PictureURL);
                                }
                            }));
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
            this.Invoke(new Action(() =>
            {
                // Friend Chart
                foreach(DateAndValue friendCounter in m_BoostEn.m_BoostSettings.FriendCounter)
                {
                    this.DashboardPage.ChartFriends.Series[0].Points.AddXY(
                        friendCounter.Date.Date.ToString("d/M/yy"),
                        friendCounter.Value);
                }

                this.DashboardPage.ChartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;

                // Engagement Chart
                for(int i = 0; i < BoostEngine.k_NumOfPostsForEngagement; i++)
                {
                    DateAndValue currentLikes = m_BoostEn.EngagementRecentPostLikes[i];
                    DateAndValue currentComments = m_BoostEn.EngagementRecentPostComments[i];

                    this.DashboardPage.ChartEngagement.Series["Likes"].Points.AddXY(
                        currentLikes.Date.ToString(),
                        currentLikes.Value);
                    this.DashboardPage.ChartEngagement.Series["Comments"].Points.AddXY(
                        currentComments.Date.ToString(),
                        currentComments.Value);
                }
            }));
        }
        #endregion
    }
}