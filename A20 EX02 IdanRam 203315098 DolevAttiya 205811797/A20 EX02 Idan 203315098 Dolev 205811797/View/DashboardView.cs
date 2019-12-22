using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class DashboardView : UserControl
    {
        #region Data Members & Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Engagement> m_EngagementList;

        public List<StylizedPanel> m_DashboardPanelList = new List<StylizedPanel>();
        #endregion

        #region Ctor
        public DashboardView()
        {
            m_EngagementList = new List<Engagement>();
            InitializeComponent();
            dashboardInitalSetup();
        }
        #endregion

        #region Methods
        private void dashboardInitalSetup()
        {
            //// Add panels to list
            m_DashboardPanelList.Add(this.panelEngagement);
            m_DashboardPanelList.Add(this.panelFriends);
            m_DashboardPanelList.Add(this.panelTopPost);
            m_DashboardPanelList.Add(this.panelUserBio);

            foreach (StylizedPanel panel in m_DashboardPanelList)
            {
                panel.GradientColorA = Stylesheet.Color_PanelColorA;
                panel.GradientColorB = Stylesheet.Color_PanelColorB;
                panel.GradientAngle = 90F;
            }

            //// Enforcing visual styles (in case of designer auto change)
            this.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = Stylesheet.Font_Header1;
            this.LabelBio1.Font = Stylesheet.Font_Header3;
            this.LabelBio2.Font = Stylesheet.Font_Header3;
            this.LabelBio3.Font = Stylesheet.Font_Header3;
            this.LabelRecentStatusUpdateTitle.Font = Stylesheet.Font_Header2Underline;
            this.LabelRecentStatusUpdateContent.Font = Stylesheet.Font_BodyItalics;
            this.LabelRecentStatusUpdateDateTime.Font = Stylesheet.Font_Body;
            this.LabelEngagement.Font = Stylesheet.Font_Header2;
            this.LabelFriends.Font = Stylesheet.Font_Header2;
            this.LabelTopPost.Font = Stylesheet.Font_Header2;
            this.LabelTopPostLikes.Font = Stylesheet.Font_Header3;
            this.LabelTopPostComments.Font = Stylesheet.Font_Header3;
            this.LabelTopPostCaptionTitle.Font = Stylesheet.Font_Header2Underline;
            this.LabelTopPostCaptionContent.Font = Stylesheet.Font_BodyItalics;
            this.LabelTopPostCaptionDateTime.Font = Stylesheet.Font_Body;
        }

        public void DisplayDashboardErrorMessage()
        {
            this.panelEngagement.Visible = false;
            this.panelUserBio.Visible = false;
            this.panelFriends.Visible = false;
            this.panelTopPost.Visible = false;
            this.LabelError.Visible = true;
            this.LabelError.BringToFront();
        }

        public void UpdateDashboardUI()
        {
            this.Invoke(new Action(() =>
            {
                //// Dynamic Label Positions
                //// BioPanel
                //// LabelName
                this.LabelName.Location = new System.Drawing.Point(
                    this.PictureBoxBioProfilePic.Location.X,
                    this.PictureBoxBioProfilePic.Bottom);
                this.LabelName.MinimumSize = new System.Drawing.Size(this.PictureBoxBioProfilePic.Width, 0);
                //// LabelBio1
                this.LabelBio1.Location = new System.Drawing.Point(this.LabelName.Location.X, this.LabelName.Bottom);
                this.LabelBio1.Size = new System.Drawing.Size(this.LabelName.Width, 22);
                //// LabelBio2
                this.LabelBio2.Location = new System.Drawing.Point(this.LabelBio1.Location.X, this.LabelBio1.Bottom);
                this.LabelBio2.Size = new System.Drawing.Size(this.LabelBio1.Width, this.LabelBio1.Height);
                this.LabelBio2.Padding = this.LabelBio1.Padding;
                this.LabelBio2.Margin = this.LabelBio1.Margin;
                //// LabelBio3
                this.LabelBio3.Location = new System.Drawing.Point(this.LabelBio2.Location.X, this.LabelBio2.Bottom);
                this.LabelBio3.Size = new System.Drawing.Size(this.LabelBio2.Width, this.LabelBio2.Height);
                this.LabelBio3.Padding = this.LabelBio2.Padding;
                this.LabelBio3.Margin = this.LabelBio2.Margin;
                //// LabelRecentStatusUpdateTltle
                this.LabelRecentStatusUpdateTitle.Location = new System.Drawing.Point(
                    this.LabelBio3.Location.X,
                    this.LabelBio3.Bottom);
                this.LabelRecentStatusUpdateTitle.Size = new System.Drawing.Size(
                    this.LabelBio3.Width,
                    this.LabelRecentStatusUpdateTitle.Height);
                //// LabelRecentStatusUpdateContent
                this.LabelRecentStatusUpdateContent.Location = new System.Drawing.Point(
                    this.LabelRecentStatusUpdateTitle.Location.X,
                    this.LabelRecentStatusUpdateTitle.Bottom);
                this.LabelRecentStatusUpdateContent.Size = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateTitle.Width,
                    this.LabelRecentStatusUpdateContent.Height);
                this.LabelRecentStatusUpdateContent.AutoSize = true;
                this.LabelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateContent.Width,
                    0);
                this.LabelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateContent.Width,
                    171);
                //// LabelRecentStatusUpdateDateTime
                this.LabelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(
                    this.LabelRecentStatusUpdateContent.Location.X,
                    this.LabelRecentStatusUpdateContent.Bottom);
                this.LabelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateContent.Width,
                    this.LabelRecentStatusUpdateDateTime.Height);
                this.LabelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateDateTime.Width,
                    25);
                this.LabelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(
                    this.LabelRecentStatusUpdateDateTime.Width,
                    30);
                ///// TopPost Panel
                //// PictureBoxTopPost
                this.PictureBoxTopPost.Location = new System.Drawing.Point(
                    this.PictureBoxTopPost.Location.X,
                    this.LabelTopPostLikes.Top);
                //// LabelTopPostComments
                this.LabelTopPostComments.Location = new System.Drawing.Point(
                    this.LabelTopPostLikes.Location.X,
                    this.LabelTopPostLikes.Bottom);
                this.LabelTopPostComments.Size = new System.Drawing.Size(
                    this.LabelTopPostLikes.Width,
                    this.LabelTopPostLikes.Height);
                //// LabelTopPostCaptionTitle
                this.LabelTopPostCaptionTitle.Location = new System.Drawing.Point(
                    this.LabelTopPostComments.Location.X,
                    this.LabelTopPostComments.Bottom);
                this.LabelTopPostCaptionTitle.Size = new System.Drawing.Size(
                    this.LabelTopPostComments.Width,
                    this.LabelTopPostCaptionTitle.Height);
                //// LabelTopPostCaptionContent
                this.LabelTopPostCaptionContent.Location = new System.Drawing.Point(
                    this.LabelTopPostCaptionTitle.Location.X,
                    this.LabelTopPostCaptionTitle.Bottom);
                this.LabelTopPostCaptionContent.Size = new System.Drawing.Size(
                    this.LabelTopPostCaptionTitle.Width,
                    this.LabelTopPostCaptionContent.Height);
                this.LabelTopPostCaptionContent.AutoSize = true;
                this.LabelTopPostCaptionContent.MinimumSize =
                    new System.Drawing.Size(this.LabelTopPostCaptionContent.Width, 0);
                this.LabelTopPostCaptionContent.MaximumSize =
                    new System.Drawing.Size(this.LabelTopPostCaptionContent.Width, 171);
                //// LabelTopPostCaptionDateTime
                this.LabelTopPostCaptionDateTime.Location = new System.Drawing.Point(
                    this.LabelTopPostCaptionContent.Location.X,
                    this.LabelTopPostCaptionContent.Bottom);
                this.LabelTopPostCaptionDateTime.Size = new System.Drawing.Size(
                    this.LabelTopPostCaptionContent.Width,
                    this.LabelTopPostCaptionDateTime.Height);
                this.LabelTopPostCaptionDateTime.MinimumSize =
                    new System.Drawing.Size(this.LabelTopPostCaptionDateTime.Width, 25);
                this.LabelTopPostCaptionDateTime.MaximumSize =
                    new System.Drawing.Size(this.LabelTopPostCaptionDateTime.Width, 30);
            }));
        }
        #endregion
    }
}
