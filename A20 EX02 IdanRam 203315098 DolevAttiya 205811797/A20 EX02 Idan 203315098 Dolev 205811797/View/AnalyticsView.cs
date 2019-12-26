using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void SaveAnalysisSettingsEventHandler();
    
    public partial class AnalyticsView : UserControl
    {
        #region Properties

        public List<Button> AnalysisBasisButtons { get; set; }

        public List<Button> AnalyticsTabButtons { get; set; }

        public List<UserControl> AnalyticsSubPages { get; set; }

        public Button m_SelectedAnalysisBasisButton = null;

        public SaveAnalysisSettingsEventHandler m_AnalysisSettingsEvent;
        #endregion

        #region Ctor
        public AnalyticsView()
        {
            InitializeComponent();
            analyticsInitialSetup();
        }
        #endregion

        #region Methods

        public void DisplayAnalyticsErrorMessage()
        {
            this.panelAnalytics.Visible = false;
            this.LabelError.Visible = true;
        }

        private void analyticsInitialSetup()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.panelAnalytics.GradientColorA = Stylesheet.Color_PanelColorA;
            this.panelAnalytics.GradientColorB = Stylesheet.Color_PanelColorB;
            this.panelAnalytics.GradientAngle = 90F;
            this.BestTimesPage.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Main;
            this.buttonBestTimes.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            this.buttonBiggestFans.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            this.labelAnalytics.Font = Stylesheet.Font_Header1;

            populateComboBoxes();
            addButtonsToLists();
            addSubPagesToList();
        }


        private void populateComboBoxes()
        {
            List<eTimeSelector> analysisTimeFrames = BoostEngine.Instance.GetAnalysisTimeFrames();

            foreach(eTimeSelector timeFrame in analysisTimeFrames)
            {
                TimeFrameComboBox.Items.Add(timeFrame.ToString());
            }
        }

        private void ButtonBestTimes_Click(object sender, EventArgs e)
        {
            this.BestTimesPage.BringToFront();
            this.buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Main;
        }

        private void ButtonBiggestFans_Click(object sender, EventArgs e)
        {
            this.BiggestFansPage.BringToFront();
            this.buttonBiggestFans.BackColor = Stylesheet.Color_Secondary;
            this.buttonBestTimes.BackColor = Stylesheet.Color_Main;
        }

        private void analysisTab_Click(object sender, EventArgs e)
        {
            switchAnalysisTab((Button)sender);
        }

        private void analysisBasis_Click(object sender, EventArgs e)
        {
            switchAnalysisBasis((Button)sender);
        }

        private void addButtonsToLists() // TODO - better way with reflection?
        {
            AnalyticsTabButtons = new List<Button>();
            AnalysisBasisButtons = new List<Button>();
            
            AnalyticsTabButtons.Add(this.buttonBestTimes);
            AnalyticsTabButtons.Add(this.buttonBiggestFans);
            AnalysisBasisButtons.Add(this.buttonCombined);
            AnalysisBasisButtons.Add(this.buttonStatus);
            AnalysisBasisButtons.Add(this.buttonPhotos);
            AnalysisBasisButtons.Add(this.buttonVideos);
        }

        private void addSubPagesToList()
        {
            AnalyticsSubPages = new List<UserControl>();

            AnalyticsSubPages.Add(BestTimesPage);
            AnalyticsSubPages.Add(BiggestFansPage);
        }

        public void SelectButton(Button i_Button, List<Button> i_RelevantButtonList)
        {
            foreach(Button button in i_RelevantButtonList)
            {
                button.BackColor = Stylesheet.Color_Main;
            }
            
            i_Button.BackColor = Stylesheet.Color_Secondary;
        }

        private void switchAnalysisTab(Button i_Tab)
        {
            bool tabSwitched = false;

            SelectButton(i_Tab, AnalyticsTabButtons);

            foreach(UserControl subPage in AnalyticsSubPages)
            {
                if("button" + subPage.Name == i_Tab.Name + "Page")
                {
                    subPage.BringToFront();
                    tabSwitched = true;
                    break;
                }
            }

            if(!tabSwitched)
            {
                throw new Exception("Sub-page could not be found");
            }

        }

        // TODO
        private void switchAnalysisBasis(Button i_Button)
        {
            SelectButton(i_Button, AnalysisBasisButtons);
            m_SelectedAnalysisBasisButton = i_Button;

            switch(i_Button.Name)
            {
                case "Combined":
                    break;
                case "Status":
                    break;
                case "Photos":
                    break;
                case "Videos":
                    break;
            }
        }


        #endregion

        private void buttonReanalyze_Click(object sender, EventArgs e)
        {
            // DO SOMETHING
        }

        private void buttonSaveToDefaults_Click(object sender, EventArgs e)
        {
            if(m_AnalysisSettingsEvent != null)
            {
                try
                {
                    m_AnalysisSettingsEvent.Invoke();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                MessageBox.Show(@"Analysis default settings saved.");
            }
        }
    }
}
