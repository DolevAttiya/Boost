using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A20_EX01_Idan_203315098_Dolev_205811797.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public abstract class Analysis
    {
        public Dictionary<object, int> PhotosDictionary { get; protected set; }

        public Dictionary<object, int> VideosDictionary { get; protected set; }

        public Dictionary<object, int> StatusDictionary { get; protected set; }

        public Dictionary<object, int> CombinedAnalysisHolders { get; protected set; }

        protected Dictionary<object, int> calculator(Dictionary<object, int> i_DictionaryToSort)
        {
            int numberOfIterations = BoostEngine.k_TopNumber;
            const int k_ZeroIterations = 0;
            Dictionary<object, int> o_SortedDictionary = new Dictionary<object, int>();

            foreach(KeyValuePair<object, int> itemToSort in i_DictionaryToSort.OrderBy(key => key.Value))
            {
                if(numberOfIterations-- > k_ZeroIterations)
                {
                    break;
                }

                o_SortedDictionary.Add(itemToSort.Key, itemToSort.Value);
            }

            return o_SortedDictionary;
        }
        protected void addByType(eTimerSelector i_TimeToStrict)
        {
            const int k_OlderThanTimeToStrict = 0;

            foreach (Post postToAnalysis in BoostEngine.LoggedInUser.Posts)
            {
                CombinedAnalysisHolders = postsParser(postToAnalysis, CombinedAnalysisHolders); // TODO

                if (postToAnalysis.CreatedTime == null || i_TimeToStrict.CompareTo(postToAnalysis.CreatedTime.Value.Date)
                    < k_OlderThanTimeToStrict)
                {
                    break;
                }

                switch (postToAnalysis.Type)
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

        protected abstract Dictionary<object, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_ArrayToAnalysisHolders);
    }
}