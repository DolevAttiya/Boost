using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;
using A20_EX03_Idan_203315098_Dolev_205811797.ViewModels;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{
    public partial class Boost : Form
    {
        #region Data Members

        private readonly BoostEngine r_BoostEn;
        private Settings m_SettingsPopup; // default null
        private List<UserControl> m_BoostPages = new List<UserControl>();
        private BoostViewModel m_BoostViewModel = new BoostViewModel();

        public enum eBoostPages : byte
        {
            Dashboard = 0,
            Analytics,
            About
        }
        #endregion

        #region Ctor
        public Boost()
        {
            r_BoostEn = BoostEngine.Instance;
            m_BoostViewModel.PreInitialLogin = true;
            InitializeComponent();
            boostFormInitialSetup();
            addMethodsToEvents();
        }

        private void addMethodsToEvents()
        {
            m_BoostViewModel.m_LoginErrorEvent += LoginPage.DisplayLoginErrorMessage;

            m_BoostViewModel.m_PostLoginEvent += setupAndLoad;

            //m_BoostViewModel.m_PostLoginEvent += LoginPage.HideLoginPage;
            m_BoostViewModel.m_LoginFinishedEvent += LoginPage.HideLoginPage;

            LoginPage.m_LoginEvent += m_BoostViewModel.FacebookLogin;

            LoginPage.m_ContinueAsEvent += m_BoostViewModel.FacebookLogin;

            LoginPage.m_SwitchUserEvent += m_BoostViewModel.FacebookLogout;
            LoginPage.m_SwitchUserEvent += LoginPage.UpdateLoginPage;

            userOptions.m_LogoutEvent += m_BoostViewModel.FacebookLogout;
            userOptions.m_LogoutEvent += boostFormInitialSetup;
            userOptions.m_LogoutEvent += LoginPage.LoginPageSetup;

            userOptions.m_SettingsEvent += displaySettingsPopup;
            userOptions.m_OptionClickEvent += navbar.DeselectBtnUsername;
        }
        #endregion

        #region Methods
        private void boostFormInitialSetup()
        {
            if(m_BoostViewModel.PreInitialLogin)
            {
                // Add event handler to dynamically added buttons
                foreach(Button button in navbar.m_NavbarButtons)
                {
                    button.Click += NavbarButton_Click;
                }

                navbar.m_UsernameButtonEvent += toggleUserOptionPanel;

                // Boost Frame properties
                MaximizeBox = false;
                MinimizeBox = true;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                Margin = new Padding(0, 0, 0, 0);
                BackColor = Stylesheet.Color_BGColorA;
            }

            //// Adjust UI before login
            // Clear Charts
            foreach(Series series in DashboardPage.ChartEngagement.Series)
            {
                series.Points.Clear();
            }

            foreach (Series series in DashboardPage.ChartFriends.Series)
            {
                series.Points.Clear();
            }

            // Sort elements at app startup
            NavbarSeparator.BringToFront();
            this.addSubPagesToList(m_BoostPages, field => !field.FieldType.Name.Contains("View"));
            switchPage(navbar.m_NavbarButtons[0]); // Switch to the 1st button's page (App home page)
            navbar.SetButtonStyleToDefault(navbar.BtnUsername);
            userOptions.Visible = false;
            userOptions.AdjustUserOptionsSize();
            userOptions.Location = new System.Drawing.Point(
                navbar.BtnUsername.Right - userOptions.Width + navbar.Location.X,
                navbar.BtnUsername.Bottom);
            LoginPage.UpdateLoginPage();
        }

        private void initializeSettingsPopUp()
        {
            m_SettingsPopup = new Settings();
            m_SettingsPopup.BoostSettingsBindingSource.DataSource = r_BoostEn.m_BoostSettings;
        }

        private void toggleUserOptionPanel()
        {
            userOptions.BringToFront();
            userOptions.Visible = !userOptions.Visible; // Toggle visibility
        }

        private void Boost_FormClosing(object sender, FormClosingEventArgs e)
        {
            r_BoostEn.m_BoostSettings.SaveAppSettingsToFile();
        }

        public void NavbarButton_Click(object sender, EventArgs e)
        {
            switchPage((Button)sender);
        }

        private void switchPage(Button i_Button)
        {
            foreach (Button button in navbar.m_NavbarButtons)
            {
                navbar.SetButtonStyleToDefault(button);
            }

            navbar.SelectButton(i_Button);

            switchPage_Reflection(i_Button);

            if (userOptions.Visible)
            {
                navbar.UsernameClick();
            }
        }

        private List<Type> getBoostViewTypes()
        {
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();
            List<Type> boostViews = new List<Type>();
            string keyWord = "View";

            foreach(Type type in allTypes)
            {
                if(type.Name != null && type.Name.Contains(keyWord))
                {
                    boostViews.Add(type);
                }
            }

            return boostViews;
        }

        private void switchPage_Reflection(Button i_Button)
        {
            string[] keyword = { "Page" };
            List<Type> viewTypes = getBoostViewTypes();
            Type buttonType = null;
            bool pageSwitched = false;

            foreach(Type type in viewTypes)
            {
                if("btn" + type.Name == i_Button.Name + "View")
                {
                    buttonType = type;
                    break;
                }
            }

            foreach(UserControl page in m_BoostPages)
            {
                if (page.GetType().Name == buttonType.Name)
                {
                    page.BringToFront();
                    pageSwitched = true;
                    break;
                }
            }

            if(!pageSwitched)
            {
                throw new Exception("Desired page could not be found in m_BoostPages");
            }
        }

        private void setupAndLoad()
        {
            try
            {
                if (m_BoostViewModel.PreInitialLogin)
                {
                    m_BoostViewModel.PreInitialLogin = false;
                }

                // Identify Login (Email as ID + First login)
                r_BoostEn.m_BoostSettings.IsFirstLogin(r_BoostEn.LoggedInUser.Email);

                Invoke(new Action(
                    () =>
                        {
                            // Fetch and load data
                            FetchAndDisplayUserData();
                            initializeSettingsPopUp();
                            displayWhatsNewPopup();
                            r_BoostEn.OverwriteBoostSettings();
                        }));
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void displayWhatsNewPopup()
        {
            if (r_BoostEn.m_BoostSettings.LastUsedVersion != BoostEngine.SR_CurrentVersion)
            {
                WhatsNew whatsNew = new WhatsNew { Visible = true };
            }
        }

        private void displaySettingsPopup()
        {
            initializeSettingsPopUp();
            m_SettingsPopup.ShowDialog();
        }

        public void FetchAndDisplayUserData()
        {
            DashboardPage.SetupFetchAndDisplay();
            navbar.FetchAndDisplayData();
            AnalyticsPage.FetchAndDisplayData();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(!r_BoostEn.m_BoostSettings.RememberUser)
            {
                m_BoostViewModel.FacebookLogout();
            }

            base.OnFormClosing(e);
        }

        #endregion
    }
}