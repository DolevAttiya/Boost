using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    static class VideosDictionaryFactory
    {
        public static SortedValueDictionary<object, int> CreateVideosTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return DictionaryFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_eType => Post.eType.video == i_eType);
        }

        public static SortedValueDictionary<object, int> CreateVideosBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return DictionaryFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, Post.eType.video);
        }
    }
}
