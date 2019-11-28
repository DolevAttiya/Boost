using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class TopFanAnalysis :Analysis, IAnalysis
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
            const int k_ZeroLikesYet = 0;

            foreach(User friend in BoostEngine.LoggedInUser.Friends)
            {
                if(friend != null)
                {
                    PhotosDictionary.Add(friend, k_ZeroLikesYet);
                    VideosDictionary.Add(friend, k_ZeroLikesYet);
                    StatusDictionary.Add(friend, k_ZeroLikesYet);
                    CombinedAnalysisHolders.Add(friend, k_ZeroLikesYet);
                }
            }
        }

        private IAnalysis CalculateAnalysis()
        {
            TopFanAnalysis o_CalculatedTopFans = new TopFanAnalysis();

            o_CalculatedTopFans.PhotosDictionary = calculator(this.PhotosDictionary);
            o_CalculatedTopFans.VideosDictionary = calculator(this.VideosDictionary);
            o_CalculatedTopFans.StatusDictionary = calculator(this.StatusDictionary);
            o_CalculatedTopFans.CombinedAnalysisHolders = calculator(this.CombinedAnalysisHolders);

            return o_CalculatedTopFans;
        }

        protected override Dictionary<object, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_ArrayToAnalysisHolders)
        {
            foreach(User likedBy in i_PostToAnalysis.LikedBy)
            {
                io_ArrayToAnalysisHolders[likedBy] += 1;
            }

            return io_ArrayToAnalysisHolders;
        }

        public IAnalysis CreateAnalysisByTimeStrict(eTimerSelector i_TimeToStrict = eTimerSelector.Month)
        {
            initializeComponents();
            addByType(i_TimeToStrict);

            return CalculateAnalysis();
        }
    }
}
