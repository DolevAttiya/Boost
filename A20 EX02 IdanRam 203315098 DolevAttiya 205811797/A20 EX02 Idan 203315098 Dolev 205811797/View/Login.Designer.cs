namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class Login
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
            this.CheckBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.LabelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelLoginError = new System.Windows.Forms.Label();
            this.PictureBoxFBLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxRememberUser
            // 
            this.CheckBoxRememberUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxRememberUser.AutoSize = true;
            this.CheckBoxRememberUser.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxRememberUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxRememberUser.ForeColor = System.Drawing.Color.White;
            this.CheckBoxRememberUser.Location = new System.Drawing.Point(516, 369);
            this.CheckBoxRememberUser.Name = "CheckBoxRememberUser";
            this.CheckBoxRememberUser.Size = new System.Drawing.Size(121, 21);
            this.CheckBoxRememberUser.TabIndex = 4;
            this.CheckBoxRememberUser.Text = "Remember Me";
            this.CheckBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // LabelLoading
            // 
            this.LabelLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoading.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoading.ForeColor = System.Drawing.Color.White;
            this.LabelLoading.Location = new System.Drawing.Point(488, 407);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Size = new System.Drawing.Size(177, 26);
            this.LabelLoading.TabIndex = 3;
            this.LabelLoading.Text = "Loading...";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLoading.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_login;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(441, 194);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(271, 97);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // LabelLoginError
            // 
            this.LabelLoginError.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoginError.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginError.ForeColor = System.Drawing.Color.Red;
            this.LabelLoginError.Location = new System.Drawing.Point(406, 446);
            this.LabelLoginError.Name = "LabelLoginError";
            this.LabelLoginError.Size = new System.Drawing.Size(329, 26);
            this.LabelLoginError.TabIndex = 2;
            this.LabelLoginError.Text = "LOGIN FAILED! PLEASE TRY AGAIN!";
            this.LabelLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLoginError.Visible = false;
            // 
            // PictureBoxFBLogin
            // 
            this.PictureBoxFBLogin.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxFBLogin.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.fbLogin;
            this.PictureBoxFBLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxFBLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxFBLogin.Location = new System.Drawing.Point(488, 319);
            this.PictureBoxFBLogin.Name = "PictureBoxFBLogin";
            this.PictureBoxFBLogin.Size = new System.Drawing.Size(177, 36);
            this.PictureBoxFBLogin.TabIndex = 1;
            this.PictureBoxFBLogin.TabStop = false;
            this.PictureBoxFBLogin.Click += new System.EventHandler(this.PictureBoxFBLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.CheckBoxRememberUser);
            this.Controls.Add(this.LabelLoading);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.LabelLoginError);
            this.Controls.Add(this.PictureBoxFBLogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1151, 677);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.Label LabelLoginError;
        public System.Windows.Forms.Label LabelLoading;
        public System.Windows.Forms.PictureBox PictureBoxFBLogin;
        public System.Windows.Forms.CheckBox CheckBoxRememberUser;
    }
}
