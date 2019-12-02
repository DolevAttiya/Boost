using System;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public struct DayAndHour
    {
        public const int k_NumOfWeekDays = 7;
        public const int k_NumOfHours = 24;

        public DayOfWeek DayOfWeek { get; private set; }

        public TimeSpan HourOfDay { get; private set; }

        public DayAndHour(DayOfWeek i_DayOfWeek, TimeSpan i_HourOfDay)
        {
            if(i_HourOfDay.Minutes > 30)
            {
                TimeSpan hourToAddParser = new TimeSpan(0, 1, 0, 0);
                TimeSpan timeSpanWithOneHour = i_HourOfDay.Add(hourToAddParser);
                HourOfDay = timeSpanWithOneHour;
            }
            else
            {
                HourOfDay = i_HourOfDay;
            }

            DayOfWeek = i_DayOfWeek;
        }
    }
}
