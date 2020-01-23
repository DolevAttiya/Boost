using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Factory.AnalysisFactory
{
    public class BiggestFanAnalysisFactory : IAnalysisFactory
    {
        public Analysis CreateAnalysis(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeFrame i_TimeFrame)
        {
            BiggestFanAnalysis o_BiggestFanAnalysis = new BiggestFanAnalysis();
            o_BiggestFanAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeFrame);
            return o_BiggestFanAnalysis;
        }
    }
}