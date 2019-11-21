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

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Boost : Form
    {
        public User m_LoggedInUser;

        public Boost()
        {
            InitializeComponent();
            Setup();
     
        }

        private void Setup()
        {
            dashboard.BringToFront();
            login.BringToFront();
            UI_Elements.initializerAddons(this);
            
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            dashboard.BringToFront();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            analytics.BringToFront();
        }

        public void fbLogin()
        {
            LoginResult result = FacebookWrapper.FacebookService.Login("748532218946260",
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

            m_LoggedInUser = result.LoggedInUser;

        }


        public void fetchAndLoadData()
        {
            String name = m_LoggedInUser.Name; ;

            this.btnUsername.Text = name;
            dashboard.labelName.Text = name;
            dashboard.labelBio1.Text = "Hometown: " + m_LoggedInUser.Location.Name;

            this.navbarProfilePic.LoadAsync(m_LoggedInUser.PictureSmallURL);
            this.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            dashboard.pictureBoxBioProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

        }

    }
}
