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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.navbarSeparator = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.navbarProfilePic = new System.Windows.Forms.PictureBox();
            this.btnUsername = new System.Windows.Forms.Button();
            this.login1 = new A20_EX01_Idan_203315098_Dolev_205811797.login();
            this.dashboard2 = new A20_EX01_Idan_203315098_Dolev_205811797.dashboard();
            this.dashboard1 = new A20_EX01_Idan_203315098_Dolev_205811797.dashboard();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_navbar;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(56, 20);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(74, 32);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
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
            this.footer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(168, 20);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(104, 32);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.Black;
            this.btnAnalytics.Location = new System.Drawing.Point(278, 20);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(104, 32);
            this.btnAnalytics.TabIndex = 8;
            this.btnAnalytics.Text = "ANALYTICS";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(388, 20);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(104, 32);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // navbarProfilePic
            // 
            this.navbarProfilePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.navbarProfilePic.Location = new System.Drawing.Point(1046, 20);
            this.navbarProfilePic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navbarProfilePic.Name = "navbarProfilePic";
            this.navbarProfilePic.Size = new System.Drawing.Size(31, 32);
            this.navbarProfilePic.TabIndex = 10;
            this.navbarProfilePic.TabStop = false;
            this.navbarProfilePic.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnUsername
            // 
            this.btnUsername.BackColor = System.Drawing.Color.Transparent;
            this.btnUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsername.FlatAppearance.BorderSize = 0;
            this.btnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsername.ForeColor = System.Drawing.Color.Black;
            this.btnUsername.Location = new System.Drawing.Point(936, 20);
            this.btnUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(104, 32);
            this.btnUsername.TabIndex = 11;
            this.btnUsername.Text = "John Doe";
            this.btnUsername.UseVisualStyleBackColor = false;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.login1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login1.Location = new System.Drawing.Point(-8, -2);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1151, 650);
            this.login1.TabIndex = 14;
            // 
            // dashboard2
            // 
            this.dashboard2.BackColor = System.Drawing.Color.Transparent;
            this.dashboard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard2.Location = new System.Drawing.Point(87, 644);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(1021, 523);
            this.dashboard2.TabIndex = 13;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.dashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard1.Location = new System.Drawing.Point(56, 79);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1021, 523);
            this.dashboard1.TabIndex = 12;
            // 
            // Boost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.dashboard2);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.btnUsername);
            this.Controls.Add(this.navbarProfilePic);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.navbarSeparator);
            this.Controls.Add(this.logoPictureBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Boost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boost for Facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarProfilePic)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private PictureBox logoPictureBox;
        private Panel navbarSeparator;
        private Label footer;
        private Button btnDashboard;
        private Button btnAnalytics;
        private Button btnReports;
        private PictureBox navbarProfilePic;
        private Button btnUsername;
        private dashboard dashboard1;
        private dashboard dashboard2;
        private login login1;
    }
}

