using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.MethodFactory
{
    public static class VideosDictionaryFactory
    {
        static readonly DictionaryFactory sr_BasicFactory = new DictionaryFactory();

        public static SortedValueDictionary<object, int> CreateVideosTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return sr_BasicFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.video == i_EType);
        }

        public static SortedValueDictionary<object, int> CreateVideosBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return sr_BasicFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_EType => Post.eType.video == i_EType);
        }
    }
}
