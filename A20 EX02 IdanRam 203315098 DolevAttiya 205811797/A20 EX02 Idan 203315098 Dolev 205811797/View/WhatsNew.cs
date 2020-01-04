using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
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
