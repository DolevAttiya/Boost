using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    interface ITopFan 
    {
        Analysis CalculateTimeAnalysis();
        void AddTopFans(eTimerSelector i_TimeToStrict);

    }
}
