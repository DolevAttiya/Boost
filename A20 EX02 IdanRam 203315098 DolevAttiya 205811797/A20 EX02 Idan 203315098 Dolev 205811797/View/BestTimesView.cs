using System;
using System.Drawing;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.ViewModels;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public partial class BestTimesView : UserControl
    {
        #region Data Members
        private static readonly int sk_NumOfDays = 7; // TODO read only / const ?
        private static readonly int sk_NumOfHours = 24; // TODO read only / const ?
        private readonly int k_GridAreaHeight; // TODO read only / const ?
        private readonly int k_GridAreaWidth; // TODO read only / const ?
        private int k_CellWidth; // TODO read only / const ?
        private int k_CellHeight; // TODO read only / const ?
        public int[,] m_BestPostTimes = new int[sk_NumOfDays, sk_NumOfHours]; // TODO 
        public Label[,] m_BestTimesGrid = new Label[sk_NumOfDays + 1, sk_NumOfHours + 1];
        private BestTimesViewModel m_BestTimesViewModel = new BestTimesViewModel();
        private eTimeSelector m_LastUsedTimeSelector = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisTimeFrame;
        private eAnalysisDataBasis m_LastUsedDataBasis = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisDataBasis;
        private bool m_FirstDrawing = true;
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        #endregion

        #region Ctor
        public BestTimesView()
        {
            InitializeComponent();
            k_GridAreaHeight = Size.Height - 40;
            k_GridAreaWidth = Size.Width - 100;
        }
        #endregion

        #region Methods
        public void DrawBestTimesGrid(eTimeSelector i_TimeSelector = eTimeSelector.Month, eAnalysisDataBasis i_AnalysisDataBasis = eAnalysisDataBasis.Combined) 
        {
            k_CellHeight = k_GridAreaHeight / (sk_NumOfDays + 1);
            k_CellWidth = k_GridAreaWidth / (sk_NumOfHours + 1);
            const int k_StartX = 5;
            const int k_StartY = 45;
            int labelX = k_StartX;
            int labelY = k_StartY;
            int lastHeight = 0;
            int widthExpansion = 35;
            int currentValue = 0;

            if(m_FirstDrawing)
            {
                m_BestTimesViewModel.CreateTimeAnalysis(BoostEngine.Instance.LoggedInUser, i_TimeSelector, i_AnalysisDataBasis);
                m_LastUsedTimeSelector = i_TimeSelector;
                m_LastUsedDataBasis = i_AnalysisDataBasis;
            }
            else
            {
                if(i_TimeSelector == m_LastUsedTimeSelector && m_BestTimesViewModel.TimeAnalysis != null)
                {
                    if(i_AnalysisDataBasis != m_LastUsedDataBasis)
                    {
                        m_BestTimesViewModel.SelectAnalysisCollection(m_BestTimesViewModel.TimeAnalysis, i_AnalysisDataBasis);
                        m_LastUsedDataBasis = i_AnalysisDataBasis;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    m_BestTimesViewModel.CreateTimeAnalysis(BoostEngine.Instance.LoggedInUser, i_TimeSelector, i_AnalysisDataBasis);
                    m_LastUsedTimeSelector = i_TimeSelector;
                    m_LastUsedDataBasis = i_AnalysisDataBasis;
                }
            }

            for(int i = 0; i <= sk_NumOfDays; i++)
            {
                for(int j = 0; j <= sk_NumOfHours; j++)
                {
                    int dayInt = i;
                    DayAndHour currentDayAndHour = new DayAndHour(
                        (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), dayInt - 1),
                        TimeSpan.FromHours(j - 1));
 
                    if(i != 0 && j != 0)
                    {
                        currentValue = m_BestTimesViewModel.AnalysisCollection[currentDayAndHour];
                    }

                    m_BestTimesGrid[i, j] = createBestTimesGridCell(labelX, labelY);

                    // Multithreading
                    Invoke(
                        new Action(
                            () =>
                                {
                                    Controls.Add(m_BestTimesGrid[i, j]);

                                    //// Column titles
                                    if(i == 0)
                                    {
                                        m_BestTimesGrid[i, j].Height -= 20;
                                        m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_Secondary;
                                        if(j == 0)
                                        {
                                            m_BestTimesGrid[i, j].Width += widthExpansion;
                                        }
                                        else
                                        {
                                            m_BestTimesGrid[i, j].Text = $@"{currentDayAndHour.HourOfDay.Hours}:00";
                                        }
                                    }
                                    else
                                    {
                                        //// Row titles
                                        if(j == 0)
                                        {
                                            m_BestTimesGrid[i, j].Width += widthExpansion;
                                            m_BestTimesGrid[i, j].Text = currentDayAndHour.DayOfWeek.ToString();
                                            m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_Secondary;
                                        }
                                        else
                                        {
                                            defineBestTimesGridCell(currentValue, i, j);
                                        }
                                    }

                                    labelX += m_BestTimesGrid[i, j].Width + 2;
                                    if(j == sk_NumOfHours)
                                    {
                                        lastHeight = m_BestTimesGrid[i, j].Height + 2;
                                    }
                                }));
                }

                labelX = k_StartX;
                labelY += lastHeight;
            }

            if(m_FirstDrawing)
            {
                m_FirstDrawing = false;
            }
        }

        private void defineBestTimesGridCell(int currentValue, int i, int j)
        {
            int maxValue = m_BestTimesViewModel.MaxTimeAnalysisValue;

            m_BestTimesGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;

            if (currentValue != 0)
            {
                if (currentValue <= maxValue * 0.1)
                {
                    m_BestTimesGrid[i, j].BackColor = Color.White;
                }
                else if (currentValue <= maxValue * 0.25)
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_BestTimesLow;
                }
                else if (currentValue <= maxValue * 0.75)
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_BestTimesMedium;
                }
                else
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_BestTimesHigh;
                }
            }
        }

        private Label createBestTimesGridCell(int i_LabelX, int i_LabelY)
        {
            Label label = new Label();
            label.Width = k_CellWidth;
            label.Height = k_CellHeight;
            label.BorderStyle = BorderStyle.None;
            label.Location = new Point(i_LabelX, i_LabelY);
            label.Text = string.Empty;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = Stylesheet.Font_BestTimesGrid;
            label.ForeColor = Color.White;

            return label;
        }
        #endregion
    }
}
