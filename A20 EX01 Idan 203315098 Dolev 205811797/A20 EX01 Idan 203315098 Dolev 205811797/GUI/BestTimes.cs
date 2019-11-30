using System;
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
        private static readonly int sk_NumOfDays = 7;
        private static readonly int sk_NumOfHours = 24;
        private readonly int k_GridAreaHeight;
        private readonly int k_GridAreaWidth;
        private int k_CellWidth;
        private int k_CellHeight;
        public int[,] m_BestPostTimes = new int[sk_NumOfDays, sk_NumOfHours];
        public Label[,] m_BestTimesGrid = new Label[sk_NumOfDays + 1, sk_NumOfHours + 1];
        private int m_MaxTimeValue = 0;

        public BestTimes()
        {
            InitializeComponent();
            k_GridAreaHeight = this.Size.Height - 40;
            k_GridAreaWidth = this.Size.Width - 100;
        }

        /*public void PopulateBestTimes(FacebookObjectCollection<Post> i_Posts)
        {
            foreach(Post postToPopulate in i_Posts)
            {
                if(postToPopulate.UpdateTime != null)
                {
                    DateTime updateTime = postToPopulate.UpdateTime.Value;
                    Random rand = new Random();

                    int day = (int)Convert.ChangeType(updateTime.DayOfWeek, updateTime.DayOfWeek.GetTypeCode());
                    int hours = updateTime.TimeOfDay.Hours;

                    if(postToPopulate.UpdateTime.Value.TimeOfDay.Minutes > 30)
                    {
                        hours++;
                        if(hours == 24)
                        {
                            hours = 0;
                        }
                    }

                    //m_BestPostTimes[day, hours] += i_Posts[i].LikedBy.Count;//TODO
                    m_BestPostTimes[day, hours] += rand.Next(0, 1000); //TODO
                    if(m_BestPostTimes[day, hours] > m_MaxTimeValue)
                    {
                        m_MaxTimeValue = m_BestPostTimes[day, hours];
                    }

                }
            }
        }*/

        public void DrawBestTimesGrid(TimeAnalysis i_BestTimeAnmAnalysis)
        {
            k_CellHeight = k_GridAreaHeight / (sk_NumOfDays + 1);
            k_CellWidth = k_GridAreaWidth / (sk_NumOfHours + 1);
            int startX = 5;
            int startY = 45;
            int labelX = startX;
            int labelY = startY;
            int lastHeight = 0;
            int widthExpansion = 35;
            int currentValue = 0;
            m_MaxTimeValue = i_BestTimeAnmAnalysis.CombinedAnalysisHolders.Values.Max();

            for(int i = 0; i <= sk_NumOfDays; i++)
            {
                for(int j = 0; j <= sk_NumOfHours; j++)
                {
                    int dayInt = i;
                    DayAndHour currentDayAndHour = new DayAndHour(
                        (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), dayInt - 1),
                        TimeSpan.FromHours(j - 1));
                    /* DayOfWeek day = (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), dayInt);
                      int hours = j - 1;*/
                    if(i != 0 && j != 0)
                    {
                        currentValue = i_BestTimeAnmAnalysis.CombinedAnalysisHolders[currentDayAndHour];
                    }

                    m_BestTimesGrid[i, j] = new Label();
                    m_BestTimesGrid[i, j].Width = k_CellWidth;
                    m_BestTimesGrid[i, j].Height = k_CellHeight;
                    m_BestTimesGrid[i, j].BorderStyle = System.Windows.Forms.BorderStyle.None;
                    m_BestTimesGrid[i, j].Location = new System.Drawing.Point(labelX, labelY);
                    m_BestTimesGrid[i, j].Text = string.Empty;
                    m_BestTimesGrid[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    m_BestTimesGrid[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    m_BestTimesGrid[i, j].Font = new System.Drawing.Font(
                        "Century Gothic",
                        7.875F,
                        System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point,
                        (byte)0);
                    m_BestTimesGrid[i, j].ForeColor = System.Drawing.Color.White;
                    this.Controls.Add(m_BestTimesGrid[i, j]);
                    if(i == 0)
                    {
                        m_BestTimesGrid[i, j].Height -= 20;
                        m_BestTimesGrid[i, j].BackColor = UI_Elements.color_Secondary;
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
                        if(j == 0)
                        {
                            m_BestTimesGrid[i, j].Width += widthExpansion;
                            m_BestTimesGrid[i, j].Text = currentDayAndHour.DayOfWeek.ToString();
                            m_BestTimesGrid[i, j].BackColor = UI_Elements.color_Secondary;
                        }
                        else
                        {
                            m_BestTimesGrid[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            if(currentValue != 0)
                            {
                                if(currentValue <= m_MaxTimeValue * 0.1)
                                {
                                    m_BestTimesGrid[i, j].BackColor = System.Drawing.Color.White;
                                }
                                else if(currentValue <= m_MaxTimeValue * 0.25)
                                {
                                    m_BestTimesGrid[i, j].BackColor = UI_Elements.color_BestTimesLow;
                                }
                                else if(currentValue <= m_MaxTimeValue * 0.75)
                                {
                                    m_BestTimesGrid[i, j].BackColor = UI_Elements.color_BestTimesMedium;
                                }
                                else
                                {
                                    m_BestTimesGrid[i, j].BackColor = UI_Elements.color_BestTimesHigh;
                                }
                            }
                        }
                    }

                    labelX += m_BestTimesGrid[i, j].Width + 2;
                    if(j == sk_NumOfHours)
                    {
                        lastHeight = m_BestTimesGrid[i, j].Height + 2;
                    }
                }

                labelX = startX;
                labelY += lastHeight;
            }
        }
    }
}
