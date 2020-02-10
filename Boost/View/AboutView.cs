using System.Windows.Forms;
using Boost.Model;

namespace Boost.View
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
        #endregion

        #region Methods
        private void displayAboutContent()
        {
            labelVersion.Text = $@"Version: {BoostEngine.SR_CurrentVersion}";
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
