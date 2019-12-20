namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    partial class WhatsNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelWhatsNew = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "What\'s New";
            // 
            // panelWhatsNew
            // 
            this.panelWhatsNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWhatsNew.Location = new System.Drawing.Point(0, 92);
            this.panelWhatsNew.Name = "panelWhatsNew";
            this.panelWhatsNew.Size = new System.Drawing.Size(1614, 782);
            this.panelWhatsNew.TabIndex = 1;
            // 
            // WhatsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 874);
            this.Controls.Add(this.panelWhatsNew);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WhatsNew";
            this.Text = "WhatsNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelWhatsNew;
    }
}