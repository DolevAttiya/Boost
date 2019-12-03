namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class WelcomeScreen
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
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.WelcomeScreen_StartDefault;
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStart.Location = new System.Drawing.Point(954, 865);
            this.pictureBoxStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(360, 123);
            this.pictureBoxStart.TabIndex = 0;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.PictureBoxStart_Click);
            this.pictureBoxStart.MouseEnter += new System.EventHandler(this.PictureBoxStart_MouseEnter);
            this.pictureBoxStart.MouseLeave += new System.EventHandler(this.PictureBoxStart_MouseLeave);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A20_EX01_Idan_203315098_Dolev_205811797.Properties.Resources.WelcomeScreen_v4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pictureBoxStart);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WelcomeScreen";
            this.Size = new System.Drawing.Size(2270, 1227);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStart;
    }
}
