using System.Drawing;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTopPost = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.labelTopPostError = new System.Windows.Forms.Label();
            this.pictureBoxTopPost = new System.Windows.Forms.PictureBox();
            this.labelTopPostCaptionDateTime = new System.Windows.Forms.Label();
            this.labelTopPostCaptionContent = new System.Windows.Forms.Label();
            this.labelTopPostCaptionTitle = new System.Windows.Forms.Label();
            this.labelTopPostComments = new System.Windows.Forms.Label();
            this.labelTopPostLikes = new System.Windows.Forms.Label();
            this.labelTopPost = new System.Windows.Forms.Label();
            this.panelFriends = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.labelFriendsChange = new System.Windows.Forms.Label();
            this.chartFriends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFriends = new System.Windows.Forms.Label();
            this.panelEngagement = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.chartEngagement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelEngagement = new System.Windows.Forms.Label();
            this.panelUserBio = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.labelRecentStatusUpdateDateTime = new System.Windows.Forms.Label();
            this.labelRecentStatusUpdateContent = new System.Windows.Forms.Label();
            this.labelRecentStatusUpdateTitle = new System.Windows.Forms.Label();
            this.labelBio3 = new System.Windows.Forms.Label();
            this.labelBio2 = new System.Windows.Forms.Label();
            this.labelBio1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxBioProfilePic = new System.Windows.Forms.PictureBox();
            this.panelTopPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPost)).BeginInit();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFriends)).BeginInit();
            this.panelEngagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEngagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelUserBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBioProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopPost
            // 
            this.panelTopPost.AutoScroll = true;
            this.panelTopPost.BackColor = System.Drawing.Color.White;
            this.panelTopPost.Controls.Add(this.labelTopPostError);
            this.panelTopPost.Controls.Add(this.pictureBoxTopPost);
            this.panelTopPost.Controls.Add(this.labelTopPostCaptionDateTime);
            this.panelTopPost.Controls.Add(this.labelTopPostCaptionContent);
            this.panelTopPost.Controls.Add(this.labelTopPostCaptionTitle);
            this.panelTopPost.Controls.Add(this.labelTopPostComments);
            this.panelTopPost.Controls.Add(this.labelTopPostLikes);
            this.panelTopPost.Controls.Add(this.labelTopPost);
            this.panelTopPost.GradientAngle = 90F;
            this.panelTopPost.GradientColorA = System.Drawing.Color.White;
            this.panelTopPost.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelTopPost.Location = new System.Drawing.Point(272, 257);
            this.panelTopPost.Name = "panelTopPost";
            this.panelTopPost.Size = new System.Drawing.Size(363, 266);
            this.panelTopPost.TabIndex = 3;
            // 
            // labelTopPostError
            // 
            this.labelTopPostError.AutoSize = true;
            this.labelTopPostError.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostError.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTopPostError.Location = new System.Drawing.Point(11, 45);
            this.labelTopPostError.MaximumSize = new System.Drawing.Size(230, 230);
            this.labelTopPostError.Name = "labelTopPostError";
            this.labelTopPostError.Size = new System.Drawing.Size(84, 28);
            this.labelTopPostError.TabIndex = 12;
            this.labelTopPostError.Text = "label1";
            this.labelTopPostError.Visible = false;
            // 
            // pictureBoxTopPost
            // 
            this.pictureBoxTopPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTopPost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTopPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTopPost.Location = new System.Drawing.Point(181, 49);
            this.pictureBoxTopPost.Name = "pictureBoxTopPost";
            this.pictureBoxTopPost.Size = new System.Drawing.Size(168, 97);
            this.pictureBoxTopPost.TabIndex = 11;
            this.pictureBoxTopPost.TabStop = false;
            // 
            // labelTopPostCaptionDateTime
            // 
            this.labelTopPostCaptionDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPostCaptionDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostCaptionDateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostCaptionDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPostCaptionDateTime.Location = new System.Drawing.Point(8, 235);
            this.labelTopPostCaptionDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelTopPostCaptionDateTime.MaximumSize = new System.Drawing.Size(200, 30);
            this.labelTopPostCaptionDateTime.MinimumSize = new System.Drawing.Size(200, 23);
            this.labelTopPostCaptionDateTime.Name = "labelTopPostCaptionDateTime";
            this.labelTopPostCaptionDateTime.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelTopPostCaptionDateTime.Size = new System.Drawing.Size(200, 25);
            this.labelTopPostCaptionDateTime.TabIndex = 10;
            this.labelTopPostCaptionDateTime.Text = "- Date Time";
            // 
            // labelTopPostCaptionContent
            // 
            this.labelTopPostCaptionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPostCaptionContent.AutoSize = true;
            this.labelTopPostCaptionContent.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostCaptionContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostCaptionContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPostCaptionContent.Location = new System.Drawing.Point(10, 173);
            this.labelTopPostCaptionContent.MaximumSize = new System.Drawing.Size(200, 89);
            this.labelTopPostCaptionContent.MinimumSize = new System.Drawing.Size(200, 2);
            this.labelTopPostCaptionContent.Name = "labelTopPostCaptionContent";
            this.labelTopPostCaptionContent.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelTopPostCaptionContent.Size = new System.Drawing.Size(200, 22);
            this.labelTopPostCaptionContent.TabIndex = 9;
            this.labelTopPostCaptionContent.Text = "Bla bla bla bla bla.";
            // 
            // labelTopPostCaptionTitle
            // 
            this.labelTopPostCaptionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPostCaptionTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostCaptionTitle.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostCaptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPostCaptionTitle.Location = new System.Drawing.Point(11, 132);
            this.labelTopPostCaptionTitle.Name = "labelTopPostCaptionTitle";
            this.labelTopPostCaptionTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.labelTopPostCaptionTitle.Size = new System.Drawing.Size(164, 41);
            this.labelTopPostCaptionTitle.TabIndex = 8;
            this.labelTopPostCaptionTitle.Text = "Caption";
            this.labelTopPostCaptionTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTopPostComments
            // 
            this.labelTopPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPostComments.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostComments.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPostComments.Location = new System.Drawing.Point(9, 68);
            this.labelTopPostComments.Margin = new System.Windows.Forms.Padding(0);
            this.labelTopPostComments.Name = "labelTopPostComments";
            this.labelTopPostComments.Size = new System.Drawing.Size(166, 28);
            this.labelTopPostComments.TabIndex = 9;
            this.labelTopPostComments.Text = "Comments: ";
            this.labelTopPostComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTopPostLikes
            // 
            this.labelTopPostLikes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPostLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPostLikes.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPostLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPostLikes.Location = new System.Drawing.Point(9, 40);
            this.labelTopPostLikes.Margin = new System.Windows.Forms.Padding(0);
            this.labelTopPostLikes.Name = "labelTopPostLikes";
            this.labelTopPostLikes.Size = new System.Drawing.Size(166, 28);
            this.labelTopPostLikes.TabIndex = 8;
            this.labelTopPostLikes.Text = "Likes: ";
            this.labelTopPostLikes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTopPost
            // 
            this.labelTopPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopPost.BackColor = System.Drawing.Color.Transparent;
            this.labelTopPost.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopPost.Location = new System.Drawing.Point(0, 0);
            this.labelTopPost.Name = "labelTopPost";
            this.labelTopPost.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelTopPost.Size = new System.Drawing.Size(363, 35);
            this.labelTopPost.TabIndex = 1;
            this.labelTopPost.Text = "Top Post";
            // 
            // panelFriends
            // 
            this.panelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriends.AutoScroll = true;
            this.panelFriends.BackColor = System.Drawing.Color.White;
            this.panelFriends.Controls.Add(this.labelFriendsChange);
            this.panelFriends.Controls.Add(this.chartFriends);
            this.panelFriends.Controls.Add(this.labelFriends);
            this.panelFriends.GradientAngle = 90F;
            this.panelFriends.GradientColorA = System.Drawing.Color.White;
            this.panelFriends.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelFriends.Location = new System.Drawing.Point(658, 257);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(363, 266);
            this.panelFriends.TabIndex = 2;
            // 
            // labelFriendsChange
            // 
            this.labelFriendsChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFriendsChange.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendsChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFriendsChange.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelFriendsChange.Location = new System.Drawing.Point(203, 15);
            this.labelFriendsChange.Name = "labelFriendsChange";
            this.labelFriendsChange.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelFriendsChange.Size = new System.Drawing.Size(125, 27);
            this.labelFriendsChange.TabIndex = 4;
            this.labelFriendsChange.Text = "+X";
            this.labelFriendsChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFriendsChange.Visible = false;
            // 
            // chartFriends
            // 
            this.chartFriends.BackColor = System.Drawing.Color.Transparent;
            this.chartFriends.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartFriends.BorderlineWidth = 0;
            this.chartFriends.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartFriends.ChartAreas.Add(chartArea1);
            this.chartFriends.Location = new System.Drawing.Point(0, 35);
            this.chartFriends.Margin = new System.Windows.Forms.Padding(0);
            this.chartFriends.MaximumSize = new System.Drawing.Size(360, 200);
            this.chartFriends.MinimumSize = new System.Drawing.Size(360, 200);
            this.chartFriends.Name = "chartFriends";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Name = "Friends";
            this.chartFriends.Series.Add(series1);
            this.chartFriends.Size = new System.Drawing.Size(360, 200);
            this.chartFriends.TabIndex = 3;
            this.chartFriends.Text = "chart2";
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelFriends.Location = new System.Drawing.Point(0, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelFriends.Size = new System.Drawing.Size(168, 52);
            this.labelFriends.TabIndex = 2;
            this.labelFriends.Text = "Friends";
            // 
            // panelEngagement
            // 
            this.panelEngagement.AutoScroll = true;
            this.panelEngagement.BackColor = System.Drawing.Color.White;
            this.panelEngagement.Controls.Add(this.chartEngagement);
            this.panelEngagement.Controls.Add(this.chart1);
            this.panelEngagement.Controls.Add(this.labelEngagement);
            this.panelEngagement.GradientAngle = 90F;
            this.panelEngagement.GradientColorA = System.Drawing.Color.White;
            this.panelEngagement.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelEngagement.Location = new System.Drawing.Point(272, 0);
            this.panelEngagement.Name = "panelEngagement";
            this.panelEngagement.Size = new System.Drawing.Size(749, 239);
            this.panelEngagement.TabIndex = 1;
            // 
            // chartEngagement
            // 
            this.chartEngagement.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.chartEngagement.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartEngagement.Legends.Add(legend1);
            this.chartEngagement.Location = new System.Drawing.Point(14, 28);
            this.chartEngagement.Margin = new System.Windows.Forms.Padding(2);
            this.chartEngagement.Name = "chartEngagement";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Legend = "Legend1";
            series2.Name = "Likes";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series3.Legend = "Legend1";
            series3.Name = "Comments";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chartEngagement.Series.Add(series2);
            this.chartEngagement.Series.Add(series3);
            this.chartEngagement.Size = new System.Drawing.Size(724, 203);
            this.chartEngagement.TabIndex = 2;
            this.chartEngagement.Text = "chartEngagement";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 95F;
            chartArea3.Position.Width = 85F;
            chartArea3.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea3);
            legend2.AutoFitMinFontSize = 8;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend2.IsTextAutoFit = false;
            legend2.MaximumAutoSize = 40F;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 28F;
            legend2.Position.Width = 14F;
            legend2.Position.X = 86F;
            legend2.Position.Y = 15F;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 28);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Photos";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Videos";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Status";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(726, 208);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // labelEngagement
            // 
            this.labelEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEngagement.BackColor = System.Drawing.Color.Transparent;
            this.labelEngagement.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelEngagement.Location = new System.Drawing.Point(0, 0);
            this.labelEngagement.Name = "labelEngagement";
            this.labelEngagement.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelEngagement.Size = new System.Drawing.Size(749, 35);
            this.labelEngagement.TabIndex = 0;
            this.labelEngagement.Text = "Engagement";
            // 
            // panelUserBio
            // 
            this.panelUserBio.AutoScroll = true;
            this.panelUserBio.BackColor = System.Drawing.Color.White;
            this.panelUserBio.Controls.Add(this.labelRecentStatusUpdateDateTime);
            this.panelUserBio.Controls.Add(this.labelRecentStatusUpdateContent);
            this.panelUserBio.Controls.Add(this.labelRecentStatusUpdateTitle);
            this.panelUserBio.Controls.Add(this.labelBio3);
            this.panelUserBio.Controls.Add(this.labelBio2);
            this.panelUserBio.Controls.Add(this.labelBio1);
            this.panelUserBio.Controls.Add(this.labelName);
            this.panelUserBio.Controls.Add(this.pictureBoxBioProfilePic);
            this.panelUserBio.GradientAngle = 90F;
            this.panelUserBio.GradientColorA = System.Drawing.Color.White;
            this.panelUserBio.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelUserBio.Location = new System.Drawing.Point(0, 0);
            this.panelUserBio.Name = "panelUserBio";
            this.panelUserBio.Size = new System.Drawing.Size(250, 523);
            this.panelUserBio.TabIndex = 0;
            // 
            // labelRecentStatusUpdateDateTime
            // 
            this.labelRecentStatusUpdateDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecentStatusUpdateDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelRecentStatusUpdateDateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentStatusUpdateDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelRecentStatusUpdateDateTime.Location = new System.Drawing.Point(22, 491);
            this.labelRecentStatusUpdateDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecentStatusUpdateDateTime.MaximumSize = new System.Drawing.Size(200, 30);
            this.labelRecentStatusUpdateDateTime.MinimumSize = new System.Drawing.Size(200, 23);
            this.labelRecentStatusUpdateDateTime.Name = "labelRecentStatusUpdateDateTime";
            this.labelRecentStatusUpdateDateTime.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelRecentStatusUpdateDateTime.Size = new System.Drawing.Size(200, 30);
            this.labelRecentStatusUpdateDateTime.TabIndex = 7;
            this.labelRecentStatusUpdateDateTime.Text = "- Date Time";
            // 
            // labelRecentStatusUpdateContent
            // 
            this.labelRecentStatusUpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecentStatusUpdateContent.AutoSize = true;
            this.labelRecentStatusUpdateContent.BackColor = System.Drawing.Color.Transparent;
            this.labelRecentStatusUpdateContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentStatusUpdateContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelRecentStatusUpdateContent.Location = new System.Drawing.Point(24, 402);
            this.labelRecentStatusUpdateContent.MaximumSize = new System.Drawing.Size(200, 89);
            this.labelRecentStatusUpdateContent.MinimumSize = new System.Drawing.Size(200, 2);
            this.labelRecentStatusUpdateContent.Name = "labelRecentStatusUpdateContent";
            this.labelRecentStatusUpdateContent.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelRecentStatusUpdateContent.Size = new System.Drawing.Size(200, 22);
            this.labelRecentStatusUpdateContent.TabIndex = 6;
            this.labelRecentStatusUpdateContent.Text = "Bla bla bla bla bla.";
            // 
            // labelRecentStatusUpdateTitle
            // 
            this.labelRecentStatusUpdateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecentStatusUpdateTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelRecentStatusUpdateTitle.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentStatusUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelRecentStatusUpdateTitle.Location = new System.Drawing.Point(25, 361);
            this.labelRecentStatusUpdateTitle.Name = "labelRecentStatusUpdateTitle";
            this.labelRecentStatusUpdateTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.labelRecentStatusUpdateTitle.Size = new System.Drawing.Size(200, 60);
            this.labelRecentStatusUpdateTitle.TabIndex = 5;
            this.labelRecentStatusUpdateTitle.Text = "Recent Status Update";
            this.labelRecentStatusUpdateTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelBio3
            // 
            this.labelBio3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBio3.BackColor = System.Drawing.Color.Transparent;
            this.labelBio3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelBio3.Location = new System.Drawing.Point(25, 333);
            this.labelBio3.Name = "labelBio3";
            this.labelBio3.Size = new System.Drawing.Size(200, 37);
            this.labelBio3.TabIndex = 4;
            this.labelBio3.Text = "Detail 3";
            this.labelBio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBio2
            // 
            this.labelBio2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBio2.BackColor = System.Drawing.Color.Transparent;
            this.labelBio2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelBio2.Location = new System.Drawing.Point(25, 305);
            this.labelBio2.Name = "labelBio2";
            this.labelBio2.Size = new System.Drawing.Size(200, 37);
            this.labelBio2.TabIndex = 3;
            this.labelBio2.Text = "Detail 2";
            this.labelBio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBio1
            // 
            this.labelBio1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBio1.BackColor = System.Drawing.Color.Transparent;
            this.labelBio1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelBio1.Location = new System.Drawing.Point(25, 277);
            this.labelBio1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBio1.Name = "labelBio1";
            this.labelBio1.Size = new System.Drawing.Size(200, 37);
            this.labelBio1.TabIndex = 2;
            this.labelBio1.Text = "Detail 1";
            this.labelBio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelName.Location = new System.Drawing.Point(25, 232);
            this.labelName.MaximumSize = new System.Drawing.Size(250, 0);
            this.labelName.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 13);
            this.labelName.Size = new System.Drawing.Size(200, 46);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "John Doe";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxBioProfilePic
            // 
            this.pictureBoxBioProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBioProfilePic.Location = new System.Drawing.Point(25, 19);
            this.pictureBoxBioProfilePic.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxBioProfilePic.Name = "pictureBoxBioProfilePic";
            this.pictureBoxBioProfilePic.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBioProfilePic.TabIndex = 0;
            this.pictureBoxBioProfilePic.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTopPost);
            this.Controls.Add(this.panelFriends);
            this.Controls.Add(this.panelEngagement);
            this.Controls.Add(this.panelUserBio);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelTopPost.ResumeLayout(false);
            this.panelTopPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPost)).EndInit();
            this.panelFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFriends)).EndInit();
            this.panelEngagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEngagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelUserBio.ResumeLayout(false);
            this.panelUserBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBioProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel panelUserBio;
        private GradientPanel panelEngagement;
        private GradientPanel panelFriends;
        private GradientPanel panelTopPost;
        public System.Windows.Forms.Label labelEngagement;
        public System.Windows.Forms.Label labelFriends;
        public System.Windows.Forms.Label labelTopPost;
        public System.Windows.Forms.PictureBox pictureBoxBioProfilePic;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelBio1;
        public System.Windows.Forms.Label labelBio2;
        public System.Windows.Forms.Label labelBio3;
        public System.Windows.Forms.Label labelRecentStatusUpdateTitle;
        public System.Windows.Forms.Label labelRecentStatusUpdateContent;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartFriends;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartEngagement;
        public System.Windows.Forms.Label labelRecentStatusUpdateDateTime;
        public System.Windows.Forms.Label labelTopPostCaptionDateTime;
        public System.Windows.Forms.Label labelTopPostCaptionContent;
        public System.Windows.Forms.Label labelTopPostCaptionTitle;
        public System.Windows.Forms.Label labelTopPostComments;
        public System.Windows.Forms.Label labelTopPostLikes;
        public System.Windows.Forms.PictureBox pictureBoxTopPost;
        public System.Windows.Forms.Label labelFriendsChange;
        public System.Windows.Forms.Label labelTopPostError;
    }
}
