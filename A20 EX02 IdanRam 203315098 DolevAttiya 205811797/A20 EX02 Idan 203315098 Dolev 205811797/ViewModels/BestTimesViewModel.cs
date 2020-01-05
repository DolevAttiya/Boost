using System.Linq;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
{
    public class BestTimesViewModel
    {
        public SortedValueDictionary<object, int> AnalysisCollection { get; set; }

        public int MaxTimeAnalysisValue { get; set; }

        public void CreateTimeAnalysis(User i_User, eTimeSelector i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            BoostEngine.Instance.TimeAnalysis = BoostEngine.Instance.m_AnalysisFactory.CreateAnalysis((Post.eType)i_AnalysisDataBasis, i_User, i_TimeFrame) as TimeAnalysis;
            SelectAnalysisCollection(i_AnalysisDataBasis);
            MaxTimeAnalysisValue = AnalysisCollection.Values.Max();
        }

        public void SelectAnalysisCollection( eAnalysisDataBasis i_AnalysisDataBasis)
        {
            AnalysisCollection = BoostEngine.Instance.TimeAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }
    }
}
