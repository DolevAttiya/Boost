using System.Windows.Forms;

namespace Boost.View
{
    public partial class WhatsNew : Form
    {
        private string m_ResourceName = "WhatsNew";

        public WhatsNew()
        {
            InitializeComponent();
            UITools.displayHTMLPage(webBrowserWhatsNew, m_ResourceName);
        }
    }
}
