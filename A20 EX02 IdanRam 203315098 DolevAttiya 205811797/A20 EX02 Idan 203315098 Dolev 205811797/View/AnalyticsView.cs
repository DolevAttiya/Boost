using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory;

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
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
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
            panelAnalytics.Visible = false;
            LabelError.Visible = true;
        }

        private void analyticsInitialSetup()
        {
            BackColor = System.Drawing.Color.Transparent;
            panelAnalytics.GradientColorA = Stylesheet.Color_PanelColorA;
            panelAnalytics.GradientColorB = Stylesheet.Color_PanelColorB;
            panelAnalytics.GradientAngle = 90F;
            BestTimesPage.BringToFront();
            buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            buttonBiggestFans.BackColor = Stylesheet.Color_Main;
            buttonBestTimes.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            buttonBiggestFans.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            labelAnalytics.Font = Stylesheet.Font_Header1;

            addButtonsToLists();
            addSubPagesToList();
        }

        private void ButtonBestTimes_Click(object sender, EventArgs e)
        {
            BestTimesPage.BringToFront();
            buttonBestTimes.BackColor = Stylesheet.Color_Secondary;
            buttonBiggestFans.BackColor = Stylesheet.Color_Main;
        }

        private void ButtonBiggestFans_Click(object sender, EventArgs e)
        {
            BiggestFansPage.BringToFront();
            buttonBiggestFans.BackColor = Stylesheet.Color_Secondary;
            buttonBestTimes.BackColor = Stylesheet.Color_Main;
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
            
            AnalyticsTabButtons.Add(buttonBestTimes);
            AnalyticsTabButtons.Add(buttonBiggestFans);

            AnalysisBasisButtons.Add(buttonCombined);
            AnalysisBasisButtons.Add(buttonStatus);
            AnalysisBasisButtons.Add(buttonPhotos);
            AnalysisBasisButtons.Add(buttonVideos);
            
            AnalysisTimeFrameButtons.Add(buttonWeek);
            AnalysisTimeFrameButtons.Add(buttonMonth);
            AnalysisTimeFrameButtons.Add(buttonYear);
        }

        private void addSubPagesToList()
        {
            AnalyticsSubPages = new List<UserControl>();

            AnalyticsSubPages.Add(BestTimesPage);
            AnalyticsSubPages.Add(BiggestFansPage);
        }

        public void FetchAndDisplayData()
        {
            try
            {
                m_AnalysisSettingsEvent += r_BoostEn.SaveAnalysisSettings;
                ///BestTimes
                new Thread(new ThreadStart(() => { BestTimesPage.DrawBestTimesGrid(r_BoostEn.m_BoostSettings.DefaultAnalysisTimeFrame, r_BoostEn.m_BoostSettings.DefaultAnalysisDataBasis); })).Start();

                ///BiggestFans
                Invoke(new Action(() => BiggestFansPage.DisplayBiggestFans(r_BoostEn.m_BoostSettings.DefaultAnalysisTimeFrame, r_BoostEn.m_BoostSettings.DefaultAnalysisDataBasis)));

                foreach (Button button in AnalysisTimeFrameButtons)
                {
                    if (button.Text == r_BoostEn.m_BoostSettings.DefaultAnalysisTimeFrame.ToString())
                    {
                        SelectButton(button, AnalysisTimeFrameButtons);
                        break;
                    }
                }

                foreach (Button button in AnalysisBasisButtons)
                {
                    if (button.Text == r_BoostEn.m_BoostSettings.DefaultAnalysisDataBasis.ToString())
                    {
                        SelectButton(button, AnalysisBasisButtons);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                DisplayAnalyticsErrorMessage();
            }
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
                    if(i_Tab.Name.Contains("Time"))
                    {
                        r_BoostEn.m_AnalysisFactory= new TimeAnalysiserFactory();
                    }
                    else
                    {
                        r_BoostEn.m_AnalysisFactory = new BiggestFanAnalysiserFactory();
                    }

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

        private void switchAnalysisBasis(Button i_Button)
        {
            SelectButton(i_Button, AnalysisBasisButtons);
            Enum.TryParse(i_Button.Text, out r_BoostEn.m_CurrentAnalysisDataBasis);
            reanalyzeAll(r_BoostEn.m_CurrentAnalysisTimeFrame, r_BoostEn.m_CurrentAnalysisDataBasis);
        }

        private void switchAnalysisTimeFrame(Button i_Button)
        {
            SelectButton(i_Button, AnalysisTimeFrameButtons);
            Enum.TryParse(i_Button.Text, out r_BoostEn.m_CurrentAnalysisTimeFrame);
            reanalyzeAll(r_BoostEn.m_CurrentAnalysisTimeFrame, r_BoostEn.m_CurrentAnalysisDataBasis);

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
