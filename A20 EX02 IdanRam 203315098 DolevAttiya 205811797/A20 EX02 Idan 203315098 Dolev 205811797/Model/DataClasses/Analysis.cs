using System;
using FacebookWrapper.ObjectModel;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public abstract class Analysis
    {
        #region Data Members
        private SortedProxyDictionary<object, int> m_PhotosDictionary;
        private SortedProxyDictionary<object, int> m_VideosDictionary;
        private SortedProxyDictionary<object, int> m_StatusDictionary;
        private SortedProxyDictionary<object, int> m_CombinedAnalysisHolders;

        public enum eAnalysisDataBasis
        {
            Combined,
            Status,
            Photo,
            Video
        }
        #endregion

        #region Properties
        public SortedProxyDictionary<object, int> PhotosDictionary
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }

        public SortedProxyDictionary<object, int> VideosDictionary
        {
            get => m_VideosDictionary;
            protected set => m_VideosDictionary = value;
        }

        public SortedProxyDictionary<object, int> StatusDictionary
        {
            get => m_StatusDictionary;
            protected set => m_StatusDictionary = value;
        }

        public SortedProxyDictionary<object, int> CombinedAnalysisHolders
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
                throw new Exception("Couldn't Get Post", e);
            }
        }

        protected abstract void PostParser(
            Post i_PostToAnalysis,
            ref SortedProxyDictionary<object, int> io_ArrayToAnalysisHolders);
        #endregion
    }
}