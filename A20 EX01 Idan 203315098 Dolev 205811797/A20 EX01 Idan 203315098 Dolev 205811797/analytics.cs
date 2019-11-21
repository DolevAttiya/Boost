using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Analytics : UserControl
    {
        public Analytics()
        {
            InitializeComponent();
            analyticsSetup();
        }

        private void analyticsSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
