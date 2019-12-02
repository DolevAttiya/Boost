using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public abstract class Analysis
    {
        private Dictionary<object, int> m_PhotosDictionary;
        private Dictionary<object, int> m_VideosDictionary;
        private Dictionary<object, int> m_StatusDictionary;
        private Dictionary<object, int> m_CombinedAnalysisHolders;

        public Dictionary<object, int> PhotosDictionary
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }

        public Dictionary<object, int> VideosDictionary
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }

        public Dictionary<object, int> StatusDictionary
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }

        public Dictionary<object, int> CombinedAnalysisHolders
        {
            get => m_PhotosDictionary;
            protected set => m_PhotosDictionary = value;
        }


        protected void AddByType(User i_UserToDoAnalysisOn, eTimeSelector i_TimeFrame)
        {
            try
            {
                foreach(Post postToAnalysis in i_UserToDoAnalysisOn.Posts)
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
            ref Dictionary<object, int> io_ArrayToAnalysisHolders);
    }
}