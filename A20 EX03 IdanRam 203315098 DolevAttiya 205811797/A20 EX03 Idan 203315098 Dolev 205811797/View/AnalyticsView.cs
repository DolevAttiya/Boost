using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;
using A20_EX03_Idan_203315098_Dolev_205811797.ViewModels;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
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

        public Button m_SelectedAnalysisTimeFrameButton;

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

            reanalyzingOverlay.BackColor = Color.Transparent;
            m_AnalyticsViewModel.m_AnalysisFinishedEvent += reanalyzingOverlay.AnalysisFinishedNotification;

            AnalyticsTabButtons = new List<Button>();
            AnalysisBasisButtons = new List<Button>();
            AnalysisTimeFrameButtons = new List<Button>();
            AnalyticsSubPages = new List<UserControl>();

            addButtonsToLists();
            this.addSubPagesToList(AnalyticsSubPages, field => !field.FieldType.Name.Contains("View"));
        }

        private void analysisTab_Click(object sender, EventArgs e)
        {
            switchAnalysisTab((Button)sender);
        }

        private void analysisElementButton_Click(object sender, EventArgs e)
        {
            switchAnalysisElements((Button)sender);
        }


        private void addButtonsToLists()
        {
            foreach(FieldInfo field in this.GetType().GetFields())
            {
                if(field.FieldType != typeof(Button))
                {
                    continue;
                }

                if(!field.Name.StartsWith("Button"))
                {
                    continue;
                }

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

        public void SelectButton(Button i_Button, List<Button> i_ButtonList)
        {
            foreach(Button button in i_ButtonList)
            {
                button.BackColor = Stylesheet.Color_Main;
            }

            if (i_Button.Name.Contains("Basis"))
            {
                m_SelectedAnalysisBasisButton = i_Button;
            }
            else
            {
                m_SelectedAnalysisTimeFrameButton = i_Button;
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
                    Type analysisType;

                    if (i_Tab.Name.Contains("Time"))
                    {
                        analysisType = typeof(TimeAnalysisFactory);
                    }
                    else
                    {
                        analysisType = typeof(BiggestFanAnalysisFactory);
                    }

                    r_BoostEn.SelectAnalysisFactoryType(analysisType);

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

        private void switchAnalysisElements(Button i_Button)
        {
            List<Button> buttonList;

            if (i_Button != m_SelectedAnalysisTimeFrameButton && i_Button != m_SelectedAnalysisBasisButton)
            {
                if(i_Button.Name.Contains("Basis"))
                {
                    buttonList = AnalysisBasisButtons;
                }
                else
                {
                    buttonList = AnalysisTimeFrameButtons;
                }

                SelectButton(i_Button, buttonList);
                reanalyzingOverlay.BringToFront();
                reanalyzingOverlay.AnimatePanel();
                if (buttonList.Count > 0)
                {
                    if (buttonList[0].Name.Contains("Basis"))
                    {
                        Enum.TryParse(i_Button.Text, out r_BoostEn.m_CurrentAnalysisDataBasis);
                    }
                    else
                    {
                        Enum.TryParse(i_Button.Text, out r_BoostEn.m_CurrentAnalysisTimeFrame);
                    }

                    m_AnalyticsViewModel.Analyze(r_BoostEn.m_CurrentAnalysisTimeFrame, r_BoostEn.m_CurrentAnalysisDataBasis, m_SelectedAnalysisTab);
                }
                else
                {
                    throw new Exception("Button list is empty!");
                }
            }
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
