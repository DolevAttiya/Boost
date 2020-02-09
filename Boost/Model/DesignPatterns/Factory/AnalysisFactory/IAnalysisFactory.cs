using Boost.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DesignPatterns.Factory.AnalysisFactory
{
    public interface IAnalysisFactory
    {
        Analysis CreateAnalysis(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeFrame i_TimeFrame);
    }
}
