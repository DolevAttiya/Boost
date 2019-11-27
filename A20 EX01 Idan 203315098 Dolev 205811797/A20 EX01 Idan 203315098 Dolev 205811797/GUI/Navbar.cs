using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class Navbar : UserControl
    {

        public List<Button> m_NavbarButtons = new List<Button>();
        public Navbar()
        {
            InitializeComponent();
            setupNavbarButtons();
        }

        private void setupNavbarButtons()
        {
            int startX = 120;
            int X = startX;
            int Y = 20;
            int buttonWidth = 120;
            int buttonHeight = 32;
            int buttonSpacing = 10;

            foreach(Boost.eBoostPages page in Enum.GetValues(typeof(Boost.eBoostPages)))
            {
                Button button = new Button();
                button.BackColor = System.Drawing.Color.Transparent;
                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = UI_Elements.color_NavbarRollover;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = UI_Elements.font_NavbarButtonDefault;
                button.ForeColor = UI_Elements.color_NavbarButtonColor;
                button.Location = new System.Drawing.Point(X, Y);
                button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                button.Name = "btn" + page.ToString();
                button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                button.TabIndex = (byte)page+2;
                button.Text = page.ToString().ToUpper();
                button.UseVisualStyleBackColor = false;
                this.Controls.Add(button);
                m_NavbarButtons.Add(button);

                X += buttonWidth + buttonSpacing;
            }
            
        }
    }
}
