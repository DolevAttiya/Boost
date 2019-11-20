using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class Boost : Form
    {
        public Boost()
        {
            InitializeComponent();
            dashboard1.BringToFront();
            login1.BringToFront();
            UI_Elements.initializerAddons(this);
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            analytics1.BringToFront();
        }
    }
}
