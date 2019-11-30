using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost : Form
    {
        ////public List<Button> m_NavbarButtons = new List<Button>();
        private AppSettings m_AppSettings;

        //// need to think what to do with it
        public BoostEngine BoostEn { get; set; } 

        public Boost()
        {
            InitializeComponent();
            setup();
            BoostEn = new BoostEngine();
            m_AppSettings = new AppSettings();
            this.login.RegisterLoginMethod(this);
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
            this.navbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); ////1st button represents home page
            this.login.Visible = true;
            login.BringToFront();
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

        public void FacebookLogin() ////temp -> Engine
        {
            BoostEn.FacebookLogin();
            bool isTheUserLoggedIn = BoostEn.LoggedInUser != null;
            if(isTheUserLoggedIn)
            {
                this.login.labelLoading.Visible = true;
                FetchUserData();
            }
            else
            {
                this.login.labelLoginError.BringToFront();
                this.login.labelLoginError.Visible = true;
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

            topPost = BoostEn.GetTopPost();

            if(topPost == null)
            {
                throw new NullReferenceException("Couldn't get the best Post");
            }

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
            dashboard.pictureBoxTopPost.LoadAsync(topPost.PictureURL);

            dashboard.DashboardUpdate();
            ////analytics.bestTimes.PopulateBestTimes(BoostEn.LoggedInUser.Posts); Not Really needed anymore
            analytics.bestTimes.DrawBestTimesGrid(
                BoostEn.TimeAnalysis.GetAnalysisByTimeStrict(BoostEn.LoggedInUser, eTimerSelector.Month) as
                    TimeAnalysis); ////TODO For greed need to make a new method withoutCalculate
        }
    }
}