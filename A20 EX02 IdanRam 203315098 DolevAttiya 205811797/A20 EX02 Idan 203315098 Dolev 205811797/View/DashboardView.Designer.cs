using System.Drawing;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelError = new System.Windows.Forms.Label();
            this.panelTopPost = new A20_EX02_Idan_203315098_Dolev_205811797.View.StylizedPanel();
            this.LabelTopPostError = new System.Windows.Forms.Label();
            this.PictureBoxTopPost = new System.Windows.Forms.PictureBox();
            this.LabelTopPostCaptionDateTime = new System.Windows.Forms.Label();
            this.LabelTopPostCaptionContent = new System.Windows.Forms.Label();
            this.LabelTopPostCaptionTitle = new System.Windows.Forms.Label();
            this.LabelTopPostComments = new System.Windows.Forms.Label();
            this.LabelTopPostLikes = new System.Windows.Forms.Label();
            this.LabelTopPost = new System.Windows.Forms.Label();
            this.panelFriends = new A20_EX02_Idan_203315098_Dolev_205811797.View.StylizedPanel();
            this.LabelFriendsChange = new System.Windows.Forms.Label();
            this.ChartFriends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelFriends = new System.Windows.Forms.Label();
            this.panelEngagement = new A20_EX02_Idan_203315098_Dolev_205811797.View.StylizedPanel();
            this.ChartEngagement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelEngagement = new System.Windows.Forms.Label();
            this.panelUserBio = new A20_EX02_Idan_203315098_Dolev_205811797.View.StylizedPanel();
            this.LabelRecentStatusUpdateDateTime = new System.Windows.Forms.Label();
            this.LabelRecentStatusUpdateContent = new System.Windows.Forms.Label();
            this.LabelRecentStatusUpdateTitle = new System.Windows.Forms.Label();
            this.LabelBio3 = new System.Windows.Forms.Label();
            this.LabelBio2 = new System.Windows.Forms.Label();
            this.LabelBio1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBoxBioProfilePic = new System.Windows.Forms.PictureBox();
            this.panelTopPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopPost)).BeginInit();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFriends)).BeginInit();
            this.panelEngagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEngagement)).BeginInit();
            this.panelUserBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBioProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelError
            // 
            this.LabelError.BackColor = System.Drawing.Color.Transparent;
            this.LabelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelError.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(0, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.LabelError.Size = new System.Drawing.Size(1021, 523);
            this.LabelError.TabIndex = 13;
            this.LabelError.Text = "Could not fetch user data!";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelError.Visible = false;
            // 
            // panelTopPost
            // 
            this.panelTopPost.AutoScroll = true;
            this.panelTopPost.BackColor = System.Drawing.Color.White;
            this.panelTopPost.Controls.Add(this.LabelTopPostError);
            this.panelTopPost.Controls.Add(this.PictureBoxTopPost);
            this.panelTopPost.Controls.Add(this.LabelTopPostCaptionDateTime);
            this.panelTopPost.Controls.Add(this.LabelTopPostCaptionContent);
            this.panelTopPost.Controls.Add(this.LabelTopPostCaptionTitle);
            this.panelTopPost.Controls.Add(this.LabelTopPostComments);
            this.panelTopPost.Controls.Add(this.LabelTopPostLikes);
            this.panelTopPost.Controls.Add(this.LabelTopPost);
            this.panelTopPost.GradientAngle = 90F;
            this.panelTopPost.GradientColorA = System.Drawing.Color.White;
            this.panelTopPost.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelTopPost.Location = new System.Drawing.Point(272, 257);
            this.panelTopPost.Name = "panelTopPost";
            this.panelTopPost.Size = new System.Drawing.Size(363, 266);
            this.panelTopPost.TabIndex = 3;
            // 
            // LabelTopPostError
            // 
            this.LabelTopPostError.AutoSize = true;
            this.LabelTopPostError.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostError.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelTopPostError.Location = new System.Drawing.Point(11, 45);
            this.LabelTopPostError.MaximumSize = new System.Drawing.Size(230, 230);
            this.LabelTopPostError.Name = "LabelTopPostError";
            this.LabelTopPostError.Size = new System.Drawing.Size(89, 28);
            this.LabelTopPostError.TabIndex = 12;
            this.LabelTopPostError.Text = "Label1";
            this.LabelTopPostError.Visible = false;
            // 
            // PictureBoxTopPost
            // 
            this.PictureBoxTopPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxTopPost.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTopPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxTopPost.Location = new System.Drawing.Point(181, 49);
            this.PictureBoxTopPost.Name = "PictureBoxTopPost";
            this.PictureBoxTopPost.Size = new System.Drawing.Size(168, 97);
            this.PictureBoxTopPost.TabIndex = 11;
            this.PictureBoxTopPost.TabStop = false;
            // 
            // LabelTopPostCaptionDateTime
            // 
            this.LabelTopPostCaptionDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPostCaptionDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostCaptionDateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostCaptionDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPostCaptionDateTime.Location = new System.Drawing.Point(8, 235);
            this.LabelTopPostCaptionDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTopPostCaptionDateTime.MaximumSize = new System.Drawing.Size(200, 30);
            this.LabelTopPostCaptionDateTime.MinimumSize = new System.Drawing.Size(200, 23);
            this.LabelTopPostCaptionDateTime.Name = "LabelTopPostCaptionDateTime";
            this.LabelTopPostCaptionDateTime.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LabelTopPostCaptionDateTime.Size = new System.Drawing.Size(200, 25);
            this.LabelTopPostCaptionDateTime.TabIndex = 10;
            this.LabelTopPostCaptionDateTime.Text = "- Date Time";
            // 
            // LabelTopPostCaptionContent
            // 
            this.LabelTopPostCaptionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPostCaptionContent.AutoSize = true;
            this.LabelTopPostCaptionContent.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostCaptionContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostCaptionContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPostCaptionContent.Location = new System.Drawing.Point(10, 173);
            this.LabelTopPostCaptionContent.MaximumSize = new System.Drawing.Size(200, 89);
            this.LabelTopPostCaptionContent.MinimumSize = new System.Drawing.Size(200, 2);
            this.LabelTopPostCaptionContent.Name = "LabelTopPostCaptionContent";
            this.LabelTopPostCaptionContent.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelTopPostCaptionContent.Size = new System.Drawing.Size(200, 22);
            this.LabelTopPostCaptionContent.TabIndex = 9;
            this.LabelTopPostCaptionContent.Text = "Bla bla bla bla bla.";
            // 
            // LabelTopPostCaptionTitle
            // 
            this.LabelTopPostCaptionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPostCaptionTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostCaptionTitle.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostCaptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPostCaptionTitle.Location = new System.Drawing.Point(11, 132);
            this.LabelTopPostCaptionTitle.Name = "LabelTopPostCaptionTitle";
            this.LabelTopPostCaptionTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.LabelTopPostCaptionTitle.Size = new System.Drawing.Size(164, 41);
            this.LabelTopPostCaptionTitle.TabIndex = 8;
            this.LabelTopPostCaptionTitle.Text = "Caption";
            this.LabelTopPostCaptionTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelTopPostComments
            // 
            this.LabelTopPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPostComments.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostComments.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPostComments.Location = new System.Drawing.Point(9, 68);
            this.LabelTopPostComments.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTopPostComments.Name = "LabelTopPostComments";
            this.LabelTopPostComments.Size = new System.Drawing.Size(166, 28);
            this.LabelTopPostComments.TabIndex = 9;
            this.LabelTopPostComments.Text = "Comments: ";
            this.LabelTopPostComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTopPostLikes
            // 
            this.LabelTopPostLikes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPostLikes.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPostLikes.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPostLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPostLikes.Location = new System.Drawing.Point(9, 40);
            this.LabelTopPostLikes.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTopPostLikes.Name = "LabelTopPostLikes";
            this.LabelTopPostLikes.Size = new System.Drawing.Size(166, 28);
            this.LabelTopPostLikes.TabIndex = 8;
            this.LabelTopPostLikes.Text = "Likes: ";
            this.LabelTopPostLikes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTopPost
            // 
            this.LabelTopPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTopPost.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopPost.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelTopPost.Location = new System.Drawing.Point(0, 0);
            this.LabelTopPost.Name = "LabelTopPost";
            this.LabelTopPost.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.LabelTopPost.Size = new System.Drawing.Size(363, 35);
            this.LabelTopPost.TabIndex = 1;
            this.LabelTopPost.Text = "Top Post";
            // 
            // panelFriends
            // 
            this.panelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriends.AutoScroll = true;
            this.panelFriends.BackColor = System.Drawing.Color.White;
            this.panelFriends.Controls.Add(this.LabelFriendsChange);
            this.panelFriends.Controls.Add(this.ChartFriends);
            this.panelFriends.Controls.Add(this.LabelFriends);
            this.panelFriends.GradientAngle = 90F;
            this.panelFriends.GradientColorA = System.Drawing.Color.White;
            this.panelFriends.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelFriends.Location = new System.Drawing.Point(658, 257);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(363, 266);
            this.panelFriends.TabIndex = 2;
            // 
            // LabelFriendsChange
            // 
            this.LabelFriendsChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFriendsChange.BackColor = System.Drawing.Color.Transparent;
            this.LabelFriendsChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelFriendsChange.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFriendsChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelFriendsChange.Location = new System.Drawing.Point(203, 15);
            this.LabelFriendsChange.Name = "LabelFriendsChange";
            this.LabelFriendsChange.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.LabelFriendsChange.Size = new System.Drawing.Size(125, 27);
            this.LabelFriendsChange.TabIndex = 4;
            this.LabelFriendsChange.Text = "+X";
            this.LabelFriendsChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelFriendsChange.Visible = false;
            // 
            // ChartFriends
            // 
            this.ChartFriends.BackColor = System.Drawing.Color.Transparent;
            this.ChartFriends.BorderlineColor = System.Drawing.Color.Transparent;
            this.ChartFriends.BorderlineWidth = 0;
            this.ChartFriends.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartFriends.ChartAreas.Add(chartArea1);
            this.ChartFriends.Location = new System.Drawing.Point(0, 35);
            this.ChartFriends.Margin = new System.Windows.Forms.Padding(0);
            this.ChartFriends.MaximumSize = new System.Drawing.Size(360, 200);
            this.ChartFriends.MinimumSize = new System.Drawing.Size(360, 200);
            this.ChartFriends.Name = "ChartFriends";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Name = "Friends";
            this.ChartFriends.Series.Add(series1);
            this.ChartFriends.Size = new System.Drawing.Size(360, 200);
            this.ChartFriends.TabIndex = 3;
            this.ChartFriends.Text = "Chart2";
            // 
            // LabelFriends
            // 
            this.LabelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelFriends.BackColor = System.Drawing.Color.Transparent;
            this.LabelFriends.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelFriends.Location = new System.Drawing.Point(0, 0);
            this.LabelFriends.Name = "LabelFriends";
            this.LabelFriends.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.LabelFriends.Size = new System.Drawing.Size(168, 52);
            this.LabelFriends.TabIndex = 2;
            this.LabelFriends.Text = "Friends";
            // 
            // panelEngagement
            // 
            this.panelEngagement.AutoScroll = true;
            this.panelEngagement.BackColor = System.Drawing.Color.White;
            this.panelEngagement.Controls.Add(this.ChartEngagement);
            this.panelEngagement.Controls.Add(this.LabelEngagement);
            this.panelEngagement.GradientAngle = 90F;
            this.panelEngagement.GradientColorA = System.Drawing.Color.White;
            this.panelEngagement.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelEngagement.Location = new System.Drawing.Point(272, 0);
            this.panelEngagement.Name = "panelEngagement";
            this.panelEngagement.Size = new System.Drawing.Size(749, 239);
            this.panelEngagement.TabIndex = 1;
            // 
            // ChartEngagement
            // 
            this.ChartEngagement.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartEngagement.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.ChartEngagement.Legends.Add(legend1);
            this.ChartEngagement.Location = new System.Drawing.Point(14, 28);
            this.ChartEngagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartEngagement.Name = "ChartEngagement";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Color = System.Drawing.Color.DarkOrange;
            series2.Legend = "Legend1";
            series2.Name = "Likes";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series3.Color = System.Drawing.Color.Teal;
            series3.Legend = "Legend1";
            series3.Name = "Comments";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.ChartEngagement.Series.Add(series2);
            this.ChartEngagement.Series.Add(series3);
            this.ChartEngagement.Size = new System.Drawing.Size(724, 203);
            this.ChartEngagement.TabIndex = 2;
            this.ChartEngagement.Text = "ChartEngagement";
            // 
            // LabelEngagement
            // 
            this.LabelEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelEngagement.BackColor = System.Drawing.Color.Transparent;
            this.LabelEngagement.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEngagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelEngagement.Location = new System.Drawing.Point(0, 0);
            this.LabelEngagement.Name = "LabelEngagement";
            this.LabelEngagement.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.LabelEngagement.Size = new System.Drawing.Size(749, 35);
            this.LabelEngagement.TabIndex = 0;
            this.LabelEngagement.Text = "Engagement";
            // 
            // panelUserBio
            // 
            this.panelUserBio.AutoScroll = true;
            this.panelUserBio.BackColor = System.Drawing.Color.White;
            this.panelUserBio.Controls.Add(this.LabelRecentStatusUpdateDateTime);
            this.panelUserBio.Controls.Add(this.LabelRecentStatusUpdateContent);
            this.panelUserBio.Controls.Add(this.LabelRecentStatusUpdateTitle);
            this.panelUserBio.Controls.Add(this.LabelBio3);
            this.panelUserBio.Controls.Add(this.LabelBio2);
            this.panelUserBio.Controls.Add(this.LabelBio1);
            this.panelUserBio.Controls.Add(this.LabelName);
            this.panelUserBio.Controls.Add(this.PictureBoxBioProfilePic);
            this.panelUserBio.GradientAngle = 90F;
            this.panelUserBio.GradientColorA = System.Drawing.Color.White;
            this.panelUserBio.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelUserBio.Location = new System.Drawing.Point(0, 0);
            this.panelUserBio.Name = "panelUserBio";
            this.panelUserBio.Size = new System.Drawing.Size(250, 523);
            this.panelUserBio.TabIndex = 0;
            // 
            // LabelRecentStatusUpdateDateTime
            // 
            this.LabelRecentStatusUpdateDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelRecentStatusUpdateDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelRecentStatusUpdateDateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecentStatusUpdateDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(22, 491);
            this.LabelRecentStatusUpdateDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.LabelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(200, 30);
            this.LabelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(200, 23);
            this.LabelRecentStatusUpdateDateTime.Name = "LabelRecentStatusUpdateDateTime";
            this.LabelRecentStatusUpdateDateTime.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LabelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(200, 30);
            this.LabelRecentStatusUpdateDateTime.TabIndex = 7;
            this.LabelRecentStatusUpdateDateTime.Text = "- Date Time";
            // 
            // LabelRecentStatusUpdateContent
            // 
            this.LabelRecentStatusUpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelRecentStatusUpdateContent.AutoSize = true;
            this.LabelRecentStatusUpdateContent.BackColor = System.Drawing.Color.Transparent;
            this.LabelRecentStatusUpdateContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecentStatusUpdateContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelRecentStatusUpdateContent.Location = new System.Drawing.Point(24, 402);
            this.LabelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(200, 89);
            this.LabelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(200, 2);
            this.LabelRecentStatusUpdateContent.Name = "LabelRecentStatusUpdateContent";
            this.LabelRecentStatusUpdateContent.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelRecentStatusUpdateContent.Size = new System.Drawing.Size(200, 22);
            this.LabelRecentStatusUpdateContent.TabIndex = 6;
            this.LabelRecentStatusUpdateContent.Text = "Bla bla bla bla bla.";
            // 
            // LabelRecentStatusUpdateTitle
            // 
            this.LabelRecentStatusUpdateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelRecentStatusUpdateTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelRecentStatusUpdateTitle.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecentStatusUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelRecentStatusUpdateTitle.Location = new System.Drawing.Point(25, 361);
            this.LabelRecentStatusUpdateTitle.Name = "LabelRecentStatusUpdateTitle";
            this.LabelRecentStatusUpdateTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.LabelRecentStatusUpdateTitle.Size = new System.Drawing.Size(200, 42);
            this.LabelRecentStatusUpdateTitle.TabIndex = 5;
            this.LabelRecentStatusUpdateTitle.Text = "Recent Status Update";
            this.LabelRecentStatusUpdateTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabelBio3
            // 
            this.LabelBio3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBio3.BackColor = System.Drawing.Color.Transparent;
            this.LabelBio3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBio3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelBio3.Location = new System.Drawing.Point(25, 333);
            this.LabelBio3.Name = "LabelBio3";
            this.LabelBio3.Size = new System.Drawing.Size(200, 28);
            this.LabelBio3.TabIndex = 4;
            this.LabelBio3.Text = "Detail 3";
            this.LabelBio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBio2
            // 
            this.LabelBio2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBio2.BackColor = System.Drawing.Color.Transparent;
            this.LabelBio2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelBio2.Location = new System.Drawing.Point(25, 305);
            this.LabelBio2.Name = "LabelBio2";
            this.LabelBio2.Size = new System.Drawing.Size(200, 25);
            this.LabelBio2.TabIndex = 3;
            this.LabelBio2.Text = "Detail 2";
            this.LabelBio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBio1
            // 
            this.LabelBio1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBio1.BackColor = System.Drawing.Color.Transparent;
            this.LabelBio1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelBio1.Location = new System.Drawing.Point(25, 277);
            this.LabelBio1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBio1.Name = "LabelBio1";
            this.LabelBio1.Size = new System.Drawing.Size(200, 28);
            this.LabelBio1.TabIndex = 2;
            this.LabelBio1.Text = "Detail 1";
            this.LabelBio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LabelName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelName.Location = new System.Drawing.Point(25, 232);
            this.LabelName.MaximumSize = new System.Drawing.Size(250, 0);
            this.LabelName.MinimumSize = new System.Drawing.Size(200, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 13);
            this.LabelName.Size = new System.Drawing.Size(200, 46);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "John Doe";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBoxBioProfilePic
            // 
            this.PictureBoxBioProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxBioProfilePic.Location = new System.Drawing.Point(25, 19);
            this.PictureBoxBioProfilePic.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxBioProfilePic.Name = "PictureBoxBioProfilePic";
            this.PictureBoxBioProfilePic.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxBioProfilePic.TabIndex = 0;
            this.PictureBoxBioProfilePic.TabStop = false;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTopPost);
            this.Controls.Add(this.panelFriends);
            this.Controls.Add(this.panelEngagement);
            this.Controls.Add(this.panelUserBio);
            this.Controls.Add(this.LabelError);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelTopPost.ResumeLayout(false);
            this.panelTopPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopPost)).EndInit();
            this.panelFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartFriends)).EndInit();
            this.panelEngagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartEngagement)).EndInit();
            this.panelUserBio.ResumeLayout(false);
            this.panelUserBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBioProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StylizedPanel panelUserBio;
        private StylizedPanel panelEngagement;
        private StylizedPanel panelFriends;
        private StylizedPanel panelTopPost;
        public System.Windows.Forms.Label LabelEngagement;
        public System.Windows.Forms.Label LabelFriends;
        public System.Windows.Forms.Label LabelTopPost;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Label LabelBio1;
        public System.Windows.Forms.Label LabelBio2;
        public System.Windows.Forms.Label LabelBio3;
        public System.Windows.Forms.Label LabelRecentStatusUpdateTitle;
        public System.Windows.Forms.Label LabelRecentStatusUpdateContent;
        public System.Windows.Forms.Label LabelRecentStatusUpdateDateTime;
        public System.Windows.Forms.Label LabelTopPostCaptionDateTime;
        public System.Windows.Forms.Label LabelTopPostCaptionContent;
        public System.Windows.Forms.Label LabelTopPostCaptionTitle;
        public System.Windows.Forms.Label LabelTopPostComments;
        public System.Windows.Forms.Label LabelTopPostLikes;
        public System.Windows.Forms.Label LabelFriendsChange;
        public System.Windows.Forms.Label LabelTopPostError;
        public System.Windows.Forms.Label LabelError;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartFriends;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartEngagement;
        public System.Windows.Forms.PictureBox PictureBoxBioProfilePic;
        public System.Windows.Forms.PictureBox PictureBoxTopPost;
    }
}
