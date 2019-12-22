using System.Drawing;

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
            System.Windows.Forms.Label defaultAnalyticsTimeFrameLabel;
            System.Windows.Forms.Label rememberUserLabel;
            this.BoostSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DefaultAnalyticsTimeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.RememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            defaultAnalyticsTimeFrameLabel = new System.Windows.Forms.Label();
            rememberUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoostSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultAnalyticsTimeFrameLabel
            // 
            defaultAnalyticsTimeFrameLabel.AutoSize = true;
            defaultAnalyticsTimeFrameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultAnalyticsTimeFrameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            defaultAnalyticsTimeFrameLabel.Location = new System.Drawing.Point(55, 80);
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
            rememberUserLabel.Location = new System.Drawing.Point(55, 117);
            rememberUserLabel.Name = "rememberUserLabel";
            rememberUserLabel.Size = new System.Drawing.Size(113, 16);
            rememberUserLabel.TabIndex = 9;
            rememberUserLabel.Text = "Remember User:";
            // 
            // BoostSettingsBindingSource
            // 
            this.BoostSettingsBindingSource.DataSource = typeof(A20_EX02_Idan_203315098_Dolev_205811797.Model.BoostSettings);
            // 
            // DefaultAnalyticsTimeFrameComboBox
            // 
            this.DefaultAnalyticsTimeFrameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BoostSettingsBindingSource, "DefaultAnalyticsTimeFrame", true));
            this.DefaultAnalyticsTimeFrameComboBox.DataSource = this.BoostSettingsBindingSource;
            this.DefaultAnalyticsTimeFrameComboBox.DisplayMember = "DefaultAnalyticsTimeFrame";
            this.DefaultAnalyticsTimeFrameComboBox.FormattingEnabled = true;
            this.DefaultAnalyticsTimeFrameComboBox.Location = new System.Drawing.Point(271, 79);
            this.DefaultAnalyticsTimeFrameComboBox.Name = "DefaultAnalyticsTimeFrameComboBox";
            this.DefaultAnalyticsTimeFrameComboBox.Size = new System.Drawing.Size(121, 21);
            this.DefaultAnalyticsTimeFrameComboBox.TabIndex = 8;
            // 
            // RememberUserCheckBox
            // 
            this.RememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BoostSettingsBindingSource, "RememberUser", true));
            this.RememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BoostSettingsBindingSource, "RememberUser", true));
            this.RememberUserCheckBox.Location = new System.Drawing.Point(271, 114);
            this.RememberUserCheckBox.Name = "RememberUserCheckBox";
            this.RememberUserCheckBox.Size = new System.Drawing.Size(121, 24);
            this.RememberUserCheckBox.TabIndex = 10;
            this.RememberUserCheckBox.UseVisualStyleBackColor = true;
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
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(176, 165);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 40);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(defaultAnalyticsTimeFrameLabel);
            this.Controls.Add(this.DefaultAnalyticsTimeFrameComboBox);
            this.Controls.Add(rememberUserLabel);
            this.Controls.Add(this.RememberUserCheckBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.BackColor = Stylesheet.Color_BGColorA;
            ((System.ComponentModel.ISupportInitialize)(this.BoostSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.BindingSource BoostSettingsBindingSource;
        public System.Windows.Forms.ComboBox DefaultAnalyticsTimeFrameComboBox;
        public System.Windows.Forms.CheckBox RememberUserCheckBox;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Button buttonOK;
    }
}