using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Factory.AnalysisFactory
{
    public class TimeAnalysisFactory : IAnalysisFactory
    {
        public Analysis CreateAnalysis(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeFrame i_TimeFrame)
        {
            TimeAnalysis o_TimeAnalysis = new TimeAnalysis();
            o_TimeAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeFrame);
            return o_TimeAnalysis;
        }
    }
}