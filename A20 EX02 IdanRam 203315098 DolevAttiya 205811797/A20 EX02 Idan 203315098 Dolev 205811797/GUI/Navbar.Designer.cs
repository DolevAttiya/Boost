using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.GUI
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
            this.BtnUsername = new System.Windows.Forms.Button();
            this.NavbarProfilePic = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // btnUsername
            // 
            this.BtnUsername.BackColor = System.Drawing.Color.Transparent;
            //this.btnUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsername.FlatAppearance.BorderSize = 0;
            this.BtnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsername.Font = Stylesheet.Font_NavbarButtonDefault;
            this.BtnUsername.ForeColor = Stylesheet.Color_NavbarButtonColor;
            this.BtnUsername.Location = new System.Drawing.Point(880, 20);
            this.BtnUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUsername.Name = "btnUsername";
            this.BtnUsername.Size = new System.Drawing.Size(104, 32);
            this.BtnUsername.TabIndex = 11;
            this.BtnUsername.Text = "John Doe";
            this.BtnUsername.UseVisualStyleBackColor = false;
            // 
            // navbarProfilePic
            // 
            this.NavbarProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.NavbarProfilePic.Location = new System.Drawing.Point(990, 20);
            this.NavbarProfilePic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NavbarProfilePic.Name = "navbarProfilePic";
            this.NavbarProfilePic.Size = new System.Drawing.Size(31, 32);
            this.NavbarProfilePic.TabIndex = 10;
            this.NavbarProfilePic.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.Logo_navbar;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Location = new System.Drawing.Point(1, 16);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LogoPictureBox.Name = "logoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(94, 32);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // Navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Navbar";
            this.Size = new System.Drawing.Size(1023, 65);
            this.Controls.Add(this.BtnUsername);
            this.Controls.Add(this.NavbarProfilePic);
            this.Controls.Add(this.LogoPictureBox);
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox LogoPictureBox;
        public PictureBox NavbarProfilePic;
        public Button BtnUsername;
    }
}
