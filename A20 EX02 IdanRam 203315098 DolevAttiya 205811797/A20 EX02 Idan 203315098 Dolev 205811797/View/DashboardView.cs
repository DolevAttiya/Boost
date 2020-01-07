using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.View.UI_Controls;
using A20_EX02_Idan_203315098_Dolev_205811797.ViewModels;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class DashboardView : UserControl
    {
        #region Data Members & Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Engagement> m_EngagementList;

        public List<StylizedPanel> m_DashboardPanelList = new List<StylizedPanel>();

        private DashboardViewModel m_DashboardViewModel = new DashboardViewModel();

        #endregion

        #region Ctor
        public DashboardView()
        {
            m_EngagementList = new List<Engagement>();
            InitializeComponent();
            dashboardInitialSetup();
        }
        #endregion

        #region Methods
        private void dashboardInitialSetup()
        {
            //// Add panels to list
            m_DashboardPanelList.Add(panelEngagement);
            m_DashboardPanelList.Add(panelFriends);
            m_DashboardPanelList.Add(panelTopPost);
            m_DashboardPanelList.Add(panelUserBio);

            foreach (StylizedPanel panel in m_DashboardPanelList)
            {
                panel.GradientColorA = Stylesheet.Color_PanelColorA;
                panel.GradientColorB = Stylesheet.Color_PanelColorB;
                panel.GradientAngle = 90F;
            }

            //// Enforcing visual styles (in case of designer auto change)
            BackColor = System.Drawing.Color.Transparent;
            LabelName.Font = Stylesheet.Font_Header1;
            LabelBio1.Font = Stylesheet.Font_Header3;
            LabelBio2.Font = Stylesheet.Font_Header3;
            LabelBio3.Font = Stylesheet.Font_Header3;
            LabelRecentStatusUpdateTitle.Font = Stylesheet.Font_Header2Underline;
            LabelRecentStatusUpdateContent.Font = Stylesheet.Font_BodyItalics;
            LabelRecentStatusUpdateDateTime.Font = Stylesheet.Font_Body;
            LabelEngagement.Font = Stylesheet.Font_Header2;
            LabelFriends.Font = Stylesheet.Font_Header2;
            LabelTopPost.Font = Stylesheet.Font_Header2;
            LabelTopPostLikes.Font = Stylesheet.Font_Header3;
            LabelTopPostComments.Font = Stylesheet.Font_Header3;
            LabelTopPostCaptionTitle.Font = Stylesheet.Font_Header2Underline;
            LabelTopPostCaptionContent.Font = Stylesheet.Font_BodyItalics;
            LabelTopPostCaptionDateTime.Font = Stylesheet.Font_Body;
        }

        public void DisplayDashboardErrorMessage()
        {
            panelEngagement.Visible = false;
            panelUserBio.Visible = false;
            panelFriends.Visible = false;
            panelTopPost.Visible = false;
            LabelError.Visible = true;
            LabelError.BringToFront();
        }

        public void UpdateDashboardUI()
        {
            Invoke(new Action(() =>
            {
                //// Dynamic Label Positions
                //// BioPanel
                //// LabelName
                LabelName.Location = new System.Drawing.Point(
                    PictureBoxBioProfilePic.Location.X,
                    PictureBoxBioProfilePic.Bottom);
                LabelName.MinimumSize = new System.Drawing.Size(PictureBoxBioProfilePic.Width, 0);
                //// LabelBio1
                LabelBio1.Location = new System.Drawing.Point(LabelName.Location.X, LabelName.Bottom);
                LabelBio1.Size = new System.Drawing.Size(LabelName.Width, 22);
                //// LabelBio2
                LabelBio2.Location = new System.Drawing.Point(LabelBio1.Location.X, LabelBio1.Bottom);
                LabelBio2.Size = new System.Drawing.Size(LabelBio1.Width, LabelBio1.Height);
                LabelBio2.Padding = LabelBio1.Padding;
                LabelBio2.Margin = LabelBio1.Margin;
                //// LabelBio3
                LabelBio3.Location = new System.Drawing.Point(LabelBio2.Location.X, LabelBio2.Bottom);
                LabelBio3.Size = new System.Drawing.Size(LabelBio2.Width, LabelBio2.Height);
                LabelBio3.Padding = LabelBio2.Padding;
                LabelBio3.Margin = LabelBio2.Margin;
                //// LabelRecentStatusUpdateTltle
                LabelRecentStatusUpdateTitle.Location = new System.Drawing.Point(
                    LabelBio3.Location.X,
                    LabelBio3.Bottom);
                LabelRecentStatusUpdateTitle.Size = new System.Drawing.Size(
                    LabelBio3.Width,
                    LabelRecentStatusUpdateTitle.Height);
                //// LabelRecentStatusUpdateContent
                LabelRecentStatusUpdateContent.Location = new System.Drawing.Point(
                    LabelRecentStatusUpdateTitle.Location.X,
                    LabelRecentStatusUpdateTitle.Bottom);
                LabelRecentStatusUpdateContent.Size = new System.Drawing.Size(
                    LabelRecentStatusUpdateTitle.Width,
                    LabelRecentStatusUpdateContent.Height);
                LabelRecentStatusUpdateContent.AutoSize = true;
                LabelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(
                    LabelRecentStatusUpdateContent.Width,
                    0);
                LabelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(
                    LabelRecentStatusUpdateContent.Width,
                    171);
                //// LabelRecentStatusUpdateDateTime
                LabelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(
                    LabelRecentStatusUpdateContent.Location.X,
                    LabelRecentStatusUpdateContent.Bottom);
                LabelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(
                    LabelRecentStatusUpdateContent.Width,
                    LabelRecentStatusUpdateDateTime.Height);
                LabelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(
                    LabelRecentStatusUpdateDateTime.Width,
                    25);
                LabelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(
                    LabelRecentStatusUpdateDateTime.Width,
                    30);
                ///// TopPost Panel
                //// PictureBoxTopPost
                PictureBoxTopPost.Location = new System.Drawing.Point(
                    PictureBoxTopPost.Location.X,
                    LabelTopPostLikes.Top);
                //// LabelTopPostComments
                LabelTopPostComments.Location = new System.Drawing.Point(
                    LabelTopPostLikes.Location.X,
                    LabelTopPostLikes.Bottom);
                LabelTopPostComments.Size = new System.Drawing.Size(
                    LabelTopPostLikes.Width,
                    LabelTopPostLikes.Height);
                //// LabelTopPostCaptionTitle
                LabelTopPostCaptionTitle.Location = new System.Drawing.Point(
                    LabelTopPostComments.Location.X,
                    LabelTopPostComments.Bottom);
                LabelTopPostCaptionTitle.Size = new System.Drawing.Size(
                    LabelTopPostComments.Width,
                    LabelTopPostCaptionTitle.Height);
                //// LabelTopPostCaptionContent
                LabelTopPostCaptionContent.Location = new System.Drawing.Point(
                    LabelTopPostCaptionTitle.Location.X,
                    LabelTopPostCaptionTitle.Bottom);
                LabelTopPostCaptionContent.Size = new System.Drawing.Size(
                    LabelTopPostCaptionTitle.Width,
                    LabelTopPostCaptionContent.Height);
                LabelTopPostCaptionContent.AutoSize = true;
                LabelTopPostCaptionContent.MinimumSize =
                    new System.Drawing.Size(LabelTopPostCaptionContent.Width, 0);
                LabelTopPostCaptionContent.MaximumSize =
                    new System.Drawing.Size(LabelTopPostCaptionContent.Width, 171);
                //// LabelTopPostCaptionDateTime
                LabelTopPostCaptionDateTime.Location = new System.Drawing.Point(
                    LabelTopPostCaptionContent.Location.X,
                    LabelTopPostCaptionContent.Bottom);
                LabelTopPostCaptionDateTime.Size = new System.Drawing.Size(
                    LabelTopPostCaptionContent.Width,
                    LabelTopPostCaptionDateTime.Height);
                LabelTopPostCaptionDateTime.MinimumSize =
                    new System.Drawing.Size(LabelTopPostCaptionDateTime.Width, 25);
                LabelTopPostCaptionDateTime.MaximumSize =
                    new System.Drawing.Size(LabelTopPostCaptionDateTime.Width, 30);
            }));
        }

        public void SetupFetchAndDisplay()
        {
            Invoke(
                new Action(
                    () =>
                        {
                            SetupAndFetch();
                            DisplayData();
                            UpdateDashboardUI();
                        }));
        }

        public void SetupAndFetch()
        {
            m_DashboardViewModel.FriendCountSetup();
            m_DashboardViewModel.EngagementArraySetup();
            m_DashboardViewModel.FetchData();
            ChartSetup();
        }

        public void DisplayData()
        {
            const string k_Quotes = "\"";

            try
            {
                displayUserBioData(k_Quotes);
                displayFriendChange();
                displayTopPost(k_Quotes);
                LabelEngagement.Text = $@"Engagement (Last {BoostEngine.k_NumOfPostsForEngagement} posts)";
            }
            catch (NullReferenceException)
            {
                DisplayDashboardErrorMessage();
            }
        }

        private void displayUserBioData(string i_Quotes)
        {
            LabelName.Text = m_DashboardViewModel.UserRealName;
            PictureBoxBioProfilePic.LoadAsync(m_DashboardViewModel.PictureLargeURL);
            PictureBoxBioProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
            LabelBio1.Text = $@"Location: {m_DashboardViewModel.UserLocation}";
            LabelBio2.Text = $@"Friends using Boost: {m_DashboardViewModel.FriendsUsingBoost}";
            LabelBio3.Text = $@"Verified?: {(m_DashboardViewModel.Verified == true ? "Yes" : "No")}";

            // Recent Status Update
            LabelRecentStatusUpdateContent.Text = $@"{i_Quotes}{m_DashboardViewModel.LastStatus.Message}{i_Quotes}";
            LabelRecentStatusUpdateDateTime.Text = $@"- {m_DashboardViewModel.LastStatus.CreatedTime.ToString()}";
        }

        private void displayFriendChange()
        {
            try
            {
                if (m_DashboardViewModel.FriendChange != 0)
                {
                    LabelFriendsChange.Visible = true;
                    if (m_DashboardViewModel.FriendChange > 0)
                    {
                        LabelFriendsChange.Text = "+" + m_DashboardViewModel.FriendChange.ToString();
                        LabelFriendsChange.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        LabelFriendsChange.Text = m_DashboardViewModel.FriendChange.ToString();
                        LabelFriendsChange.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
            catch (Exception)
            {
                LabelError.Text = @"Could not fetch data from boostSettings.xml";
            }
        }

        private void displayTopPost(string i_Quotes)
        {
            try
            {
                LabelTopPostLikes.Text = $@"Likes: {m_DashboardViewModel.TopPost.LikedBy.Count}";
                LabelTopPostComments.Text = $@"Comments: {m_DashboardViewModel.TopPost.Comments.Count}";
                if (string.IsNullOrEmpty(m_DashboardViewModel.TopPost.Message))
                {
                    LabelTopPostCaptionTitle.Visible = false;
                    LabelTopPostCaptionContent.Visible = false;
                }
                else
                {
                    LabelTopPostCaptionContent.Text =
                        $@"{i_Quotes}{m_DashboardViewModel.TopPost.Message}{i_Quotes}";
                }

                LabelTopPostCaptionDateTime.Text = $@"- {m_DashboardViewModel.TopPost.CreatedTime.ToString()}";
                PictureBoxTopPost.Image = null;
                if (!string.IsNullOrWhiteSpace(m_DashboardViewModel.TopPost.PictureURL))
                {
                    PictureBoxTopPost.LoadAsync(m_DashboardViewModel.TopPost.PictureURL);
                }
            }
            catch (NullReferenceException)
            {
                LabelTopPostError.Text = m_DashboardViewModel.R_PostErrorMessage;
                LabelTopPostError.Visible = true;
                LabelTopPostLikes.Visible = false;
                LabelTopPostComments.Visible = false;
                LabelTopPostCaptionDateTime.Visible = false;
                PictureBoxTopPost.Visible = false;
            }
        }

        public void ChartSetup()
        {
            foreach (DateAndValue friendCounter in m_DashboardViewModel.FriendCounter)
            {
                ChartFriends.Series[0].Points.AddXY(
                    friendCounter.Date.Date.ToString("d/M/yy"),
                    friendCounter.Value);
            }

            ChartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;

            // Engagement Chart
            for (int i = 0; i < BoostEngine.k_NumOfPostsForEngagement; i++)
            {
                DateAndValue currentLikes = m_DashboardViewModel.EngagementRecentPostLikes[i];
                DateAndValue currentComments = m_DashboardViewModel.EngagementRecentPostComments[i];

                ChartEngagement.Series["Likes"].Points.AddXY(
                    currentLikes.Date.ToString(),
                    currentLikes.Value);
                ChartEngagement.Series["Comments"].Points.AddXY(
                    currentComments.Date.ToString(),
                    currentComments.Value);
            }
        }
        }
        #endregion
}
