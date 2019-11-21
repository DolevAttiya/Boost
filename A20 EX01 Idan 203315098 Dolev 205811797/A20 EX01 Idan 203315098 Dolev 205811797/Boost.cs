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

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            dashboard.BringToFront();
            this.login.Visible = true;
            login.BringToFront();            
        }

        //private void loginPanelSetup()
        //{
        //    this.login.Location = new System.Drawing.Point(-5, -5);
        //    this.login.Name = "login";
        //    this.login.Size = new System.Drawing.Size(1141, 643);
        //    this.login.Visible = false;
        //}

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

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserData();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }


        public void fetchUserData()
        {
            String name = m_LoggedInUser.Name; ;

            this.btnUsername.Text = name;
            this.navbarProfilePic.LoadAsync(m_LoggedInUser.PictureSmallURL);
            this.navbarProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


            dashboard.labelName.Text = name;
            dashboard.pictureBoxBioProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            dashboard.pictureBoxBioProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            dashboard.labelBio1.Text = "Hometown: " + m_LoggedInUser.Hometown.Location.City;
            dashboard.labelBio2.Text = "Friends: " + m_LoggedInUser.Friends.Count;
            try
            {
                Post lastPost = m_LoggedInUser.Posts[m_LoggedInUser.Posts.Count];
                dashboard.labelBio3.Text = "Last Posted on: " + lastPost.CreatedTime.ToString();
                dashboard.labelLastPostContent.Text = lastPost.Caption;
            }
            catch
            {
                dashboard.labelBio3.Text = "???";
            }


        }

    }
}
