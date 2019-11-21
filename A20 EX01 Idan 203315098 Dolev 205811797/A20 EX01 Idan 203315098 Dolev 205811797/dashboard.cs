using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            dashboardSetup();
        }

        private void dashboardSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            //Dynamic Label Positions
            //labelName
            this.labelName.Location = new System.Drawing.Point(this.pictureBoxBioProfilePic.Location.X, this.pictureBoxBioProfilePic.Bottom);
            this.labelName.MinimumSize = new System.Drawing.Size(this.pictureBoxBioProfilePic.Width, 0);
            //labelBio1
            this.labelBio1.Location = new System.Drawing.Point(this.labelName.Location.X, this.labelName.Bottom);
            this.labelBio1.Size = new System.Drawing.Size(this.labelName.Width, 28);
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
            //labelLastPost
            this.labelLastPostTitle.Location = new System.Drawing.Point(this.labelBio3.Location.X, this.labelBio3.Bottom);
            this.labelLastPostTitle.Size = new System.Drawing.Size(this.labelBio3.Width, this.labelLastPostTitle.Height);



        }

    }
}
