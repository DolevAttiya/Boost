using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public delegate void SaveAnalysisSettingsEventHandler();
    public partial class AnalyticsView : UserControl
    {
        #region Properties

        public List<Button> AnalysisBasisButtons { get; set; }

        public List<Button> AnalysisTimeFrameButtons { get; set; }

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

            addButtonsToLists();
            addSubPagesToList();
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
        
        private void analysisTimeFrame_Click(object sender, EventArgs e)
        {
            switchAnalysisTimeFrame((Button)sender);
        }

        private void addButtonsToLists() // TODO - better way with reflection?
        {
            AnalyticsTabButtons = new List<Button>();
            AnalysisBasisButtons = new List<Button>();
            AnalysisTimeFrameButtons = new List<Button>();
            
            AnalyticsTabButtons.Add(this.buttonBestTimes);
            AnalyticsTabButtons.Add(this.buttonBiggestFans);

            AnalysisBasisButtons.Add(this.buttonCombined);
            AnalysisBasisButtons.Add(this.buttonStatus);
            AnalysisBasisButtons.Add(this.buttonPhotos);
            AnalysisBasisButtons.Add(this.buttonVideos);
            
            AnalysisTimeFrameButtons.Add(this.buttonWeek);
            AnalysisTimeFrameButtons.Add(this.buttonMonth);
            AnalysisTimeFrameButtons.Add(this.buttonYear);
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
            eTimeSelector timeFrame = BoostEngine.Instance.m_CurrentAnalysisTimeFrame;

            switch(i_Button.Text)
            {
                case "Combined":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisDataBasis = eAnalysisDataBasis.Combined;
                        break;
                    }
                case "Status":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisDataBasis = eAnalysisDataBasis.Status;
                        break;
                    }
                case "Photos":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisDataBasis = eAnalysisDataBasis.Photo;
                        break;
                    }
                case "Videos":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisDataBasis = eAnalysisDataBasis.Video;
                        break;
                    }
            }
            reanalyzeAll(timeFrame, BoostEngine.Instance.m_CurrentAnalysisDataBasis);
        }

        private void switchAnalysisTimeFrame(Button i_Button)
        {
            SelectButton(i_Button, AnalysisTimeFrameButtons);
            eAnalysisDataBasis dataBasis = BoostEngine.Instance.m_CurrentAnalysisDataBasis;

            switch (i_Button.Text)
            {
                case "Week":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisTimeFrame = eTimeSelector.Week;
                        break;
                    }
                case "Month":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisTimeFrame = eTimeSelector.Month;
                        break;
                    }
                case "Year":
                    {
                        BoostEngine.Instance.m_CurrentAnalysisTimeFrame = eTimeSelector.Year;
                        break;
                    }
            }
            reanalyzeAll(BoostEngine.Instance.m_CurrentAnalysisTimeFrame, dataBasis);
        }


        private void reanalyzeAll(eTimeSelector i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            new Thread(new ThreadStart(() => BestTimesPage.DrawBestTimesGrid(i_TimeFrame, i_AnalysisDataBasis)));
            new Thread(new ThreadStart(() => BiggestFansPage.DisplayBiggestFans(i_TimeFrame, i_AnalysisDataBasis)));
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
        #endregion
    }
}
