using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory
{
    public class TimeAnalysiserFactory : IAnalysisFactory
    {
        public Analysis CreateAnalysis(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeSelector i_TimeSelector)
        {
            TimeAnalysis o_TimeAnalysis = new TimeAnalysis();
            o_TimeAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeSelector);
            return o_TimeAnalysis;
        }
    }
}