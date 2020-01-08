using FacebookWrapper.ObjectModel;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public interface IAnalysis
    {
        // Below methods IS USED but at the moment only implicitly
        IAnalysis CreateAnalysisByTimeFrame(User i_AnalysisUser, eTimeFrame i_TimeFrame = eTimeFrame.Month);
    }
}
