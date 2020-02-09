using FacebookWrapper.ObjectModel;

namespace Boost.Model.DataClasses
{
    public interface IAnalysis
    {
        // Below methods IS USED but at the moment only implicitly
        IAnalysis CreateAnalysisByTimeFrame(User i_AnalysisUser, eTimeFrame i_TimeFrame = eTimeFrame.Month);
    }
}
