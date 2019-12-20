using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{

    public delegate void LogoutEventHandler();
    public delegate void SettingsEventHandler();

    public partial class UserOptions : UserControl
    {
        private List<Button> m_UserOptionButtons = new List<Button>();
        private const int k_ButtonWidth = 200;
        private const int k_ButtonHeight = 40;
        public LogoutEventHandler m_LogoutEvent;
        public SettingsEventHandler m_SettingsEvent;

        public UserOptions()
        {
            InitializeComponent();
            initializeUserOptionButtons();
        }

        private enum eUserOptions : byte //in reverse order
        {
            Settings,
            Logout
        }

        private void initializeUserOptionButtons()
        {
            int startY = 0;
            int Y = startY;
            int tabIndex = 0;

            foreach(eUserOptions option in Enum.GetValues(typeof(eUserOptions)))
            {
                Button button = new Button();
                button.AutoSize = true;
                button.Dock = System.Windows.Forms.DockStyle.Bottom;
                button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = this.BackColor;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = Stylesheet.Font_NavbarButtonDefault;
                button.ForeColor = System.Drawing.Color.White;
                button.Location = new System.Drawing.Point(0, Y);
                button.Margin = new System.Windows.Forms.Padding(0);
                button.Name = "btn" + option.ToString();
                button.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
                button.Size = new System.Drawing.Size(k_ButtonWidth, k_ButtonHeight);
                button.TabIndex = tabIndex++;
                button.Text = option.ToString();
                button.UseVisualStyleBackColor = true;
                button.Cursor = Cursors.Hand;
                this.Controls.Add(button);
                m_UserOptionButtons.Add(button);
                button.Click += new EventHandler(UserOptionButton_Click);

                Y += k_ButtonHeight;
            }
        }

        public void UserOptionButton_Click(object sender, EventArgs e)
        {
            selectUserOption((Button)sender);
        }

        public void AdjustUserOptionsSize()
        {
            this.Size = new Size(k_ButtonWidth, ((k_ButtonHeight+3) * m_UserOptionButtons.Count));
        }

        private void selectUserOption(Button i_Button) 
        {
            switch (i_Button.Name)
            {
                case "btnSettings":
                    {
                       // m_SettingsEvent.Invoke();
                        break;
                    }
                case "btnLogout":
                    {
                        DialogResult result = MessageBox.Show(@"Are you sure you want to logout?

(Logging out would delete any locally saved settings and cached data from your machine)", "Logout",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            m_LogoutEvent.Invoke(); // TODO SINGLETON
                        }
                        break;
                    }
            }
        }

    }
}
