using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Dashboard : UserControl
    {

        public List<Engagement> m_EngagementList;

        public Dashboard()
        {
            m_EngagementList = new List<Engagement>();
            InitializeComponent();
            //Dummy values
            //TODO create a method that gets the most recent 5 dates and collects and calculates photos, videos & status
            this.chart1.Series["Photos"].Points.AddXY("31/12/18", 20);
            this.chart1.Series["Photos"].Points.AddXY("06/04/19", 50);
            this.chart1.Series["Photos"].Points.AddXY("22/5/19", 200);
            this.chart1.Series["Photos"].Points.AddXY("01/07/19", 45);
            this.chart1.Series["Photos"].Points.AddXY("18/10/19", 100);
            this.chart1.Series["Videos"].Points.AddXY("22/5/19", 150);
            this.chart1.Series["Videos"].Points.AddXY("01/07/19", 70);
            this.chart1.Series["Videos"].Points.AddXY("18/10/19", 10);
            this.chart1.Series["Status"].Points.AddXY("31/12/18", 300);
            this.chart1.Series["Status"].Points.AddXY("06/04/19", 50);
            this.chart1.Series["Status"].Points.AddXY("22/5/19", 35);
            this.chart1.Series["Status"].Points.AddXY("01/07/19", 22);
            this.chart1.Series["Status"].Points.AddXY("18/10/19", 66);
            this.chart1.AlignDataPointsByAxisLabel();
            //Friend chart dummy values
            this.chartFriends.Series["Friends"].Points.AddXY("10/10/19", 350);
            this.chartFriends.Series["Friends"].Points.AddXY("15/10/19", 340);
            this.chartFriends.Series["Friends"].Points.AddXY("10/11/19", 360);
            this.chartFriends.ChartAreas[0].AxisY.Minimum = (this.chartFriends.Series[0].Points[0].YValues[0]) - 200 > 0 ? (this.chartFriends.Series[0].Points[0].YValues[0]) - 200 : 0;
            this.chartFriends.ChartAreas[0].AxisY.Maximum = (this.chartFriends.Series[0].Points[(this.chartFriends.Series[0].Points.Count)-1].YValues[0]) + 200;
            this.chartFriends.ChartAreas[0].AxisX.IsMarginVisible = false;
            this.chartFriends.AlignDataPointsByAxisLabel();

        }

        //public void ChartSetup()
        //{
        //    this.chart1.Series["Engagement"].Points.Clear();
        //    for (int i = 0 ; i < k_EngagementChartCount ; i++)
        //    {
        //        int index = k_EngagementChartCount - i -1;
        //        this.chart1.Series["Engagement"].Points.AddXY(m_EngagementList[index].TimePosted.Date, m_EngagementList[index].LikeCount);
        //    }
        //}

        public void DashboardUpdate()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            ////Dynamic Label Positions
            ///BioPanel
            //labelName
            this.labelName.Location = new System.Drawing.Point(this.pictureBoxBioProfilePic.Location.X, this.pictureBoxBioProfilePic.Bottom);
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
            this.labelRecentStatusUpdateTitle.Location = new System.Drawing.Point(this.labelBio3.Location.X, this.labelBio3.Bottom);
            this.labelRecentStatusUpdateTitle.Size = new System.Drawing.Size(this.labelBio3.Width, this.labelRecentStatusUpdateTitle.Height);
            //labelRecentStatusUpdateContent
            this.labelRecentStatusUpdateContent.Location = new System.Drawing.Point(this.labelRecentStatusUpdateTitle.Location.X, this.labelRecentStatusUpdateTitle.Bottom);
            this.labelRecentStatusUpdateContent.Size = new System.Drawing.Size(this.labelRecentStatusUpdateTitle.Width, this.labelRecentStatusUpdateContent.Height);
            this.labelRecentStatusUpdateContent.AutoSize = true;
            this.labelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(this.labelRecentStatusUpdateContent.Width, 0);
            this.labelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(this.labelRecentStatusUpdateContent.Width, 171);
            //labelRecentStatusUpdateDateTime
            this.labelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(this.labelRecentStatusUpdateContent.Location.X, this.labelRecentStatusUpdateContent.Bottom);
            this.labelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(this.labelRecentStatusUpdateContent.Width, this.labelRecentStatusUpdateDateTime.Height);
            this.labelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(this.labelRecentStatusUpdateDateTime.Width, 25);
            this.labelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(this.labelRecentStatusUpdateDateTime.Width, 30);
            ///TopPost Panel
            //pictureBoxTopPost
            this.pictureBoxTopPost.Location = new System.Drawing.Point(this.pictureBoxTopPost.Location.X, this.labelTopPostLikes.Top);
            //labelTopPostComments
            this.labelTopPostComments.Location = new System.Drawing.Point(this.labelTopPostLikes.Location.X, this.labelTopPostLikes.Bottom);
            this.labelTopPostComments.Size = new System.Drawing.Size(this.labelTopPostLikes.Width, this.labelTopPostLikes.Height);
            //labelTopPostCaptionTitle
            this.labelTopPostCaptionTitle.Location = new System.Drawing.Point(this.labelTopPostComments.Location.X, this.labelTopPostComments.Bottom);
            this.labelTopPostCaptionTitle.Size = new System.Drawing.Size(this.labelTopPostComments.Width, this.labelTopPostCaptionTitle.Height);
            //labelTopPostCaptionContent
            this.labelTopPostCaptionContent.Location = new System.Drawing.Point(this.labelTopPostCaptionTitle.Location.X, this.labelTopPostCaptionTitle.Bottom);
            this.labelTopPostCaptionContent.Size = new System.Drawing.Size(this.labelTopPostCaptionTitle.Width, this.labelTopPostCaptionContent.Height);
            this.labelTopPostCaptionContent.AutoSize = true;
            this.labelTopPostCaptionContent.MinimumSize = new System.Drawing.Size(this.labelTopPostCaptionContent.Width, 0);
            this.labelTopPostCaptionContent.MaximumSize = new System.Drawing.Size(this.labelTopPostCaptionContent.Width, 171);
            //labelTopPostCaptionDateTime
            this.labelTopPostCaptionDateTime.Location = new System.Drawing.Point(this.labelTopPostCaptionContent.Location.X, this.labelTopPostCaptionContent.Bottom);
            this.labelTopPostCaptionDateTime.Size = new System.Drawing.Size(this.labelTopPostCaptionContent.Width, this.labelTopPostCaptionDateTime.Height);
            this.labelTopPostCaptionDateTime.MinimumSize = new System.Drawing.Size(this.labelTopPostCaptionDateTime.Width, 25);
            this.labelTopPostCaptionDateTime.MaximumSize = new System.Drawing.Size(this.labelTopPostCaptionDateTime.Width, 30);

        }
    }
}
