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
using A20_EX01_Idan_203315098_Dolev_205811797.GUI;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Boost : Form
    {
        public User m_LoggedInUser;

        //UI Data Members
        private List<Button> m_NavbarButtons = new List<Button>();
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;

        public Boost()
        {
            InitializeComponent();
            Setup();

            m_AppSettings = new AppSettings();
            this.login.AddLoginMethod(this);
            
        }

        private void Setup()
        {
            m_NavbarButtons.Add(this.btnDashboard);
            m_NavbarButtons.Add(this.btnAnalytics);
            m_NavbarButtons.Add(this.btnUsername);
            foreach(Button button in m_NavbarButtons)
            {
                button.ForeColor = UI_Elements.color_NavbarButtonColor;
            }
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = UI_Elements.color_BGColor;
            switchPage(this.btnDashboard);
            this.login.Visible = true;
            login.BringToFront();            
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            dashboard.BringToFront();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            analytics.BringToFront();
        }

        private void NavbarButton_Click(object sender, EventArgs e)
        {
            switchPage((Button)sender);
        }

        private void switchPage(Button i_Button)
        {

            foreach(Button button in m_NavbarButtons)
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

            FacebookService.s_CollectionLimit = 50;

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
                //MessageBox.Show(result.ErrorMessage);
            }

        }

        //protected override void OnFormClosed(FormClosedEventArgs e)
        //{
        //    base.OnFormClosed(e);
        //}


        public void FetchUserData()
        {
            String name = m_LoggedInUser.Name; ;

            this.btnUsername.Text = name;
            this.navbarProfilePic.LoadAsync(m_LoggedInUser.PictureSmallURL);
            this.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


            dashboard.labelName.Text = name;
            dashboard.pictureBoxBioProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            dashboard.labelBio1.Text = "Location: " + m_LoggedInUser.Location.Name;
            dashboard.labelBio2.Text = "Friends using Boost: " + m_LoggedInUser.Friends.Count;
            dashboard.labelBio3.Text = "Verified?: " + (m_LoggedInUser.Verfied == true ? "Yes" : "No")  ;
            int i = 0;
            Post lastPost = m_LoggedInUser.Posts[i];
            while (lastPost.Message == null)
            {
                lastPost = m_LoggedInUser.Posts[++i];
            }
            dashboard.labelRecentActivityContent.Text = "\"" + lastPost.Message + "\"";
            dashboard.labelRecentActivityDateTime.Text = "- " + lastPost.CreatedTime.ToString();
            dashboard.DashboardUpdate();
            analytics.bestTimes.PopulateBestTimes(m_LoggedInUser.Posts);
            analytics.bestTimes.DrawBestTimesGrid();
            //foreach (Post post in m_LoggedInUser.Posts)
            //{
            //    dashboard.m_EngagementList.Add(new Engagement(post));
            //}
            //dashboard.ChartSetup();
        }

    }
}
