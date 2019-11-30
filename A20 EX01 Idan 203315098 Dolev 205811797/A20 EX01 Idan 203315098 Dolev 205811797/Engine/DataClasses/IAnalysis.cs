using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public interface IAnalysis
    {
        IAnalysis CreateAnalysisByTimeStrict(User i_UserToDoAnalysisOn, eTimerSelector i_TimeToStrict);

    }
}
