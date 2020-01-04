using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class TimeAnalysis : Analysis
    {
        #region Methods

        public override IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame = eTimeSelector.Month)
        {
            PhotosDictionary = PhotosDictionaryFactory.CreatePhotosTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            VideosDictionary = VideosDictionaryFactory.CreateVideosTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            StatusDictionary = StatusDictionaryFactory.CreateStatusTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            CombinedAnalysisHolders =
                CombinedDictionaryFactory.CreateCombinedTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);

            return this;
        }

        #endregion
    }
}