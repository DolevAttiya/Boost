using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class AnalysisHolder
    {
        private int m_NumberOfLikes;

        private int NumberOfLikes { get; }

        public void AddLikes(int i_NumberOfLikes)
        {
            m_NumberOfLikes += i_NumberOfLikes;
        }

        public DateTime HourlyDateTime { get; set; }

        public AnalysisHolder(DateTime i_HourlyDateTime)
        {
            m_NumberOfLikes = 0;
            HourlyDateTime = i_HourlyDateTime;
        }
    }
}
