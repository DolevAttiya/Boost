using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            List<eTimeSelector> timeSelectorEnumVals = new List<eTimeSelector>();
            List<Analysis.eAnalysisDataBasis> analysisDataBasisEnumVals = new List<Analysis.eAnalysisDataBasis>();

            foreach (eTimeSelector val in Enum.GetValues(typeof(eTimeSelector)))
            {
                timeSelectorEnumVals.Add(val);
            }

            foreach (Analysis.eAnalysisDataBasis val in Enum.GetValues(typeof(Analysis.eAnalysisDataBasis)))
            {
                analysisDataBasisEnumVals.Add(val);
            }

            DefaultAnalysisTimeFrameComboBox.DataSource = timeSelectorEnumVals;
            DefaultAnalysisDataBasisComboBox.DataSource = analysisDataBasisEnumVals;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
