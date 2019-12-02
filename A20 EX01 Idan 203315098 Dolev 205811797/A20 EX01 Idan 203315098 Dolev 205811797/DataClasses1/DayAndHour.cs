using System;


namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public struct DayAndHour
    {
        public const int k_NumberDaysOfWeek = 7;
        public const int k_NumberHoursADay = 24;
        public DayOfWeek DayofWeek { get;private set; }
        public  TimeSpan HourOfDay { get; private set; }

        public DayAndHour(DayOfWeek i_DayOfWeek, TimeSpan i_HourOfDay )
        {// TODO Check For Errors !!
            DayofWeek = i_DayOfWeek;
            HourOfDay = i_HourOfDay;
        }
    }


}
