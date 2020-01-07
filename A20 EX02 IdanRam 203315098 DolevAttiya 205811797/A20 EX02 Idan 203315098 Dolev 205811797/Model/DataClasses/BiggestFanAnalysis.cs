using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.MethodFactory;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class BiggestFanAnalysis : Analysis
    {
        #region Methods

        public override IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame = eTimeFrame.Month)
        {
            PhotoDictionary =
                PhotoDictionaryFactory.CreatePhotoBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            VideoDictionary =
                VideoDictionaryFactory.CreateVideoBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            StatusDictionary =
                StatusDictionaryFactory.CreateStatusBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            CombinedDataBasisDictionary =
                CombinedDictionaryFactory.CreateCombinedBiggestFansAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            return this;
        }

        #endregion
    }
}