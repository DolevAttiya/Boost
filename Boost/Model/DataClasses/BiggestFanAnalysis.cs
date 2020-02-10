using Boost.Model.DesignPatterns.Factory.FactoryMethod;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DataClasses
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