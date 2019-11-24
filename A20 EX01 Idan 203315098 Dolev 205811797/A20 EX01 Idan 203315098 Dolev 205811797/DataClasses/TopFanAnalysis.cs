using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class TopFanAnalysis : IAnalysis
    {

        public Dictionary<User, int> PhotosDictionary { get; private set; }

        public Dictionary<User, int> VideosDictionary { get; private set; }

        public Dictionary<User, int> StatusDictionary { get; private set; }

        public Dictionary<User, int> CombinedAnalysisHolders { get; private set; }

        public TopFanAnalysis()
        {
            const int k_ZeroLikesYet = 0;

            foreach (User friend in BoostEngine.LoggedInUser.Friends)
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

        public IAnalysis CalculateAnalysis(eTimerSelector i_TimeToStrict)
        {
            TopFanAnalysis o_CalculatedTopFans = new TopFanAnalysis();

            AddByType(i_TimeToStrict);
            o_CalculatedTopFans.PhotosDictionary = calculator(this.PhotosDictionary);
            o_CalculatedTopFans.VideosDictionary = calculator(this.VideosDictionary);
            o_CalculatedTopFans.StatusDictionary = calculator(this.StatusDictionary);
            o_CalculatedTopFans.CombinedAnalysisHolders = calculator(this.CombinedAnalysisHolders);

            return o_CalculatedTopFans;
        }

        private Dictionary<User, int> calculator(Dictionary<User, int> i_DictionarytoSort)
        {
            int numberOfIterations = BoostEngine.k_TopNumber;
            const int k_ZeroIterations = 0;
            Dictionary<User, int> o_SortedDictionary = new Dictionary<User, int>();

            foreach(KeyValuePair<User, int> itemToSort in i_DictionarytoSort.OrderBy(key => key.Value))
            {
                if(numberOfIterations-- > k_ZeroIterations)
                {
                    break;
                }

                o_SortedDictionary.Add(itemToSort.Key, itemToSort.Value);
            }

            return o_SortedDictionary;
        }

        public void AddByType(eTimerSelector i_TimeToStrict)
        {
            const int k_OlderThanTimeToStrict = 0;

            foreach (Post postToAnalysis in BoostEngine.LoggedInUser.Posts)
            {
                CombinedAnalysisHolders = postsParser(postToAnalysis, CombinedAnalysisHolders); // TODO

                if(postToAnalysis.CreatedTime == null
                   || i_TimeToStrict.CompareTo(postToAnalysis.CreatedTime.Value.Date) < k_OlderThanTimeToStrict)
                {
                    break;
                }

                switch(postToAnalysis.Type)
                {
                    case Post.eType.status:
                        StatusDictionary = postsParser(postToAnalysis, StatusDictionary); // TODO
                        break;
                    case Post.eType.photo:
                        PhotosDictionary = postsParser(postToAnalysis, PhotosDictionary); // TODO
                        break;
                    case Post.eType.video:
                        VideosDictionary = postsParser(postToAnalysis, VideosDictionary); // TODO
                        break;
                }

            }
        }

        private Dictionary<User, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<User, int> io_ArrayToAnalysisHolders)
        {
            foreach(User likedBy in i_PostToAnalysis.LikedBy)
            {
                io_ArrayToAnalysisHolders[likedBy] += 1;
            }

            return io_ArrayToAnalysisHolders;

        }

    }
}
