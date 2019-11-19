namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    partial class dashboard
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
            this.panelUserBio = new System.Windows.Forms.Panel();
            this.panelEngagement = new System.Windows.Forms.Panel();
            this.labelEngagement = new System.Windows.Forms.Label();
            this.panelBestTimes = new System.Windows.Forms.Panel();
            this.panelTopLikes = new System.Windows.Forms.Panel();
            this.labelTopLikes = new System.Windows.Forms.Label();
            this.labelBestTimes = new System.Windows.Forms.Label();
            this.panelEngagement.SuspendLayout();
            this.panelBestTimes.SuspendLayout();
            this.panelTopLikes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserBio
            // 
            this.panelUserBio.AutoScroll = true;
            this.panelUserBio.BackColor = System.Drawing.Color.White;
            this.panelUserBio.Location = new System.Drawing.Point(0, 0);
            this.panelUserBio.Name = "panelUserBio";
            this.panelUserBio.Size = new System.Drawing.Size(250, 523);
            this.panelUserBio.TabIndex = 0;
            // 
            // panelEngagement
            // 
            this.panelEngagement.AutoScroll = true;
            this.panelEngagement.BackColor = System.Drawing.Color.White;
            this.panelEngagement.Controls.Add(this.labelEngagement);
            this.panelEngagement.Location = new System.Drawing.Point(272, 0);
            this.panelEngagement.Name = "panelEngagement";
            this.panelEngagement.Size = new System.Drawing.Size(749, 239);
            this.panelEngagement.TabIndex = 1;
            // 
            // labelEngagement
            // 
            this.labelEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEngagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelEngagement.Location = new System.Drawing.Point(0, 0);
            this.labelEngagement.Name = "labelEngagement";
            this.labelEngagement.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelEngagement.Size = new System.Drawing.Size(749, 35);
            this.labelEngagement.TabIndex = 0;
            this.labelEngagement.Text = "Engagement";
            // 
            // panelBestTimes
            // 
            this.panelBestTimes.AutoScroll = true;
            this.panelBestTimes.BackColor = System.Drawing.Color.White;
            this.panelBestTimes.Controls.Add(this.labelBestTimes);
            this.panelBestTimes.Location = new System.Drawing.Point(658, 257);
            this.panelBestTimes.Name = "panelBestTimes";
            this.panelBestTimes.Size = new System.Drawing.Size(363, 266);
            this.panelBestTimes.TabIndex = 2;
            // 
            // panelTopLikes
            // 
            this.panelTopLikes.AutoScroll = true;
            this.panelTopLikes.BackColor = System.Drawing.Color.White;
            this.panelTopLikes.Controls.Add(this.labelTopLikes);
            this.panelTopLikes.Location = new System.Drawing.Point(272, 257);
            this.panelTopLikes.Name = "panelTopLikes";
            this.panelTopLikes.Size = new System.Drawing.Size(363, 266);
            this.panelTopLikes.TabIndex = 3;
            this.panelTopLikes.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // labelTopLikes
            // 
            this.labelTopLikes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopLikes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelTopLikes.Location = new System.Drawing.Point(0, 0);
            this.labelTopLikes.Name = "labelTopLikes";
            this.labelTopLikes.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelTopLikes.Size = new System.Drawing.Size(363, 35);
            this.labelTopLikes.TabIndex = 1;
            this.labelTopLikes.Text = "Top Likes";
            // 
            // labelBestTimes
            // 
            this.labelBestTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBestTimes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelBestTimes.Location = new System.Drawing.Point(0, 0);
            this.labelBestTimes.Name = "labelBestTimes";
            this.labelBestTimes.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelBestTimes.Size = new System.Drawing.Size(363, 35);
            this.labelBestTimes.TabIndex = 2;
            this.labelBestTimes.Text = "Best Time to Post";
            this.labelBestTimes.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTopLikes);
            this.Controls.Add(this.panelBestTimes);
            this.Controls.Add(this.panelEngagement);
            this.Controls.Add(this.panelUserBio);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1021, 523);
            this.panelEngagement.ResumeLayout(false);
            this.panelBestTimes.ResumeLayout(false);
            this.panelTopLikes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserBio;
        private System.Windows.Forms.Panel panelEngagement;
        private System.Windows.Forms.Panel panelBestTimes;
        private System.Windows.Forms.Panel panelTopLikes;
        private System.Windows.Forms.Label labelEngagement;
        private System.Windows.Forms.Label labelBestTimes;
        private System.Windows.Forms.Label labelTopLikes;
    }
}
