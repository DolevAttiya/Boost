using System;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
{
    public delegate void PostLoginEventHandler();

    public delegate void LoginErrorEventHandler();

    public class BoostViewModel
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        public PostLoginEventHandler m_PostLoginEvent;
        public LoginErrorEventHandler m_LoginErrorEvent;

        public bool PreInitialLogin { get; set; }

        public BoostViewModel()
        {
            PreInitialLogin = true;
        }

        public void FacebookLogout()
        {
            try
            {
                r_BoostEn.FacebookLogout();
                r_BoostEn.m_BoostSettings.ResetSettingsToDefault();
                r_BoostEn.m_BoostSettings.DeleteAppSettingsFile();
                r_BoostEn.m_BoostSettings = BoostSettings.LoadAppSettingsFromFile();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Logout failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void FacebookLogin()
        {
            try
            {
                r_BoostEn.FacebookLogin(r_BoostEn.m_BoostSettings.LastAccessToken, r_BoostEn.m_BoostSettings.RememberUser);
            }
            catch (Exception)
            {
                m_LoginErrorEvent.Invoke();
            }

            bool isTheUserLoggedIn = r_BoostEn.LoggedInUser != null;
            if (isTheUserLoggedIn)
            {
                m_PostLoginEvent.Invoke();
            }
        }
    }
}