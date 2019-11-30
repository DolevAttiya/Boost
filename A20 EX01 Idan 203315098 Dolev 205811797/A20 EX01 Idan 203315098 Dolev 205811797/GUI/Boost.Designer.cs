using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
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
            this.navbarSeparator = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Label();
            this.welcomeScreen = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.WelcomeScreen();
            this.gradientPanelFooterRight = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.gradientPanelFooterLeft = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.navbar = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.Navbar();
            this.analytics = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.Analytics();
            this.dashboard = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.Dashboard();
            this.login = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.Login();
            this.timerWelcomeScreen = new System.Windows.Forms.Timer(this.components);
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
            this.footer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.footer.Location = new System.Drawing.Point(0, 605);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1135, 33);
            this.footer.TabIndex = 6;
            this.footer.Text = "ALL RIGHTS RESERVED TO BOOST FOR FACEBOOK © 2019";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeScreen.BackgroundImage")));
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
            // analytics
            // 
            this.analytics.BackColor = System.Drawing.Color.Transparent;
            this.analytics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analytics.Location = new System.Drawing.Point(56, 79);
            this.analytics.Name = "analytics";
            this.analytics.Size = new System.Drawing.Size(1021, 523);
            this.analytics.TabIndex = 13;
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
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login.Location = new System.Drawing.Point(-5, -5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1141, 643);
            this.login.TabIndex = 14;
            this.login.Visible = false;
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
            this.Controls.Add(this.analytics);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.navbarSeparator);
            this.Controls.Add(this.login);
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

        public Panel navbarSeparator;
        public Label footer;
        public Dashboard dashboard;
        public Analytics analytics;
        public Login login;
        private GUI.Navbar navbar;
        private GUI.GradientPanel gradientPanelFooterLeft;
        private GUI.GradientPanel gradientPanelFooterRight;
        private WelcomeScreen welcomeScreen;
        private Timer timerWelcomeScreen;
    }
}