using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Boost
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boost));
            this.NavbarSeparator = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Label();
            this.welcomeScreen = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.WelcomeScreen();
            this.gradientPanelFooterRight = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.gradientPanelFooterLeft = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.navbar = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.Navbar();
            this.AnalyticsPage = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.Analytics();
            this.DashboardPage = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.Dashboard();
            this.LoginPage = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.Login();
            this.AboutPage = new A20_EX02_Idan_203315098_Dolev_205811797.GUI.About();
            this.timerWelcomeScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // navbarSeparator
            // 
            this.NavbarSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.NavbarSeparator.ForeColor = System.Drawing.Color.Transparent;
            this.NavbarSeparator.Location = new System.Drawing.Point(56, 62);
            this.NavbarSeparator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NavbarSeparator.Name = "navbarSeparator";
            this.NavbarSeparator.Size = new System.Drawing.Size(1021, 3);
            this.NavbarSeparator.TabIndex = 1;
            // 
            // footer
            // 
            this.Footer.BackColor = System.Drawing.Color.Transparent;
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.Footer.Location = new System.Drawing.Point(0, 605);
            this.Footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Footer.Name = "footer";
            this.Footer.Size = new System.Drawing.Size(1135, 33);
            this.Footer.TabIndex = 6;
            this.Footer.Text = "ALL RIGHTS RESERVED TO BOOST FOR FACEBOOK © 2019";
            this.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.WelcomeScreen_v4; /*((System.Drawing.Image)(resources.GetObject("welcomeScreen.BackgroundImage")));*/
            this.welcomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomeScreen.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen.Name = "welcomeScreen";
            this.welcomeScreen.Size = new System.Drawing.Size(1135, 638);
            this.welcomeScreen.TabIndex = 18;
            // 
            // gradientPanelFooterRight
            // 
            this.gradientPanelFooterRight.GradientAngle = 180F;
            this.gradientPanelFooterRight.GradientColorA = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.gradientPanelFooterRight.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.gradientPanelFooterRight.Location = new System.Drawing.Point(728, 620);
            this.gradientPanelFooterRight.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanelFooterRight.Name = "gradientPanelFooterRight";
            this.gradientPanelFooterRight.Size = new System.Drawing.Size(350, 2);
            this.gradientPanelFooterRight.TabIndex = 17;
            // 
            // gradientPanelFooterLeft
            // 
            this.gradientPanelFooterLeft.GradientAngle = 0F;
            this.gradientPanelFooterLeft.GradientColorA = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.gradientPanelFooterLeft.GradientColorB = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.gradientPanelFooterLeft.Location = new System.Drawing.Point(56, 620);
            this.gradientPanelFooterLeft.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanelFooterLeft.Name = "gradientPanelFooterLeft";
            this.gradientPanelFooterLeft.Size = new System.Drawing.Size(350, 2);
            this.gradientPanelFooterLeft.TabIndex = 16;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.Transparent;
            this.navbar.Location = new System.Drawing.Point(55, 0);
            this.navbar.Margin = new System.Windows.Forms.Padding(2);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1023, 65);
            this.navbar.TabIndex = 15;
            // 
            // about
            // 
            this.AboutPage.BackColor = System.Drawing.Color.Transparent;
            this.AboutPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutPage.Location = new System.Drawing.Point(56, 79);
            this.AboutPage.Name = "about";
            this.AboutPage.Size = new System.Drawing.Size(1021, 523);
            this.AboutPage.TabIndex = 13;
            // 
            // analytics
            // 
            this.AnalyticsPage.BackColor = System.Drawing.Color.Transparent;
            this.AnalyticsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnalyticsPage.Location = new System.Drawing.Point(56, 79);
            this.AnalyticsPage.Name = "analytics";
            this.AnalyticsPage.Size = new System.Drawing.Size(1021, 523);
            this.AnalyticsPage.TabIndex = 13;
            // 
            // dashboard
            // 
            this.DashboardPage.BackColor = System.Drawing.Color.Transparent;
            this.DashboardPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardPage.Location = new System.Drawing.Point(56, 79);
            this.DashboardPage.MaximumSize = this.DashboardPage.Size;
            this.DashboardPage.MinimumSize = this.DashboardPage.Size;
            this.DashboardPage.Name = "dashboard";
            this.DashboardPage.Size = new System.Drawing.Size(1021, 523);
            this.DashboardPage.TabIndex = 12;
            // 
            // login
            // 
            this.LoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.LoginPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPage.Location = new System.Drawing.Point(-5, -5);
            this.LoginPage.Name = "login";
            this.LoginPage.Size = new System.Drawing.Size(1141, 643);
            this.LoginPage.TabIndex = 14;
            this.LoginPage.Visible = false;
            // 
            // timerWelcomeScreen
            // 
            this.timerWelcomeScreen.Tick += new System.EventHandler(this.TimerWelcomeScreen_Tick);
            // 
            // Boost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.welcomeScreen);
            this.Controls.Add(this.gradientPanelFooterRight);
            this.Controls.Add(this.gradientPanelFooterLeft);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.AnalyticsPage);
            this.Controls.Add(this.AboutPage);
            this.Controls.Add(this.DashboardPage);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.NavbarSeparator);
            this.Controls.Add(this.LoginPage);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Boost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boost for Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Boost_FormClosing);
            this.ResumeLayout(false);

        }
        #endregion

        public Panel NavbarSeparator;
        public Label Footer;
        public Dashboard DashboardPage;
        public Analytics AnalyticsPage;
        public About AboutPage;
        public Login LoginPage;
        private GUI.Navbar navbar;
        private GUI.GradientPanel gradientPanelFooterLeft;
        private GUI.GradientPanel gradientPanelFooterRight;
        private WelcomeScreen welcomeScreen;
        private Timer timerWelcomeScreen;
    }
}