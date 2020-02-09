using Boost.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DesignPatterns.Factory.AnalysisFactory
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