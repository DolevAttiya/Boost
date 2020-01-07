using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.ViewModels;
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

        public Button m_SelectedAnalysisBasisButton;

        public Button m_SelectedAnalysisTab;

        public SaveAnalysisSettingsEventHandler m_AnalysisSettingsEvent;

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        private AnalyticsViewModel m_AnalyticsViewModel = new AnalyticsViewModel();
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
            ButtonTabBestTimes.BackColor = Stylesheet.Color_Secondary;
            ButtonTabBiggestFans.BackColor = Stylesheet.Color_Main;
            ButtonTabBestTimes.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            ButtonTabBiggestFans.FlatAppearance.MouseOverBackColor = Stylesheet.Color_ButtonRollover;
            labelAnalytics.Font = Stylesheet.Font_Header1;
            m_SelectedAnalysisTab = ButtonTabBestTimes;

            m_AnalyticsViewModel.m_BestTimesEvent += BestTimesPage.DrawBestTimesGrid;
            m_AnalyticsViewModel.m_BiggestFansEvent += BiggestFansPage.DisplayBiggestFans;

            addButtonsToLists();
            addSubPagesToList();
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

            foreach(FieldInfo field in this.GetType().GetFields())
            {
                if(field.FieldType == typeof(Button))
                {
                    if(field.Name.StartsWith("Button"))
                    {
                        if (field.Name.Contains("Tab"))
                        {
                            AnalyticsTabButtons.Add((Button)field.GetValue(this));
                        }
                        else if(field.Name.Contains("Basis"))
                        {
                            AnalysisBasisButtons.Add((Button)field.GetValue(this));
                        }
                        else if(field.Name.Contains("TimeFrame"))
                        {
                            AnalysisTimeFrameButtons.Add((Button)field.GetValue(this));
                        }
                    }
                }
            }
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
                m_AnalyticsViewModel.Analyze(r_BoostEn.m_BoostSettings.DefaultAnalysisTimeFrame, r_BoostEn.m_BoostSettings.DefaultAnalysisDataBasis, m_SelectedAnalysisTab);

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

            string tabName = i_Tab.Name.Split(new[] { "Tab" }, StringSplitOptions.None)[1];

            foreach(UserControl subPage in AnalyticsSubPages)
            {
                string subPageName = subPage.Name.Split(new[] { "Page" }, StringSplitOptions.None)[0];

                if (subPageName == tabName)
                {
                    if(i_Tab.Name.Contains("Time"))
                    {
                        r_BoostEn.m_AnalysisFactory = new TimeAnalysisFactory();
                    }
                    else
                    {
                        r_BoostEn.m_AnalysisFactory = new BiggestFanAnalysisFactory();
                    }

                    subPage.BringToFront();
                    tabSwitched = true;
                    m_SelectedAnalysisTab = i_Tab;
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
            m_AnalyticsViewModel.Analyze(r_BoostEn.m_CurrentAnalysisTimeFrame, r_BoostEn.m_CurrentAnalysisDataBasis, m_SelectedAnalysisTab);
        }

        private void switchAnalysisTimeFrame(Button i_Button)
        {
            SelectButton(i_Button, AnalysisTimeFrameButtons);
            Enum.TryParse(i_Button.Text, out r_BoostEn.m_CurrentAnalysisTimeFrame);
            m_AnalyticsViewModel.Analyze(r_BoostEn.m_CurrentAnalysisTimeFrame, r_BoostEn.m_CurrentAnalysisDataBasis, m_SelectedAnalysisTab);
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
