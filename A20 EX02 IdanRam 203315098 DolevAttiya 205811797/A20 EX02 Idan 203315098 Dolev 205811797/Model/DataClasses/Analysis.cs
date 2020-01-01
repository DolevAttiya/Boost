using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public abstract class Analysis: IAnalysis
    {

        #region Properties
        public SortedValueDictionary<object, int> PhotosDictionary { get; protected set; }

        public SortedValueDictionary<object, int> VideosDictionary { get; protected set; }

        public SortedValueDictionary<object, int> StatusDictionary { get; protected set; }

        public SortedValueDictionary<object, int> CombinedAnalysisHolders { get; protected set; }
        #endregion

        #region Methods

        public SortedValueDictionary<object, int> GetSpecificAnalysisCollection(
            eAnalysisDataBasis i_AnalysisDataBasis)
        {
            SortedValueDictionary<object, int> analysisCollection = null;

            switch (i_AnalysisDataBasis)
            {
                case eAnalysisDataBasis.Combined:
                    analysisCollection = this.CombinedAnalysisHolders;
                    break;
                case eAnalysisDataBasis.Photo:
                    analysisCollection = this.PhotosDictionary;
                    break;
                case eAnalysisDataBasis.Status:
                    analysisCollection = this.StatusDictionary;
                    break;
                case eAnalysisDataBasis.Video:
                    analysisCollection = this.VideosDictionary;
                    break;
            }

            return analysisCollection;
        }
        #endregion

        public abstract IAnalysis CreateAnalysisByTimeFrame(User i_AnalysisUser, eTimeSelector i_TimeFrame = eTimeSelector.Month);
    }
}