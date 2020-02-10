using System;
using System.Threading;
using System.Windows.Forms;
using Boost.Model;

namespace Boost.ViewModels
{
    public delegate void PostLoginEventHandler();

    public delegate void LoginErrorEventHandler();

    public delegate void LoginFinishedEventHandler();

    public class BoostViewModel
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        public PostLoginEventHandler m_PostLoginEvent;
        public LoginErrorEventHandler m_LoginErrorEvent;
        public LoginFinishedEventHandler m_LoginFinishedEvent;
        private object m_PostLoginLock = new object();

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
            ThreadStart loginThreadStart = new ThreadStart(() =>
            {
                try
                {
                    r_BoostEn.FacebookLogin(r_BoostEn.m_BoostSettings.LastAccessToken, r_BoostEn.m_BoostSettings.RememberUser);
                }
                catch (Exception)
                {
                    m_LoginErrorEvent.Invoke();
                }
            });

            loginThreadStart += initiatePostLoginOperations;

            Thread loginThread = new Thread(loginThreadStart);

            loginThread.SetApartmentState(ApartmentState.STA);

            loginThread.Start();
        }

        private void initiatePostLoginOperations()
        {
            bool isTheUserLoggedIn = r_BoostEn.LoggedInUser != null;
            if (isTheUserLoggedIn)
            {
                if (isTheUserLoggedIn)
                {
                    ThreadStart postLoginThreadStart = new ThreadStart(() => m_PostLoginEvent.Invoke());

                    postLoginThreadStart += () => m_LoginFinishedEvent.Invoke();

                    new Thread(postLoginThreadStart).Start();
                }
            }
        }
    }
}