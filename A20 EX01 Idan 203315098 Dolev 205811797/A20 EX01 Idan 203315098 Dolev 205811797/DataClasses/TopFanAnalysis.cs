using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class TopFanAnalysis : IAnalysis
    {

        private const int k_NumberOfTopFans = 10;

        public Dictionary<User, int> PhotosArray { get; private set; }

        public Dictionary<User, int> VideosArray { get; private set; }

        public Dictionary<User, int> StatusArray { get; private set; }

        public Dictionary<User, int> CombinedAnalysisHolders { get; private set; }

        public TopFanAnalysis()
        {
            foreach(User friend in BoostEngine.LoggedInUser.Friends)
            {
                if(friend != null)
                {

                    PhotosArray.Add(friend, 0);
                    VideosArray.Add(friend, 0);
                    StatusArray.Add(friend, 0);
                    CombinedAnalysisHolders.Add(friend, 0);
                }
            }


        }


        public IAnalysis CalculateAnalysis(eTimerSelector i_TimeToStrict)
        {
            AddByType(i_TimeToStrict);

            TopFanAnalysis o_CalculatedTopFans = new TopFanAnalysis();
            o_CalculatedTopFans.PhotosArray = calculator(this.PhotosArray);
            o_CalculatedTopFans.VideosArray = calculator(this.VideosArray);
            o_CalculatedTopFans.StatusArray = calculator(this.StatusArray);
            o_CalculatedTopFans.CombinedAnalysisHolders = calculator(this.CombinedAnalysisHolders);
            return o_CalculatedTopFans;
        }

        private Dictionary<User, int> calculator(Dictionary<User, int> i_DictionarytoSort)
        {
            int numberOfIterations = k_NumberOfTopFans;
            Dictionary<User, int> o_SortedDictionary = new Dictionary<User, int>();
            foreach(KeyValuePair<User, int> itemToSort in i_DictionarytoSort.OrderBy(key => key.Value))
            {
                if(numberOfIterations-- < 0)
                {
                    break;
                }

                o_SortedDictionary.Add(itemToSort.Key, itemToSort.Value);
            }

            return o_SortedDictionary;
        }

        public void AddByType(eTimerSelector i_TimeToStrict)
        {
            foreach(Post postToAnalysis in BoostEngine.LoggedInUser.Posts)
            {
                CombinedAnalysisHolders = postsParser(postToAnalysis, CombinedAnalysisHolders); // TODO

                if(postToAnalysis.CreatedTime == null
                   || i_TimeToStrict.CompareTo(postToAnalysis.CreatedTime.Value.Date) < 0)
                {
                    break;
                }

                switch(postToAnalysis.Type)
                {
                    case Post.eType.status:
                        StatusArray = postsParser(postToAnalysis, StatusArray); // TODO
                        break;
                    case Post.eType.photo:
                        PhotosArray = postsParser(postToAnalysis, PhotosArray); // TODO
                        break;
                    case Post.eType.video:
                        VideosArray = postsParser(postToAnalysis, VideosArray); // TODO
                        break;
                }

            }
        }

        private Dictionary<User, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<User, int> io_ArrayToAnalysisHolders)
        {
            foreach(Comment comment in i_PostToAnalysis.Comments)
            {
                io_ArrayToAnalysisHolders[comment.From] += 1;
            }

            return io_ArrayToAnalysisHolders;

        }

    }
}
