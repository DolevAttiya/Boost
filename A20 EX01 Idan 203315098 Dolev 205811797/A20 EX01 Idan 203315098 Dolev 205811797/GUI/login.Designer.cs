﻿namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    partial class Login
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
            this.labelLoginError = new System.Windows.Forms.Label();
            this.gradientBG = new A20_EX01_Idan_203315098_Dolev_205811797.GUI.GradientPanel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxFBLogin = new System.Windows.Forms.PictureBox();
            this.gradientBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginError
            // 
            this.labelLoginError.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginError.Font = UI_Elements.font_Header2;
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(441, 379);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(271, 26);
            this.labelLoginError.TabIndex = 2;
            this.labelLoginError.Text = "LOGIN FAILED! PLEASE TRY AGAIN!";
            this.labelLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoginError.Visible = false;
            // 
            // gradientBG
            // 
            this.gradientBG.GradientAngle = 45F;
            this.gradientBG.Controls.Add(this.labelLoading);
            this.gradientBG.Controls.Add(this.pictureBoxLogo);
            this.gradientBG.Controls.Add(this.labelLoginError);
            this.gradientBG.Controls.Add(this.pictureBoxFBLogin);
            this.gradientBG.GradientColorA = UI_Elements.color_Main;
            this.gradientBG.GradientColorB = UI_Elements.color_Tertiary;
            this.gradientBG.Location = new System.Drawing.Point(0, 0);
            this.gradientBG.Name = "gradientBG";
            this.gradientBG.Size = new System.Drawing.Size(1148, 677);
            this.gradientBG.TabIndex = 4;
            // 
            // labelLoading
            // 
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(488, 379);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(177, 26);
            this.labelLoading.TabIndex = 3;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_login;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(441, 194);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(271, 97);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxFBLogin
            // 
            this.pictureBoxFBLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFBLogin.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.fbLogin;
            this.pictureBoxFBLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFBLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFBLogin.Location = new System.Drawing.Point(488, 319);
            this.pictureBoxFBLogin.Name = "pictureBoxFBLogin";
            this.pictureBoxFBLogin.Size = new System.Drawing.Size(177, 36);
            this.pictureBoxFBLogin.TabIndex = 1;
            this.pictureBoxFBLogin.TabStop = false;
            this.pictureBoxFBLogin.Click += new System.EventHandler(this.PictureBoxFBLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.gradientBG);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1151, 677);
            this.gradientBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.Label labelLoginError;
        public System.Windows.Forms.Label labelLoading;
        public System.Windows.Forms.PictureBox pictureBoxFBLogin;
        private GUI.GradientPanel gradientBG;
    }
}
