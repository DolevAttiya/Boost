using System;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns;
using FacebookWrapper.ObjectModel;


namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public abstract class Analysis
    {
        #region Data Members
        private SortedValueDictionary<object, int> m_PhotosDictionary;
        private SortedValueDictionary<object, int> m_VideosDictionary;
        private SortedValueDictionary<object, int> m_StatusDictionary;
        private SortedValueDictionary<object, int> m_CombinedAnalysisHolders;
        #endregion

        #region Properties
        public SortedValueDictionary<object, int> PhotosDictionary
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }

        public SortedValueDictionary<object, int> VideosDictionary
        {
            get => m_VideosDictionary;
            protected set => m_VideosDictionary = value;
        }

        public SortedValueDictionary<object, int> StatusDictionary
        {
            get => m_StatusDictionary;
            protected set => m_StatusDictionary = value;
        }

        public SortedValueDictionary<object, int> CombinedAnalysisHolders
        {
            get => m_CombinedAnalysisHolders;
            protected set => m_CombinedAnalysisHolders = value;
        }
        #endregion

        #region Methods

        protected void AddByType(User i_AnalysisUser, eTimeSelector i_TimeFrame)
        {
            try
            {
                foreach(Post postToAnalysis in i_AnalysisUser.Posts)
                {
                    if(i_TimeFrame.GetHashCode() < DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                    {
                        break;
                    }

                    PostParser(postToAnalysis, ref this.m_CombinedAnalysisHolders);
                    switch(postToAnalysis.Type)
                    {
                        case Post.eType.status:
                            PostParser(postToAnalysis, ref this.m_StatusDictionary);
                            break;
                        case Post.eType.photo:
                            PostParser(postToAnalysis, ref this.m_PhotosDictionary);
                            break;
                        case Post.eType.video:
                            PostParser(postToAnalysis, ref this.m_VideosDictionary);
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Could not get post", e);
            }
        }


        public SortedValueDictionary<object, int> GetSpecificAnalysisCollection(
            eAnalysisDataBasis i_AnalysisDataBasis)
        {

            SortedValueDictionary<object, int> analysisCollection = null;

            switch (i_AnalysisDataBasis)
            {
                case eAnalysisDataBasis.Combined:
                    analysisCollection = this.CombinedAnalysisHolders;
                    break;
                case eAnalysisDataBasis.Photo:
                    analysisCollection = this.PhotosDictionary;
                    break;
                case eAnalysisDataBasis.Status:
                    analysisCollection = this.StatusDictionary;
                    break;
                case eAnalysisDataBasis.Video:
                    analysisCollection = this.VideosDictionary;
                    break;
            }

            return analysisCollection;
        }

        protected abstract void PostParser(
            Post i_PostToAnalysis,
            ref SortedValueDictionary<object, int> io_ArrayToAnalysisHolders);
        #endregion
    }
}