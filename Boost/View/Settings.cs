using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boost.Model;
using Boost.Model.DataClasses;

namespace Boost.View
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            populateControls();
        }

        private void populateControls()
        {
            List<eTimeFrame> analysisTimeFrames = BoostEngine.Instance.GetAnalysisTimeFrames();
            List<eAnalysisDataBasis> analysisDataBases = BoostEngine.Instance.GetAnalysisDataBases();

            DefaultAnalysisTimeFrameComboBox.DataSource = analysisTimeFrames;
            DefaultAnalysisDataBasisComboBox.DataSource = analysisDataBases;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Any changes will take effect once Boost restarts.");
            Close();
        }
    }
}
