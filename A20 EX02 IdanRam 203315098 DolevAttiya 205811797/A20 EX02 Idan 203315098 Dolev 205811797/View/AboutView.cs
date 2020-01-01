using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class AboutView : UserControl
    {
        private string m_ResourceName = "About";
        private WebBrowser m_WebBrowser; // default null

        #region Ctor
        public AboutView()
        {
            InitializeComponent();
            m_WebBrowser = initializeAboutPageWebBrowser();
            displayAboutContent();
        }

        private void displayAboutContent()
        {
            labelVersion.Text = $@"Version: {BoostEngine.r_CurrentVersion}";
            UITools.displayHTMLPage(m_WebBrowser, m_ResourceName);
        }

        private WebBrowser initializeAboutPageWebBrowser()
        {
            WebBrowser browser = new WebBrowser
                                     {
                                         Location = new System.Drawing.Point(6, 93),
                                         Name = "webBrowserAboutPage",
                                         Size = new System.Drawing.Size(1004, 415),
                                         TabIndex = 2
                                     };

            Controls.Add(browser);

            return browser;
        }
        #endregion
    }
}
