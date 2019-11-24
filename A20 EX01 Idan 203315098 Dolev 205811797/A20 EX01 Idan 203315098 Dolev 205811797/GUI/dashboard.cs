using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Dashboard : UserControl
    {

        public List<Engagement> m_EngagementList;
        private readonly int k_EngagementChartCount = 5;

        public Dashboard()
        {
            m_EngagementList = new List<Engagement>();
            InitializeComponent();
            //this.chart1.Series["Engagement"].Points.AddXY("18/10/18", 30);
            //this.chart1.Series["Engagement"].Points.AddXY("31/12/18", 20);
            //this.chart1.Series["Engagement"].Points.AddXY("06/04/19", 50);
            //this.chart1.Series["Engagement"].Points.AddXY("22/5/19", 200);
            //this.chart1.Series["Engagement"].Points.AddXY("01/07/19", 45);
            //this.chart1.Series["Engagement"].Points.AddXY("18/10/19", 100);
        }

        public void EngagementChartSeup()
        {
            this.chart1.Series["Engagement"].Points.Clear();
            for (int i = 0 ; i < k_EngagementChartCount ; i++)
            {
                int index = k_EngagementChartCount - i -1;
                this.chart1.Series["Engagement"].Points.AddXY(m_EngagementList[index].TimePosted.Date, m_EngagementList[index].LikeCount);
            }
        }

        public void DashboardUpdate()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            //Dynamic Label Positions
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
            //labelLastPostTltle
            this.labelLastPostTitle.Location = new System.Drawing.Point(this.labelBio3.Location.X, this.labelBio3.Bottom);
            this.labelLastPostTitle.Size = new System.Drawing.Size(this.labelBio3.Width, this.labelLastPostTitle.Height);
            //labelLastPostContent
            this.labelLastPostContent.Location = new System.Drawing.Point(this.labelLastPostTitle.Location.X, this.labelLastPostTitle.Bottom);
            this.labelLastPostContent.Size = new System.Drawing.Size(this.labelLastPostTitle.Width, this.labelLastPostContent.Height);
            this.labelLastPostContent.AutoSize = true;
            this.labelLastPostContent.MinimumSize = new System.Drawing.Size(this.labelLastPostContent.Width, 0);
            this.labelLastPostContent.MaximumSize = new System.Drawing.Size(this.labelLastPostContent.Width, 171);
            //labelLastPostDateTime
            this.labelLastPostDateTime.Location = new System.Drawing.Point(this.labelLastPostContent.Location.X, this.labelLastPostContent.Bottom);
            this.labelLastPostDateTime.Size = new System.Drawing.Size(this.labelLastPostContent.Width, this.labelLastPostDateTime.Height);
            this.labelLastPostDateTime.MinimumSize = new System.Drawing.Size(this.labelLastPostDateTime.Width, 25);
            this.labelLastPostDateTime.MaximumSize = new System.Drawing.Size(this.labelLastPostDateTime.Width, 30);

        }
    }
}
