using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Navbar : UserControl
    {
        #region Data Members
        public List<Button> m_NavbarButtons = new List<Button>();
        #endregion

        #region Ctor
        public Navbar()
        {
            InitializeComponent();
            setupNavbarButtons();
        }
        #endregion

        #region Methods
        private void setupNavbarButtons()
        {
            int startX = 135;
            int X = startX;
            // int Y = 20;
            int Y = 0;
            int buttonWidth = 135;
            //int buttonHeight = 32;
            int buttonHeight = this.Height;
            int buttonSpacing = 0;

            foreach(Boost.eBoostPages page in Enum.GetValues(typeof(Boost.eBoostPages)))
            {
                Button button = new Button();
                button.BackColor = Color.Transparent;
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Stylesheet.Color_NavbarRollover;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = Stylesheet.Font_NavbarButtonDefault;
                button.ForeColor = Stylesheet.Color_NavbarButtonColor;
                button.Location = new Point(X, Y);
                button.Margin = new Padding(2, 3, 2, 3);
                button.Name = "btn" + page.ToString();
                button.Size = new Size(buttonWidth, buttonHeight);
                button.TabIndex = (byte)page + 2;
                button.Text = page.ToString().ToUpper();
                button.UseVisualStyleBackColor = false;
                this.Controls.Add(button);
                m_NavbarButtons.Add(button);

                X += buttonWidth + buttonSpacing;
            }
        }

        public void SelectButton(Button i_Button)
        {
            foreach(Button button in m_NavbarButtons)
            {
                setButtonStyleToDefault(button);
            }
            i_Button.BackColor = Stylesheet.Color_Secondary;
            i_Button.FlatAppearance.MouseDownBackColor = Stylesheet.Color_Secondary;
            i_Button.ForeColor = Color.White;

        }

        private void setButtonStyleToDefault(Button i_Button)
        {
            i_Button.BackColor = Color.Transparent;
            i_Button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            i_Button.ForeColor = Stylesheet.Color_NavbarButtonColor;

        }
        #endregion
    }
}
