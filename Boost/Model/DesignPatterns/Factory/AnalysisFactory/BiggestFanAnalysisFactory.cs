using Boost.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DesignPatterns.Factory.AnalysisFactory
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