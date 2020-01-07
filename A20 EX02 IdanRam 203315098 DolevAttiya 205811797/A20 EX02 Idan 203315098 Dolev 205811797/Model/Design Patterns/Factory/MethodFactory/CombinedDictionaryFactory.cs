using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.MethodFactory
{
    public static class CombinedDictionaryFactory
    {
        private static readonly DictionaryFactory sr_BasicFactory = new DictionaryFactory();

        public static SortedValueDictionary<object, int> CreateCombinedTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame)
        {
            return sr_BasicFactory.CreateTimeAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_EType => true);
        }

        public static SortedValueDictionary<object, int> CreateCombinedBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame)
        {
            return sr_BasicFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_EType => true);
        }
    }
}