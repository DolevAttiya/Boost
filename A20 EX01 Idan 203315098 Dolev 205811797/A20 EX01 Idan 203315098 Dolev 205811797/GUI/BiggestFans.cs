using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class BiggestFans : UserControl
    {
        public BiggestFans()
        {
            InitializeComponent();
        }

        public void PopulateBiggestFans(BiggestFanAnalysis i_BiggestFanAnalysis, User i_User)
        {
            i_BiggestFanAnalysis.CreateAnalysisByTimeFrame(i_User, eTimeSelector.Year);

            int numOfBiggestFans = i_BiggestFanAnalysis.CombinedAnalysisHolders.Count;

        }
    }
}
