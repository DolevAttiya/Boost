using System.Linq;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
{
    public class BestTimesViewModel
    {
        public TimeAnalysis TimeAnalysis { get; set; }

        public SortedValueDictionary<object, int> AnalysisCollection { get; set; }

        public int MaxTimeAnalysisValue { get; set; }

        public BestTimesViewModel()
        {
            TimeAnalysis = new TimeAnalysis();
        }

        public void CreateTimeAnalysis(User i_User, eTimeSelector i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            TimeAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeFrame);
            SelectAnalysisCollection(TimeAnalysis, i_AnalysisDataBasis);
            MaxTimeAnalysisValue = AnalysisCollection.Values.Max();
        }

        public void SelectAnalysisCollection(TimeAnalysis i_TimeAnalysis, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            AnalysisCollection = i_TimeAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }
    }
}
