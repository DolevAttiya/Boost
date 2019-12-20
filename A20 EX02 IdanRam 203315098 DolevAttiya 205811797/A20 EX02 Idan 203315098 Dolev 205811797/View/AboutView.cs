using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class AboutView : UserControl
    {

        private string m_ResourceName = "About";

        #region Ctor
        public AboutView()
        {
            InitializeComponent();
            displayAboutContent();
        }

        private void displayAboutContent()
        {
            this.labelVersion.Text = string.Format(@"Version: {0}",BoostEngine.r_CurrentVersion);
            UITools.displayHTMLPage(this.webBrowser1, m_ResourceName);
        }
        #endregion
    }
}
