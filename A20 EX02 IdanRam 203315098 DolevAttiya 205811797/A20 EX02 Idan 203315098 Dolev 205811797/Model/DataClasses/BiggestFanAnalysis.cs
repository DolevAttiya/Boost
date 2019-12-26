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
            PhotosDictionary = new SortedDictionary<object, int>();
            VideosDictionary = new SortedDictionary<object, int>();
            StatusDictionary = new SortedDictionary<object, int>();
            CombinedAnalysisHolders = new SortedDictionary<object, int>();
        }

        protected override void PostParser(
            Post i_PostToAnalysis,
            ref SortedDictionary<object, int> io_ArrayToAnalysisHolders)
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
