using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public interface IAnalysis
    {
        IAnalysis CreateAnalysisByTimeFrame(User i_AnalysisUser, eTimeSelector i_TimeFrame = eTimeSelector.Month);
    }
}
