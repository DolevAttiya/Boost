using System;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class DateAndValue
    {
        #region Properties

        public DateTime Date { get; set; }

        public int Value { get; set; }

        #endregion

        #region Ctor

        public DateAndValue()
        {
            Value = 0;
        }

        #endregion
    }
}
