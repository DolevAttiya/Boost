using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Properties;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{

    public partial class WhatsNew : Form
    {
        private string m_ResourceName = "WhatsNew";
        public WhatsNew()
        {
            InitializeComponent();
            UITools.displayHTMLPage(this.webBrowserWhatsNew, m_ResourceName);
        }

    }
}
