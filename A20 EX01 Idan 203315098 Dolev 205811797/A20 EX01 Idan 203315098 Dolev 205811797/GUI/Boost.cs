using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost : Form
    {
        public User m_LoggedInUser;

        //public List<Button> m_NavbarButtons = new List<Button>();
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;
        private readonly int k_CollectionLimit = 50;
        private int m_TopPostIndex = -1;

        public Boost()
        {
            InitializeComponent();
            Setup();

            m_AppSettings = new AppSettings();
            this.login.RegisterLoginMethod(this);
            
        }

        public enum eBoostPages : byte
        {
            Dashboard = 0,
            Analytics
        }

        private void Setup()
        {
            foreach(Button button in navbar.m_NavbarButtons)
            {
                button.Click += new System.EventHandler(this.NavbarButton_Click);
            }
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = UI_Elements.color_BGColorA;
            this.navbarSeparator.BringToFront();
            switchPage(navbar.m_NavbarButtons[0]); //1st button represents home page
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

            switch (i_Button.Name)
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
            this.login.labelLoading.Visible = true;

            FacebookService.s_CollectionLimit = k_CollectionLimit;

            m_LoginResult = FacebookService.Login("748532218946260",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");



            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
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
            String name = m_LoggedInUser.Name; ;

            navbar.btnUsername.Text = name;
            navbar.navbarProfilePic.LoadAsync(m_LoggedInUser.PictureSmallURL);
            navbar.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


            dashboard.labelName.Text = name;
            dashboard.pictureBoxBioProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            dashboard.labelBio1.Text = "Location: " + m_LoggedInUser.Location.Name;
            dashboard.labelBio2.Text = "Friends using Boost: " + m_LoggedInUser.Friends.Count;
            dashboard.labelBio3.Text = "Verified?: " + (m_LoggedInUser.Verfied == true ? "Yes" : "No")  ;
            int i = 0;
            Post lastStatus = m_LoggedInUser.Posts[i];
            while (lastStatus.Message == null && lastStatus.Type != Post.eType.status)
            {
                lastStatus = m_LoggedInUser.Posts[++i];
            }
            dashboard.labelRecentStatusUpdateContent.Text = "\"" + lastStatus.Message + "\"";
            dashboard.labelRecentStatusUpdateDateTime.Text = "- " + lastStatus.CreatedTime.ToString();

            int topLikes = -1;
            //Get Top Post
            int j = 0;
            foreach(Post post in m_LoggedInUser.Posts)
            {
                if(post.LikedBy.Count > topLikes)
                {
                    topLikes = post.LikedBy.Count;
                    m_TopPostIndex = j;
                }
                j++;
            }
            //
            dashboard.labelTopPostLikes.Text += m_LoggedInUser.Posts[m_TopPostIndex].LikedBy.Count;
            dashboard.labelTopPostComments.Text += m_LoggedInUser.Posts[m_TopPostIndex].Comments.Count;
            if(m_LoggedInUser.Posts[m_TopPostIndex].Message == null || m_LoggedInUser.Posts[m_TopPostIndex].Message == "")
            {
                dashboard.labelTopPostCaptionTitle.Visible = false;
                dashboard.labelTopPostCaptionContent.Visible = false;
            }
            else
            {
            dashboard.labelTopPostCaptionContent.Text = "\"" + m_LoggedInUser.Posts[m_TopPostIndex].Message + "\"";
            }
            dashboard.labelTopPostCaptionDateTime.Text = "- " + m_LoggedInUser.Posts[m_TopPostIndex].CreatedTime.ToString();
            dashboard.pictureBoxTopPost.LoadAsync(m_LoggedInUser.Posts[m_TopPostIndex].PictureURL);

  

            dashboard.DashboardUpdate();
            analytics.bestTimes.PopulateBestTimes(m_LoggedInUser.Posts);
            analytics.bestTimes.DrawBestTimesGrid();
        }
    }
}
