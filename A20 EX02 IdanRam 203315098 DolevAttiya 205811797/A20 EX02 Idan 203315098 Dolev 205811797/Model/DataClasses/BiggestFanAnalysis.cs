using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.MethodFactory;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class BiggestFanAnalysis : Analysis
    {
        #region Methods

        public override IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame = eTimeSelector.Month)
        {
            PhotosDictionary =
                PhotosDictionaryFactory.CreatePhotosBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            VideosDictionary =
                VideosDictionaryFactory.CreateVideosBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            StatusDictionary =
                StatusDictionaryFactory.CreateStatusBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            CombinedAnalysisHolders =
                CombinedDictionaryFactory.CreateCombinedBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            return this;
        }

        #endregion
    }
}