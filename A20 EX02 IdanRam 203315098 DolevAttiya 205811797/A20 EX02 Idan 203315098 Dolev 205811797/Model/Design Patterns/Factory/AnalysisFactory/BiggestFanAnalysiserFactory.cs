﻿using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory
{
    public class BiggestFanAnalysiserFactory : IAnalysisFactory
    {
        readonly AnalysisFactory r_AnalysisFactory = new AnalysisFactory();
        public Analysis CreateAnalysis(
            Post.eType i_Type,
            User i_User,
            eTimeSelector i_TimeSelector)
        {
            return r_AnalysisFactory.Analysiser(i_Type,i_User, i_TimeSelector, typeof(BiggestFanAnalysis));
        }
    }
}