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
            PhotosDictionary = DictionaryFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.photo == i_EType);
            VideosDictionary = DictionaryFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.video == i_EType);
            StatusDictionary = DictionaryFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.status == i_EType);
            CombinedAnalysisHolders = DictionaryFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => true);

            return this;
        }

        #endregion
    }
}