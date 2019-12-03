﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public partial class BestTimes : UserControl
    {
        #region Data Members
        private static readonly int sk_NumOfDays = 7;
        private static readonly int sk_NumOfHours = 24;
        private readonly int k_GridAreaHeight;
        private readonly int k_GridAreaWidth;
        private int k_CellWidth;
        private int k_CellHeight;
        public int[,] m_BestPostTimes = new int[sk_NumOfDays, sk_NumOfHours];
        public Label[,] m_BestTimesGrid = new Label[sk_NumOfDays + 1, sk_NumOfHours + 1];
        private int m_MaxTimeValue = 0;
        #endregion

        #region Ctor
        public BestTimes()
        {
            InitializeComponent();
            k_GridAreaHeight = this.Size.Height - 40;
            k_GridAreaWidth = this.Size.Width - 100;
        }
        #endregion

        #region Methods
        public void DrawBestTimesGrid(TimeAnalysis i_BestTimeAnalysis)
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
            m_MaxTimeValue = i_BestTimeAnalysis.CombinedAnalysisHolders.Values.Max();

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
                        currentValue = i_BestTimeAnalysis.CombinedAnalysisHolders[currentDayAndHour];
                    }

                    m_BestTimesGrid[i, j] = createBestTimesGridCell(labelX, labelY);
                    this.Controls.Add(m_BestTimesGrid[i, j]);
                    if(i == 0) // Column titles
                    {
                        m_BestTimesGrid[i, j].Height -= 20;
                        m_BestTimesGrid[i, j].BackColor = Stylesheet.color_Secondary;
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
                        if(j == 0) // Row titles
                        {
                            m_BestTimesGrid[i, j].Width += widthExpansion;
                            m_BestTimesGrid[i, j].Text = currentDayAndHour.DayOfWeek.ToString();
                            m_BestTimesGrid[i, j].BackColor = Stylesheet.color_Secondary;
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
                }

                labelX = k_StartX;
                labelY += lastHeight;
            }
        }

        private void defineBestTimesGridCell(int currentValue, int i, int j)
        {
            m_BestTimesGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
            if (currentValue != 0)
            {
                if (currentValue <= m_MaxTimeValue * 0.1)
                {
                    m_BestTimesGrid[i, j].BackColor = Color.White;
                }
                else if (currentValue <= m_MaxTimeValue * 0.25)
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.color_BestTimesLow;
                }
                else if (currentValue <= m_MaxTimeValue * 0.75)
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.color_BestTimesMedium;
                }
                else
                {
                    m_BestTimesGrid[i, j].BackColor = Stylesheet.color_BestTimesHigh;
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
            label.Font = Stylesheet.font_BestTimesGrid;
            label.ForeColor = Color.White;

            return label;
        }
        #endregion
    }
}
