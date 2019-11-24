using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    public partial class BestTimes : UserControl
    {
        private static readonly int k_NumOfDays = 7;
        private static readonly int k_NumOfHours = 24;
        private static readonly int k_CellWidth = 36;
        private static readonly int k_CellHeight = 51;
        public int[,] m_BestPostTimes = new int[k_NumOfDays, k_NumOfHours];
        public Label[,] m_BestTimesGrid = new Label[k_NumOfDays+1, k_NumOfHours+1];
        private int m_MaxTimeValue = 0;
        
        public BestTimes()
        {
            InitializeComponent();
        }

        public void PopulateBestTimes(FacebookObjectCollection<Post> i_Posts)
        {
            for(int i=0; i < i_Posts.Count; i++)
            {
                if(i_Posts[i].UpdateTime != null)
                {
                    DateTime updateTime = i_Posts[i].UpdateTime.Value;

                    int day = (int)Convert.ChangeType(updateTime.DayOfWeek, updateTime.DayOfWeek.GetTypeCode());
                    int hours = updateTime.TimeOfDay.Hours;

                    if(i_Posts[i].UpdateTime.Value.TimeOfDay.Minutes>30)
                    {
                        hours++;
                    }
                    
                    m_BestPostTimes[day, hours] += 20;
                    if(m_BestPostTimes[day, hours] > m_MaxTimeValue)
                    {
                        m_MaxTimeValue = m_BestPostTimes[day, hours];
                    }
                    
                }
            }
        }

        public void DrawBestTimesGrid()
        {
            int startX = 2;
            int startY = 15;
            int labelX = startX;
            int labelY = startY;
            int lastHeight = 0;
            int widthExpansion = 35;
            int currentValue = 0;
            for (int i=0; i <= k_NumOfDays; i++)
            {
                for (int j = 0; j <= k_NumOfHours; j++)
                {
                    int dayInt = i -1;
                    DayOfWeek day = (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), dayInt);
                    int hours = j - 1;
                    if(i != 0 && j != 0)
                    {
                        currentValue = m_BestPostTimes[dayInt, hours];
                    }

                    m_BestTimesGrid[i, j] = new Label();
                    m_BestTimesGrid[i, j].Width = k_CellWidth;
                    m_BestTimesGrid[i, j].Height = k_CellHeight;
                    m_BestTimesGrid[i, j].BorderStyle = System.Windows.Forms.BorderStyle.None;
                    m_BestTimesGrid[i, j].Location = new System.Drawing.Point(labelX, labelY);
                    m_BestTimesGrid[i, j].Text = "";
                    m_BestTimesGrid[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    m_BestTimesGrid[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    m_BestTimesGrid[i, j].Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    m_BestTimesGrid[i, j].ForeColor = System.Drawing.Color.White;
                    this.Controls.Add(m_BestTimesGrid[i, j]);
                    if (i==0)
                    {
                        m_BestTimesGrid[i, j].Height -= 20;
                        m_BestTimesGrid[i, j].BackColor = UI_Elements.color_Secondary;
                        if (j==0)
                        {
                        m_BestTimesGrid[i, j].Width += widthExpansion;
                        }
                        else
                        {
                            m_BestTimesGrid[i, j].Text = hours + ":00";
                        }
                    }
                    else
                    {
                        if(j==0)
                        {
                            m_BestTimesGrid[i, j].Width += widthExpansion;
                            m_BestTimesGrid[i, j].Text = day.ToString();
                            m_BestTimesGrid[i, j].BackColor = UI_Elements.color_Secondary;
                        }
                        else
                        {
                            m_BestTimesGrid[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            if(currentValue != 0)
                            {
                                if(currentValue<= m_MaxTimeValue * 0.25)
                                {
                                    m_BestTimesGrid[i, j].BackColor = System.Drawing.Color.White;
                                }
                                else if (currentValue <= m_MaxTimeValue * 0.5)
                                {
                                    m_BestTimesGrid[i, j].BackColor = System.Drawing.Color.FromArgb(232,200,20);
                                }
                                else if (currentValue <= m_MaxTimeValue * 0.75)
                                {
                                    m_BestTimesGrid[i, j].BackColor = System.Drawing.Color.Orange;
                                }
                                else
                                {
                                    m_BestTimesGrid[i, j].BackColor = System.Drawing.Color.FromArgb(217, 17, 17);
                                }

                                //m_BestTimesGrid[i, j].Text = m_BestPostTimes[dayInt, hours].ToString();
                            }

                        }
                    }
                    labelX += m_BestTimesGrid[i, j].Width+2;
                    if (j == k_NumOfHours)
                    {
                        lastHeight = m_BestTimesGrid[i, j].Height+2;
                    }
                }
                labelX = startX;
                labelY += lastHeight;
            }
        }
    }
}
