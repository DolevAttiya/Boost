﻿using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            List<eTimeSelector> enumVals = new List<eTimeSelector>();

            foreach (eTimeSelector m in Enum.GetValues(typeof(eTimeSelector)))
            {
                enumVals.Add(m);
            }

            defaultAnalyticsTimeFrameComboBox.DataSource = enumVals;
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
