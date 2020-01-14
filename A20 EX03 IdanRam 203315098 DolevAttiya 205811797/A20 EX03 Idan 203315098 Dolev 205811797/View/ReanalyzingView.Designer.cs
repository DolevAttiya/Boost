using System.Drawing;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class ReanalyzingView
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
            this.components = new System.ComponentModel.Container();
            this.panelReanalyzing = new System.Windows.Forms.Panel();
            this.labelReanalyzing = new System.Windows.Forms.Label();
            this.timerReanalyzing = new System.Windows.Forms.Timer(this.components);
            this.timerReanalyzingOut = new System.Windows.Forms.Timer(this.components);
            this.panelReanalyzing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReanalyzing
            // 
            this.panelReanalyzing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelReanalyzing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.panelReanalyzing.Controls.Add(this.labelReanalyzing);
            this.panelReanalyzing.Location = new System.Drawing.Point(0, 0);
            this.panelReanalyzing.Name = "panelReanalyzing";
            this.panelReanalyzing.Size = new System.Drawing.Size(1005, 434);
            this.panelReanalyzing.TabIndex = 0;
            // 
            // labelReanalyzing
            // 
            this.labelReanalyzing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReanalyzing.AutoSize = true;
            this.labelReanalyzing.BackColor = System.Drawing.Color.Transparent;
            this.labelReanalyzing.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReanalyzing.ForeColor = System.Drawing.Color.White;
            this.labelReanalyzing.Location = new System.Drawing.Point(391, 197);
            this.labelReanalyzing.Name = "labelReanalyzing";
            this.labelReanalyzing.Size = new System.Drawing.Size(175, 28);
            this.labelReanalyzing.TabIndex = 0;
            this.labelReanalyzing.Text = "Reanalyzing...";
            this.labelReanalyzing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerReanalyzingIn
            // 
            this.timerReanalyzing.Tick += new System.EventHandler(this.timerReanalyzing_Tick);
            //
            // ReanalyzingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.Transparent;
            this.Controls.Add(this.panelReanalyzing);
            this.MaximumSize = new System.Drawing.Size(1005, 434);
            this.MinimumSize = new System.Drawing.Size(1005, 434);
            this.Name = "ReanalyzingView";
            this.Size = new System.Drawing.Size(1005, 434);
            this.panelReanalyzing.ResumeLayout(false);
            this.panelReanalyzing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReanalyzing;
        private System.Windows.Forms.Label labelReanalyzing;
        private System.Windows.Forms.Timer timerReanalyzing;
        private System.Windows.Forms.Timer timerReanalyzingOut;
    }
}
