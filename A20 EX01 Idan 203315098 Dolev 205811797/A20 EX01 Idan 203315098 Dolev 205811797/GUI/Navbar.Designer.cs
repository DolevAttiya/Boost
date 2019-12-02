using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Navbar
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
            this.btnUsername = new System.Windows.Forms.Button();
            this.navbarProfilePic = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // btnUsername
            // 
            this.btnUsername.BackColor = System.Drawing.Color.Transparent;
            //this.btnUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsername.FlatAppearance.BorderSize = 0;
            this.btnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsername.Font = Stylesheet.font_NavbarButtonDefault;
            this.btnUsername.ForeColor = Stylesheet.color_NavbarButtonColor;
            this.btnUsername.Location = new System.Drawing.Point(880, 20);
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
            this.navbarProfilePic.Location = new System.Drawing.Point(990, 20);
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
            this.logoPictureBox.Location = new System.Drawing.Point(1, 16);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(94, 32);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // Navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Navbar";
            this.Size = new System.Drawing.Size(1023, 65);
            this.Controls.Add(this.btnUsername);
            this.Controls.Add(this.navbarProfilePic);
            this.Controls.Add(this.logoPictureBox);
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox logoPictureBox;
        public PictureBox navbarProfilePic;
        public Button btnUsername;
    }
}
