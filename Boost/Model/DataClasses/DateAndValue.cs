using System;

namespace Boost.Model.DataClasses
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
