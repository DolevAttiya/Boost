using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public interface IAnalysis
    {
        IAnalysis CreateAnalysisByTimeFrame(User i_UserToDoAnalysisOn, eTimeSelector i_TimeFrame);
    }
}
