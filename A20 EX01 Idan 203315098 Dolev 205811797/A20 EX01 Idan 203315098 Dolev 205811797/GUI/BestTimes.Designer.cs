namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    partial class BestTimes
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
            this.labelHighColor = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelMedium = new System.Windows.Forms.Label();
            this.labelMediumColor = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelLowColor = new System.Windows.Forms.Label();
            this.labelLikeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHighColor
            // 
            this.labelHighColor.BackColor = UI_Elements.color_BestTimesHigh;
            this.labelHighColor.Location = new System.Drawing.Point(99, 12);
            this.labelHighColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHighColor.Name = "labelHighColor";
            this.labelHighColor.Size = new System.Drawing.Size(35, 13);
            this.labelHighColor.TabIndex = 0;
            this.labelHighColor.Text = " ";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.BackColor = System.Drawing.Color.Transparent;
            this.labelHigh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHigh.Location = new System.Drawing.Point(138, 10);
            this.labelHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(38, 16);
            this.labelHigh.TabIndex = 1;
            this.labelHigh.Text = "High";
            // 
            // labelMedium
            // 
            this.labelMedium.AutoSize = true;
            this.labelMedium.BackColor = System.Drawing.Color.Transparent;
            this.labelMedium.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedium.Location = new System.Drawing.Point(229, 11);
            this.labelMedium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMedium.Name = "labelMedium";
            this.labelMedium.Size = new System.Drawing.Size(61, 16);
            this.labelMedium.TabIndex = 3;
            this.labelMedium.Text = "Medium";
            // 
            // labelMediumColor
            // 
            this.labelMediumColor.BackColor = UI_Elements.color_BestTimesMedium;
            this.labelMediumColor.Location = new System.Drawing.Point(190, 13);
            this.labelMediumColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMediumColor.Name = "labelMediumColor";
            this.labelMediumColor.Size = new System.Drawing.Size(35, 13);
            this.labelMediumColor.TabIndex = 2;
            this.labelMediumColor.Text = " ";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.BackColor = System.Drawing.Color.Transparent;
            this.labelLow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLow.Location = new System.Drawing.Point(339, 12);
            this.labelLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(32, 16);
            this.labelLow.TabIndex = 5;
            this.labelLow.Text = "Low";
            // 
            // labelLowColor
            // 
            this.labelLowColor.BackColor = UI_Elements.color_BestTimesLow;
            this.labelLowColor.Location = new System.Drawing.Point(300, 14);
            this.labelLowColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLowColor.Name = "labelLowColor";
            this.labelLowColor.Size = new System.Drawing.Size(35, 13);
            this.labelLowColor.TabIndex = 4;
            this.labelLowColor.Text = " ";
            // 
            // labelLikeCount
            // 
            this.labelLikeCount.AutoSize = true;
            this.labelLikeCount.BackColor = System.Drawing.Color.Transparent;
            this.labelLikeCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeCount.Location = new System.Drawing.Point(11, 11);
            this.labelLikeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikeCount.Name = "labelLikeCount";
            this.labelLikeCount.Size = new System.Drawing.Size(78, 16);
            this.labelLikeCount.TabIndex = 6;
            this.labelLikeCount.Text = "Like count:";
            // 
            // BestTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelLikeCount);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelLowColor);
            this.Controls.Add(this.labelMedium);
            this.Controls.Add(this.labelMediumColor);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelHighColor);
            this.Name = "BestTimes";
            this.Size = new System.Drawing.Size(1000, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighColor;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelMedium;
        private System.Windows.Forms.Label labelMediumColor;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelLowColor;
        private System.Windows.Forms.Label labelLikeCount;
    }
}
