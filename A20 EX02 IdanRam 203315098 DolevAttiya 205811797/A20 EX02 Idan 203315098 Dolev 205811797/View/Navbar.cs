using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.ViewModels;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void UsernameButtonEventHandler();

    public partial class Navbar : UserControl
    {
        #region Data Members
        private const int k_ButtonLimit = 5;
        public List<Button> m_NavbarButtons = new List<Button>();
        public UsernameButtonEventHandler m_UsernameButtonEvent;
        private bool m_UsernameSelected = false;
        private NavbarViewModel m_NavbarViewModel = new NavbarViewModel();
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
            int Y = 0;
            int buttonWidth = 135;
            int buttonHeight = this.Height;
            int buttonSpacing = 0;

            int numOfBoostPages = Enum.GetNames(typeof(Boost.eBoostPages)).Length;

            try
            {
                if (numOfBoostPages <= k_ButtonLimit)
                {
                    foreach (Boost.eBoostPages page in Enum.GetValues(typeof(Boost.eBoostPages)))
                    {
                        Button button = new Button();

                        button.Cursor = Cursors.Hand;
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Font = Stylesheet.Font_NavbarButtonDefault;
                        button.Location = new Point(X, Y);
                        button.Margin = new Padding(2, 3, 2, 3);
                        button.Name = "btn" + page.ToString();
                        button.Size = new Size(buttonWidth, buttonHeight);
                        button.TabIndex = (byte)page + 2;
                        button.Text = page.ToString().ToUpper();
                        button.UseVisualStyleBackColor = false;
                        this.Controls.Add(button);
                        m_NavbarButtons.Add(button);
                        SetButtonStyleToDefault(button);

                        X += buttonWidth + buttonSpacing;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SelectButton(Button i_Button)
        {
            if (i_Button != BtnUsername)
            {
                foreach (Button button in m_NavbarButtons)
                {
                    SetButtonStyleToDefault(button);
                }

                i_Button.BackColor = Stylesheet.Color_NavbarSelected;
                i_Button.ForeColor = Color.Black;
            }
            else
            {
                BtnUsername.Focus();
                m_UsernameSelected = true;
                i_Button.BackColor = Stylesheet.Color_Main;
                i_Button.ForeColor = Color.White;
            }
        }

        public void SetButtonStyleToDefault(Button i_Button)
        {
            i_Button.BackColor = Color.Transparent;
            i_Button.ForeColor = Stylesheet.Color_NavbarButtonColor;
        }

        public void DeselectBtnUsername()
        {
            SetButtonStyleToDefault(BtnUsername);
            m_UsernameSelected = false;
        }

        public void FetchAndDisplayData()
        {
            m_NavbarViewModel.FetchData();
            DisplayData();
        }

        public void DisplayData()
        {
            BtnUsername.Text = m_NavbarViewModel.UserRealName;
            NavbarProfilePic.LoadAsync(m_NavbarViewModel.PictureSmallURL);
            NavbarProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void BtnUsername_Click(object sender, EventArgs e)
        {
            UsernameClick();
        }

        public void UsernameClick()
        {
            if (m_UsernameSelected == false)
            {
                SelectButton(BtnUsername);
            }
            else
            {
                DeselectBtnUsername();
            }

            if(m_UsernameButtonEvent != null)
            {
                m_UsernameButtonEvent.Invoke();
            }
        }
        #endregion
    }
}
