using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    public static class CombinedDictionaryFactory
    {
        public static SortedValueDictionary<object, int> CreateCombinedTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return DictionaryFactory.CreateTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_eType => true);
        }

        public static SortedValueDictionary<object, int> CreateCombinedBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return DictionaryFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, null);
        }
    }
}