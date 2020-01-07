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
        private static readonly int sr_NumOfDays = 7;
        private static readonly int sr_NumOfHours = 24;
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;
        private readonly int r_GridAreaHeight;
        private readonly int r_GridAreaWidth;
        private int m_CellWidth;
        private int m_CellHeight;
        public int[,] m_BestPostTimes = new int[sr_NumOfDays, sr_NumOfHours]; // TODO 
        public Label[,] m_BestTimesGrid = new Label[sr_NumOfDays + 1, sr_NumOfHours + 1];
        private BestTimesViewModel m_BestTimesViewModel = new BestTimesViewModel();
        private eTimeFrame m_LastUsedTimeFrame = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisTimeFrame;
        private eAnalysisDataBasis m_LastUsedDataBasis = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisDataBasis;
        private bool m_FirstDrawing = true;
        #endregion

        #region Ctor
        public BestTimesView()
        {
            InitializeComponent();
            r_GridAreaHeight = Size.Height - 40;
            r_GridAreaWidth = Size.Width - 100;
        }
        #endregion

        #region Methods
        public void DrawBestTimesGrid(eTimeFrame i_TimeFrame = eTimeFrame.Month, eAnalysisDataBasis i_AnalysisDataBasis = eAnalysisDataBasis.Combined) 
        {
            m_CellHeight = r_GridAreaHeight / (sr_NumOfDays + 1);
            m_CellWidth = r_GridAreaWidth / (sr_NumOfHours + 1);
            const int k_StartX = 5;
            const int k_StartY = 45;
            int labelX = k_StartX;
            int labelY = k_StartY;
            int lastHeight = 0;
            const int k_WidthExpansion = 35;
            int currentValue = 0;

            if(m_FirstDrawing)
            {
                m_BestTimesViewModel.CreateTimeAnalysis(r_BoostEn.LoggedInUser, i_TimeFrame, i_AnalysisDataBasis);
                m_LastUsedTimeFrame = i_TimeFrame;
                m_LastUsedDataBasis = i_AnalysisDataBasis;
            }
            else
            {
                if(i_TimeFrame == m_LastUsedTimeFrame)
                {
                    if(i_AnalysisDataBasis != m_LastUsedDataBasis)
                    {
                        m_BestTimesViewModel.SelectAnalysisCollection(i_AnalysisDataBasis);
                        m_LastUsedDataBasis = i_AnalysisDataBasis;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    m_BestTimesViewModel.CreateTimeAnalysis(BoostEngine.Instance.LoggedInUser, i_TimeFrame, i_AnalysisDataBasis);
                    m_LastUsedTimeFrame = i_TimeFrame;
                    m_LastUsedDataBasis = i_AnalysisDataBasis;
                }
            }

            for(int i = 0; i <= sr_NumOfDays; i++)
            {
                for(int j = 0; j <= sr_NumOfHours; j++)
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
                                            m_BestTimesGrid[i, j].Width += k_WidthExpansion;
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
                                            m_BestTimesGrid[i, j].Width += k_WidthExpansion;
                                            m_BestTimesGrid[i, j].Text = currentDayAndHour.DayOfWeek.ToString();
                                            m_BestTimesGrid[i, j].BackColor = Stylesheet.Color_Secondary;
                                        }
                                        else
                                        {
                                            defineBestTimesGridCell(currentValue, i, j);
                                        }
                                    }

                                    labelX += m_BestTimesGrid[i, j].Width + 2;
                                    if(j == sr_NumOfHours)
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
            label.Width = m_CellWidth;
            label.Height = m_CellHeight;
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
