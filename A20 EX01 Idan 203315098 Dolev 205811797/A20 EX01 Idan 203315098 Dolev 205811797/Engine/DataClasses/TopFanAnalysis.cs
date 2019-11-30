using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public class TopFanAnalysis : Analysis, IAnalysis
    {
        public TopFanAnalysis()
        {
            initializeComponents();
        }

        private void initializeComponents()
        {
            PhotosDictionary = new Dictionary<object, int>();
            VideosDictionary = new Dictionary<object, int>();
            StatusDictionary = new Dictionary<object, int>();
            CombinedAnalysisHolders = new Dictionary<object, int>();
        }

        private IAnalysis calculateAnalysis()
        {
            return new TopFanAnalysis
                       {
                           PhotosDictionary = Calculator(this.PhotosDictionary),
                           VideosDictionary = Calculator(this.VideosDictionary),
                           StatusDictionary = Calculator(this.StatusDictionary),
                           CombinedAnalysisHolders = Calculator(this.CombinedAnalysisHolders)
                       };
        }

        protected override Dictionary<object, int> PostsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_ArrayToAnalysisHolders)
        {
            const int k_LikeByUser = 1;
            foreach(User likedBy in i_PostToAnalysis.LikedBy)
            {
                if(io_ArrayToAnalysisHolders.ContainsKey(likedBy))
                {
                    io_ArrayToAnalysisHolders[likedBy] += k_LikeByUser;
                }
                else
                {
                    io_ArrayToAnalysisHolders.Add(likedBy, k_LikeByUser);
                }
            }

            return io_ArrayToAnalysisHolders;
        }

        public IAnalysis CreateAnalysisByTimeStrict(
            User i_UserToDoAnalysisOn,
            eTimerSelector i_TimeToStrict = eTimerSelector.Month)
        {
            initializeComponents();
            AddByType(i_UserToDoAnalysisOn, i_TimeToStrict);

            return calculateAnalysis();
        }

        public IAnalysis GetAnalysisByTimeStrict(User i_UserToDoAnalysisOn, eTimerSelector i_TimeToStrict)
        {
            throw new System.NotImplementedException();
        }
    }
}
