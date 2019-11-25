using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    partial class Boost
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boost));
            this.navbarSeparator = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnUsername = new System.Windows.Forms.Button();
            this.navbarProfilePic = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.login = new A20_EX01_Idan_203315098_Dolev_205811797.Login(this);
            this.dashboard = new A20_EX01_Idan_203315098_Dolev_205811797.Dashboard();
            this.analytics = new A20_EX01_Idan_203315098_Dolev_205811797.Analytics();
            ((System.ComponentModel.ISupportInitialize)(this.navbarProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarSeparator
            // 
            this.navbarSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.navbarSeparator.ForeColor = System.Drawing.Color.Transparent;
            this.navbarSeparator.Location = new System.Drawing.Point(56, 62);
            this.navbarSeparator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navbarSeparator.Name = "navbarSeparator";
            this.navbarSeparator.Size = new System.Drawing.Size(1021, 3);
            this.navbarSeparator.TabIndex = 1;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Transparent;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Font = UI_Elements.font_Footer;
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.footer.Location = new System.Drawing.Point(0, 605);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1135, 33);
            this.footer.TabIndex = 6;
            this.footer.Text = "ALL RIGHTS RESERVED TO BOOST FOR FACEBOOK © 2019";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = UI_Elements.font_NavbarButton;
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(175, 20);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 32);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = UI_Elements.font_NavbarButton;
            this.btnAnalytics.ForeColor = System.Drawing.Color.Black;
            this.btnAnalytics.Location = new System.Drawing.Point(300, 20);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(130, 32);
            this.btnAnalytics.TabIndex = 8;
            this.btnAnalytics.Text = "ANALYTICS";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            // 
            // 
            // btnUsername
            // 
            this.btnUsername.BackColor = System.Drawing.Color.Transparent;
            this.btnUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsername.FlatAppearance.BorderSize = 0;
            this.btnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsername.Font = UI_Elements.font_NavbarButton;
            this.btnUsername.ForeColor = System.Drawing.Color.Black;
            this.btnUsername.Location = new System.Drawing.Point(936, 20);
            this.btnUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(104, 32);
            this.btnUsername.TabIndex = 11;
            this.btnUsername.Text = "John Doe";
            this.btnUsername.UseVisualStyleBackColor = false;
            // 
            // navbarProfilePic
            // 
            this.navbarProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.navbarProfilePic.Location = new System.Drawing.Point(1046, 20);
            this.navbarProfilePic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navbarProfilePic.Name = "navbarProfilePic";
            this.navbarProfilePic.Size = new System.Drawing.Size(31, 32);
            this.navbarProfilePic.TabIndex = 10;
            this.navbarProfilePic.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_navbar;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(56, 16);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(94, 32);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard.Location = new System.Drawing.Point(56, 79);
            this.dashboard.MaximumSize = this.dashboard.Size;
            this.dashboard.MinimumSize = this.dashboard.Size;
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(1021, 523);
            this.dashboard.TabIndex = 12;
            // 
            // analytics
            // 
            this.analytics.BackColor = System.Drawing.Color.Transparent;
            this.analytics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analytics.Location = new System.Drawing.Point(56, 79);
            this.analytics.Name = "analytics";
            this.analytics.Size = new System.Drawing.Size(1021, 523);
            this.analytics.TabIndex = 13;
            //
            // login
            // 
            this.login.Location = new System.Drawing.Point(-5, -5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1141, 643);
            this.login.Visible = false;
            // Boost
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = UI_Elements.color_BGColor;
            this.Name = "Boost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boost for Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.navbarProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.Controls.Add(this.analytics);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.btnUsername);
            this.Controls.Add(this.navbarProfilePic);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.navbarSeparator);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.login);
            this.ResumeLayout(false);

        }



        #endregion

        public PictureBox logoPictureBox;
        public Panel navbarSeparator;
        public Label footer;
        public Button btnDashboard;
        public Button btnAnalytics;
        public Button btnReports;
        public PictureBox navbarProfilePic;
        public Button btnUsername;
        public Dashboard dashboard;
        public Analytics analytics;
        public Login login;
    }
}

