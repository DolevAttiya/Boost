using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
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
