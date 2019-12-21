using System.Drawing;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    partial class Settings
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
            System.Windows.Forms.Label defaultAnalyticsTimeFrameLabel;
            System.Windows.Forms.Label rememberUserLabel;
            this.boostSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultAnalyticsTimeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.rememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.labelSettings = new System.Windows.Forms.Label();
            defaultAnalyticsTimeFrameLabel = new System.Windows.Forms.Label();
            rememberUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boostSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultAnalyticsTimeFrameLabel
            // 
            defaultAnalyticsTimeFrameLabel.AutoSize = true;
            defaultAnalyticsTimeFrameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalyticsTimeFrameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            defaultAnalyticsTimeFrameLabel.Location = new System.Drawing.Point(55, 84);
            defaultAnalyticsTimeFrameLabel.Name = "defaultAnalyticsTimeFrameLabel";
            defaultAnalyticsTimeFrameLabel.Size = new System.Drawing.Size(201, 16);
            defaultAnalyticsTimeFrameLabel.TabIndex = 7;
            defaultAnalyticsTimeFrameLabel.Text = "Default Analytics Time Frame:";
            // 
            // rememberUserLabel
            // 
            rememberUserLabel.AutoSize = true;
            rememberUserLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rememberUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            rememberUserLabel.Location = new System.Drawing.Point(55, 121);
            rememberUserLabel.Name = "rememberUserLabel";
            rememberUserLabel.Size = new System.Drawing.Size(113, 16);
            rememberUserLabel.TabIndex = 9;
            rememberUserLabel.Text = "Remember User:";
            // 
            // boostSettingsBindingSource
            // 
            this.boostSettingsBindingSource.DataSource = typeof(A20_EX02_Idan_203315098_Dolev_205811797.Model.BoostSettings);
            // 
            // defaultAnalyticsTimeFrameComboBox
            // 
            this.defaultAnalyticsTimeFrameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boostSettingsBindingSource, "DefaultAnalyticsTimeFrame", true));
            this.defaultAnalyticsTimeFrameComboBox.DataSource = this.boostSettingsBindingSource;
            this.defaultAnalyticsTimeFrameComboBox.DisplayMember = "DefaultAnalyticsTimeFrame";
            this.defaultAnalyticsTimeFrameComboBox.FormattingEnabled = true;
            this.defaultAnalyticsTimeFrameComboBox.Location = new System.Drawing.Point(271, 83);
            this.defaultAnalyticsTimeFrameComboBox.Name = "defaultAnalyticsTimeFrameComboBox";
            this.defaultAnalyticsTimeFrameComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultAnalyticsTimeFrameComboBox.TabIndex = 8;
            // 
            // rememberUserCheckBox
            // 
            this.rememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.boostSettingsBindingSource, "RememberUser", true));
            this.rememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.boostSettingsBindingSource, "RememberUser", true));
            this.rememberUserCheckBox.Location = new System.Drawing.Point(271, 118);
            this.rememberUserCheckBox.Name = "rememberUserCheckBox";
            this.rememberUserCheckBox.Size = new System.Drawing.Size(121, 24);
            this.rememberUserCheckBox.TabIndex = 10;
            this.rememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.labelSettings.Location = new System.Drawing.Point(18, 17);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(100, 28);
            this.labelSettings.TabIndex = 11;
            this.labelSettings.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 176);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(defaultAnalyticsTimeFrameLabel);
            this.Controls.Add(this.defaultAnalyticsTimeFrameComboBox);
            this.Controls.Add(rememberUserLabel);
            this.Controls.Add(this.rememberUserCheckBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 215);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.boostSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSettings;
        public System.Windows.Forms.BindingSource boostSettingsBindingSource;
        public System.Windows.Forms.ComboBox defaultAnalyticsTimeFrameComboBox;
        public System.Windows.Forms.CheckBox rememberUserCheckBox;
    }
}