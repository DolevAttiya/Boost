using System;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class BiggestFanAnalysis : Analysis, IAnalysis
    {
        #region Ctor
        public BiggestFanAnalysis()
        {
            initializeComponents();
        }
        #endregion

        #region Methods
        private void initializeComponents()
        {
            PhotosDictionary = new SortedProxyDictionary<object, int>();
            VideosDictionary = new SortedProxyDictionary<object, int>();
            StatusDictionary = new SortedProxyDictionary<object, int>();
            CombinedAnalysisHolders = new SortedProxyDictionary<object, int>();
        }

        protected override void PostParser(
            Post i_PostToAnalysis,
            ref SortedProxyDictionary<object, int> io_ArrayToAnalysisHolders)
        {
            const int k_LikeByUser = 1;
            try
            {
                foreach (User likedBy in i_PostToAnalysis.LikedBy)
                {
                    if (io_ArrayToAnalysisHolders.ContainsKey(likedBy))
                    {
                        io_ArrayToAnalysisHolders[likedBy] += k_LikeByUser;
                    }
                    else
                    {
                        io_ArrayToAnalysisHolders.Add(likedBy, k_LikeByUser);
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't get one post or more", e);
            }
        }

        public IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame = eTimeSelector.Month)
        {
            initializeComponents();
            AddByType(i_AnalysisUser, i_TimeFrame);

            return this;
        }
        #endregion
    }
}
