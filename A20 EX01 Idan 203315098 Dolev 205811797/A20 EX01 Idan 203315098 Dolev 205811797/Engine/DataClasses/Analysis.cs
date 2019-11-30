using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public abstract class Analysis
    {
        public Dictionary<object, int> PhotosDictionary { get; protected set; }

        public Dictionary<object, int> VideosDictionary { get; protected set; }

        public Dictionary<object, int> StatusDictionary { get; protected set; }

        public Dictionary<object, int> CombinedAnalysisHolders { get; protected set; }

        protected Dictionary<object, int> Calculator(Dictionary<object, int> i_DictionaryToSort)
        {
            int numberOfIterations = BoostEngine.k_NumOfBiggestFans;
            const int k_ZeroIterations = 0;
            Dictionary<object, int> o_SortedDictionary = new Dictionary<object, int>();

            foreach(KeyValuePair<object, int> itemToSort in i_DictionaryToSort.OrderBy(key => key.Value))
            {
                if(numberOfIterations-- < k_ZeroIterations)
                {
                    break;
                }

                o_SortedDictionary.Add(itemToSort.Key, itemToSort.Value);
            }

            return o_SortedDictionary;
        }

        protected void AddByType(User i_UserToDoAnalysisOn, eTimerSelector i_TimeToStrict)
        {
            foreach(Post postToAnalysis in i_UserToDoAnalysisOn.Posts)
            {
                if(postToAnalysis != null && postToAnalysis.CreatedTime != null && i_TimeToStrict.GetHashCode()
                   >= DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                {
                    CombinedAnalysisHolders = PostsParser(postToAnalysis, CombinedAnalysisHolders); // TODO
                    switch(postToAnalysis.Type)
                    {
                        case Post.eType.status:
                            StatusDictionary = PostsParser(postToAnalysis, StatusDictionary); // TODO
                            break;
                        case Post.eType.photo:
                            PhotosDictionary = PostsParser(postToAnalysis, PhotosDictionary); // TODO
                            break;
                        case Post.eType.video:
                            VideosDictionary = PostsParser(postToAnalysis, VideosDictionary); // TODO
                            break;
                    }
                }
            }
        }

        protected abstract Dictionary<object, int> PostsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_ArrayToAnalysisHolders);
    }
}