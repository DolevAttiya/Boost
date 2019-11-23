namespace A20_EX01_Idan_203315098_Dolev_205811797
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
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelPlaceholder.Location = new System.Drawing.Point(3, 4);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelPlaceholder.Size = new System.Drawing.Size(230, 39);
            this.labelPlaceholder.TabIndex = 1;
            this.labelPlaceholder.Text = "Placeholder1";
            // 
            // BestTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelPlaceholder);
            this.Name = "BestTimes";
            this.Size = new System.Drawing.Size(1000, 430);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceholder;
    }
}
