using System.Drawing;
using A20_EX02_Idan_203315098_Dolev_205811797.View.UI_Controls;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label defaultAnalysisTimeFrameLabel;
            System.Windows.Forms.Label rememberUserLabel;
            System.Windows.Forms.Label defaultAnalysisDataBasisLabel;
            this.BoostSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DefaultAnalysisTimeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.RememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.DefaultAnalysisDataBasisComboBox = new System.Windows.Forms.ComboBox();
            defaultAnalysisTimeFrameLabel = new System.Windows.Forms.Label();
            rememberUserLabel = new System.Windows.Forms.Label();
            defaultAnalysisDataBasisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoostSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultAnalysisTimeFrameLabel
            // 
            defaultAnalysisTimeFrameLabel.AutoSize = true;
            defaultAnalysisTimeFrameLabel.BackColor = System.Drawing.Color.Transparent;
            defaultAnalysisTimeFrameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalysisTimeFrameLabel.ForeColor = System.Drawing.Color.White;
            defaultAnalysisTimeFrameLabel.Location = new System.Drawing.Point(50, 101);
            defaultAnalysisTimeFrameLabel.Name = "defaultAnalysisTimeFrameLabel";
            defaultAnalysisTimeFrameLabel.Size = new System.Drawing.Size(195, 16);
            defaultAnalysisTimeFrameLabel.TabIndex = 7;
            defaultAnalysisTimeFrameLabel.Text = "Default Analysis Time Frame:";
            // 
            // rememberUserLabel
            // 
            rememberUserLabel.AutoSize = true;
            rememberUserLabel.BackColor = System.Drawing.Color.Transparent;
            rememberUserLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rememberUserLabel.ForeColor = System.Drawing.Color.White;
            rememberUserLabel.Location = new System.Drawing.Point(50, 69);
            rememberUserLabel.Name = "rememberUserLabel";
            rememberUserLabel.Size = new System.Drawing.Size(113, 16);
            rememberUserLabel.TabIndex = 9;
            rememberUserLabel.Text = "Remember User:";
            // 
            // defaultAnalysisDataBasisLabel
            // 
            defaultAnalysisDataBasisLabel.AutoSize = true;
            defaultAnalysisDataBasisLabel.BackColor = System.Drawing.Color.Transparent;
            defaultAnalysisDataBasisLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalysisDataBasisLabel.ForeColor = System.Drawing.Color.White;
            defaultAnalysisDataBasisLabel.Location = new System.Drawing.Point(50, 133);
            defaultAnalysisDataBasisLabel.Name = "defaultAnalysisDataBasisLabel";
            defaultAnalysisDataBasisLabel.Size = new System.Drawing.Size(189, 16);
            defaultAnalysisDataBasisLabel.TabIndex = 13;
            defaultAnalysisDataBasisLabel.Text = "Default Analysis Data Basis:";
            // 
            // BoostSettingsBindingSource
            // 
            this.BoostSettingsBindingSource.DataSource = typeof(A20_EX02_Idan_203315098_Dolev_205811797.Model.BoostSettings);
            // 
            // DefaultAnalysisTimeFrameComboBox
            // 
            this.DefaultAnalysisTimeFrameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BoostSettingsBindingSource, "DefaultAnalysisTimeFrame", true));
            this.DefaultAnalysisTimeFrameComboBox.DataSource = this.BoostSettingsBindingSource;
            this.DefaultAnalysisTimeFrameComboBox.DisplayMember = "DefaultAnalysisTimeFrame";
            this.DefaultAnalysisTimeFrameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultAnalysisTimeFrameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.DefaultAnalysisTimeFrameComboBox.FormattingEnabled = true;
            this.DefaultAnalysisTimeFrameComboBox.Location = new System.Drawing.Point(266, 100);
            this.DefaultAnalysisTimeFrameComboBox.Name = "DefaultAnalysisTimeFrameComboBox";
            this.DefaultAnalysisTimeFrameComboBox.Size = new System.Drawing.Size(121, 21);
            this.DefaultAnalysisTimeFrameComboBox.TabIndex = 8;
            // 
            // RememberUserCheckBox
            // 
            this.RememberUserCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BoostSettingsBindingSource, "RememberUser", true));
            this.RememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BoostSettingsBindingSource, "RememberUser", true));
            this.RememberUserCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberUserCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.RememberUserCheckBox.Location = new System.Drawing.Point(266, 66);
            this.RememberUserCheckBox.Name = "RememberUserCheckBox";
            this.RememberUserCheckBox.Size = new System.Drawing.Size(121, 24);
            this.RememberUserCheckBox.TabIndex = 10;
            this.RememberUserCheckBox.UseVisualStyleBackColor = false;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.White;
            this.labelSettings.Location = new System.Drawing.Point(18, 14);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(100, 28);
            this.labelSettings.TabIndex = 11;
            this.labelSettings.Text = "Settings";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(178, 178);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 41);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DefaultAnalysisDataBasisComboBox
            // 
            this.DefaultAnalysisDataBasisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BoostSettingsBindingSource, "DefaultAnalysisDataBasis", true));
            this.DefaultAnalysisDataBasisComboBox.DataSource = this.BoostSettingsBindingSource;
            this.DefaultAnalysisDataBasisComboBox.DisplayMember = "DefaultAnalysisDataBasis";
            this.DefaultAnalysisDataBasisComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultAnalysisDataBasisComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.DefaultAnalysisDataBasisComboBox.FormattingEnabled = true;
            this.DefaultAnalysisDataBasisComboBox.Location = new System.Drawing.Point(266, 131);
            this.DefaultAnalysisDataBasisComboBox.Name = "DefaultAnalysisDataBasisComboBox";
            this.DefaultAnalysisDataBasisComboBox.Size = new System.Drawing.Size(121, 21);
            this.DefaultAnalysisDataBasisComboBox.TabIndex = 14;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.BackgroundImage = global::A20_EX02_Idan_203315098_Dolev_205811797.Properties.Resources.LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 241);
            this.ControlBox = false;
            this.Controls.Add(defaultAnalysisDataBasisLabel);
            this.Controls.Add(this.DefaultAnalysisDataBasisComboBox);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(defaultAnalysisTimeFrameLabel);
            this.Controls.Add(this.DefaultAnalysisTimeFrameComboBox);
            this.Controls.Add(rememberUserLabel);
            this.Controls.Add(this.RememberUserCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.BoostSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.BindingSource BoostSettingsBindingSource;
        public System.Windows.Forms.ComboBox DefaultAnalysisTimeFrameComboBox;
        public System.Windows.Forms.CheckBox RememberUserCheckBox;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.ComboBox DefaultAnalysisDataBasisComboBox;
    }
}