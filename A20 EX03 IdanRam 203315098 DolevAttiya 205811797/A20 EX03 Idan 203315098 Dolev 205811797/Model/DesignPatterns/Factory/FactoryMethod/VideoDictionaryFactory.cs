using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Factory.FactoryMethod
{
    public static class VideoDictionaryFactory
    {
        private static readonly DictionaryFactory sr_BasicFactory = new DictionaryFactory();

        public static SortedValueDictionary<object, int> CreateVideoTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame)
        {
            return sr_BasicFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.video == i_EType);
        }

        public static SortedValueDictionary<object, int> CreateVideoBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeFrame i_TimeFrame)
        {
            return sr_BasicFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_EType => Post.eType.video == i_EType);
        }
    }
}
