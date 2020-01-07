using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory
{
    public class BiggestFanAnalysiserFactory : IAnalysisFactory
    {
        public Analysis CreateAnalysis(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeSelector i_TimeSelector)
        {
            BiggestFanAnalysis o_BiggestFanAnalysis = new BiggestFanAnalysis();
            o_BiggestFanAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeSelector);
            return o_BiggestFanAnalysis;
        }
    }
}