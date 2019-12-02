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


        protected void AddByType(User i_UserToDoAnalysisOn, eTimeSelector i_TimeFrame)
        {
            try
            {
                foreach (Post postToAnalysis in i_UserToDoAnalysisOn.Posts)
                {

                    if (i_TimeFrame.GetHashCode() < DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                    {
                        break;
                    }

                    CombinedAnalysisHolders = PostParser(postToAnalysis, CombinedAnalysisHolders); // TODO
                    switch (postToAnalysis.Type)
                    {
                        case Post.eType.status:
                            StatusDictionary = PostParser(postToAnalysis, StatusDictionary); // TODO
                            break;
                        case Post.eType.photo:
                            PhotosDictionary = PostParser(postToAnalysis, PhotosDictionary); // TODO
                            break;
                        case Post.eType.video:
                            VideosDictionary = PostParser(postToAnalysis, VideosDictionary); // TODO
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't Get Post",e);
            }
            
        }

        protected abstract Dictionary<object, int> PostParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_ArrayToAnalysisHolders);
    }
}