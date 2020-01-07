using System;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void SaveSettingEventHandler();
    
    public partial class Settings : Form
    {
        public SaveSettingEventHandler m_SaveSettingEvent;

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
