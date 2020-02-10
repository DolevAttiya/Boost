using Boost.Model.DesignPatterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DataClasses
{
    public abstract class Analysis : IAnalysis
    {
        #region Properties

        public SortedValueDictionary<object, int> PhotoDictionary { get; protected set; }

        public SortedValueDictionary<object, int> VideoDictionary { get; protected set; }

        public SortedValueDictionary<object, int> StatusDictionary { get; protected set; }

        public SortedValueDictionary<object, int> CombinedDataBasisDictionary { get; protected set; }

        #endregion

        #region Methods

        public SortedValueDictionary<object, int> GetSpecificAnalysisCollection(eAnalysisDataBasis i_AnalysisDataBasis)
        {
            SortedValueDictionary<object, int> analysisCollection = null;

            switch(i_AnalysisDataBasis)
            {
                case eAnalysisDataBasis.Combined:
                    analysisCollection = CombinedDataBasisDictionary;
                    break;
                case eAnalysisDataBasis.Photos:
                    analysisCollection = PhotoDictionary;
                    break;
                case eAnalysisDataBasis.Status:
                    analysisCollection = StatusDictionary;
                    break;
                case eAnalysisDataBasis.Videos:
                    analysisCollection = VideoDictionary;
                    break;
            }
            
            return analysisCollection;
        }

        public abstract IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame = eTimeFrame.Month);

        #endregion
    }
}