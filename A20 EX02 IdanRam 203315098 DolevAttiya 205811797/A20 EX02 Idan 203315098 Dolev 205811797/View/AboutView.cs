using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class AboutView : UserControl
    {
        private string m_ResourceName = "About";
        private WebBrowser m_WebBrowser = null;

        #region Ctor
        public AboutView()
        {
            InitializeComponent();
            m_WebBrowser = initializeAboutPageWebBrowser();
            displayAboutContent();
        }

        private void displayAboutContent()
        {
            this.labelVersion.Text = string.Format(@"Version: {0}", BoostEngine.R_CurrentVersion);
            UITools.displayHTMLPage(m_WebBrowser, m_ResourceName);
        }

        private WebBrowser initializeAboutPageWebBrowser()
        {
            WebBrowser browser = new WebBrowser();

            browser.Location = new System.Drawing.Point(6, 93);
            browser.Name = "webBrowserAboutPage";
            browser.Size = new System.Drawing.Size(1004, 415);
            browser.TabIndex = 2;
            this.Controls.Add(browser);

            return browser;
        }
        #endregion
    }
}
