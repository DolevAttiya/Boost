using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            List<eTimeSelector> analysisTimeFrames = BoostEngine.Instance.GetAnalysisTimeFrames();
            List<eAnalysisDataBasis> analysisDataBases = BoostEngine.Instance.GetAnalysisDataBases();

            DefaultAnalysisTimeFrameComboBox.DataSource = analysisTimeFrames;
            DefaultAnalysisDataBasisComboBox.DataSource = analysisDataBases;
        }

        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }*/

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Any changes will take effect once Boost restarts.");
            Close();
        }
    }
}
