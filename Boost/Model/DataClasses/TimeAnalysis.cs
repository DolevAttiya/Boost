using Boost.Model.DesignPatterns.Factory.FactoryMethod;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DataClasses
{
    public class TimeAnalysis : Analysis
    {
        #region Methods

        public override IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame = eTimeFrame.Month)
        {
            PhotoDictionary = PhotoDictionaryFactory.CreatePhotoTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            VideoDictionary = VideoDictionaryFactory.CreateVideoTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            StatusDictionary = StatusDictionaryFactory.CreateStatusTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);
            CombinedDataBasisDictionary =
                CombinedDictionaryFactory.CreateCombinedTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame);

            return this;
        }

        #endregion
    }
}