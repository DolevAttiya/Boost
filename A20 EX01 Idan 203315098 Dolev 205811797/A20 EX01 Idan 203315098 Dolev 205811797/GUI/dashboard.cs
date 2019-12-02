using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Dashboard : UserControl
    {

        public List<Engagement> EngagementList { get; set; }

        public Dashboard()
        {
            EngagementList = new List<Engagement>();
            InitializeComponent();
            dashboardInitalSetup();
        }

        private void dashboardInitalSetup()
        {
            //Enforcing visual styles (in case of designer auto change)
            this.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = Stylesheet.font_Header1;
            this.labelBio1.Font = Stylesheet.font_Header3;
            this.labelBio2.Font = Stylesheet.font_Header3;
            this.labelBio3.Font = Stylesheet.font_Header3;
            this.labelRecentStatusUpdateTitle.Font = Stylesheet.font_Header2Underline;
            this.labelRecentStatusUpdateContent.Font = Stylesheet.font_BodyItalics;
            this.labelRecentStatusUpdateDateTime.Font = Stylesheet.font_Body;
            this.labelEngagement.Font = Stylesheet.font_Header2;
            this.labelFriends.Font = Stylesheet.font_Header2;
            this.labelTopPost.Font = Stylesheet.font_Header2;
            this.labelTopPostLikes.Font = Stylesheet.font_Header3;
            this.labelTopPostComments.Font = Stylesheet.font_Header3;
            this.labelTopPostCaptionTitle.Font = Stylesheet.font_Header2Underline;
            this.labelTopPostCaptionContent.Font = Stylesheet.font_BodyItalics;
            this.labelTopPostCaptionDateTime.Font = Stylesheet.font_Body;
        }

        public void DisplayDashboardErrorMessage()
        {
            this.panelEngagement.Visible = false;
            this.panelUserBio.Visible = false;
            this.panelFriends.Visible = false;
            this.panelTopPost.Visible = false;
            this.labelError.Visible = true;
        }

        public void UpdateDashboardUI()
        {
            ////Dynamic Label Positions
            ///BioPanel
            //labelName
            this.labelName.Location = new System.Drawing.Point(
                this.pictureBoxBioProfilePic.Location.X,
                this.pictureBoxBioProfilePic.Bottom);
            this.labelName.MinimumSize = new System.Drawing.Size(this.pictureBoxBioProfilePic.Width, 0);
            //labelBio1
            this.labelBio1.Location = new System.Drawing.Point(this.labelName.Location.X, this.labelName.Bottom);
            this.labelBio1.Size = new System.Drawing.Size(this.labelName.Width, 22);
            //labelBio2
            this.labelBio2.Location = new System.Drawing.Point(this.labelBio1.Location.X, this.labelBio1.Bottom);
            this.labelBio2.Size = new System.Drawing.Size(this.labelBio1.Width, this.labelBio1.Height);
            this.labelBio2.Padding = this.labelBio1.Padding;
            this.labelBio2.Margin = this.labelBio1.Margin;
            //labelBio3
            this.labelBio3.Location = new System.Drawing.Point(this.labelBio2.Location.X, this.labelBio2.Bottom);
            this.labelBio3.Size = new System.Drawing.Size(this.labelBio2.Width, this.labelBio2.Height);
            this.labelBio3.Padding = this.labelBio2.Padding;
            this.labelBio3.Margin = this.labelBio2.Margin;
            //labelRecentStatusUpdateTltle
            this.labelRecentStatusUpdateTitle.Location = new System.Drawing.Point(
                this.labelBio3.Location.X,
                this.labelBio3.Bottom);
            this.labelRecentStatusUpdateTitle.Size = new System.Drawing.Size(
                this.labelBio3.Width,
                this.labelRecentStatusUpdateTitle.Height);
            //labelRecentStatusUpdateContent
            this.labelRecentStatusUpdateContent.Location = new System.Drawing.Point(
                this.labelRecentStatusUpdateTitle.Location.X,
                this.labelRecentStatusUpdateTitle.Bottom);
            this.labelRecentStatusUpdateContent.Size = new System.Drawing.Size(
                this.labelRecentStatusUpdateTitle.Width,
                this.labelRecentStatusUpdateContent.Height);
            this.labelRecentStatusUpdateContent.AutoSize = true;
            this.labelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(
                this.labelRecentStatusUpdateContent.Width,
                0);
            this.labelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(
                this.labelRecentStatusUpdateContent.Width,
                171);
            //labelRecentStatusUpdateDateTime
            this.labelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(
                this.labelRecentStatusUpdateContent.Location.X,
                this.labelRecentStatusUpdateContent.Bottom);
            this.labelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(
                this.labelRecentStatusUpdateContent.Width,
                this.labelRecentStatusUpdateDateTime.Height);
            this.labelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(
                this.labelRecentStatusUpdateDateTime.Width,
                25);
            this.labelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(
                this.labelRecentStatusUpdateDateTime.Width,
                30);
            ///TopPost Panel
            //pictureBoxTopPost
            this.pictureBoxTopPost.Location = new System.Drawing.Point(
                this.pictureBoxTopPost.Location.X,
                this.labelTopPostLikes.Top);
            //labelTopPostComments
            this.labelTopPostComments.Location = new System.Drawing.Point(
                this.labelTopPostLikes.Location.X,
                this.labelTopPostLikes.Bottom);
            this.labelTopPostComments.Size = new System.Drawing.Size(
                this.labelTopPostLikes.Width,
                this.labelTopPostLikes.Height);
            //labelTopPostCaptionTitle
            this.labelTopPostCaptionTitle.Location = new System.Drawing.Point(
                this.labelTopPostComments.Location.X,
                this.labelTopPostComments.Bottom);
            this.labelTopPostCaptionTitle.Size = new System.Drawing.Size(
                this.labelTopPostComments.Width,
                this.labelTopPostCaptionTitle.Height);
            //labelTopPostCaptionContent
            this.labelTopPostCaptionContent.Location = new System.Drawing.Point(
                this.labelTopPostCaptionTitle.Location.X,
                this.labelTopPostCaptionTitle.Bottom);
            this.labelTopPostCaptionContent.Size = new System.Drawing.Size(
                this.labelTopPostCaptionTitle.Width,
                this.labelTopPostCaptionContent.Height);
            this.labelTopPostCaptionContent.AutoSize = true;
            this.labelTopPostCaptionContent.MinimumSize =
                new System.Drawing.Size(this.labelTopPostCaptionContent.Width, 0);
            this.labelTopPostCaptionContent.MaximumSize =
                new System.Drawing.Size(this.labelTopPostCaptionContent.Width, 171);
            //labelTopPostCaptionDateTime
            this.labelTopPostCaptionDateTime.Location = new System.Drawing.Point(
                this.labelTopPostCaptionContent.Location.X,
                this.labelTopPostCaptionContent.Bottom);
            this.labelTopPostCaptionDateTime.Size = new System.Drawing.Size(
                this.labelTopPostCaptionContent.Width,
                this.labelTopPostCaptionDateTime.Height);
            this.labelTopPostCaptionDateTime.MinimumSize =
                new System.Drawing.Size(this.labelTopPostCaptionDateTime.Width, 25);
            this.labelTopPostCaptionDateTime.MaximumSize =
                new System.Drawing.Size(this.labelTopPostCaptionDateTime.Width, 30);
        }
    }
}
