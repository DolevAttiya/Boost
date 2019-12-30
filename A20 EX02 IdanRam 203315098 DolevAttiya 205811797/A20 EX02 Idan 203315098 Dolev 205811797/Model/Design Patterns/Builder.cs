/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns
{
    class Builder
    {
        public Post selector(User i_AnalysisUser, eTimeSelector i_TimeFrame, Post.eType i_Type, )
        {
            
            try
            {
                
                foreach (Post postToAnalysis in i_AnalysisUser.Posts)
                {
                    if (i_TimeFrame.GetHashCode() < DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                    {
                        break;
                    }

                    PostParser(postToAnalysis, ref this.m_CombinedAnalysisHolders);
                    switch (postToAnalysis.Type)
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
            catch (Exception e)
            {
                throw new Exception("Could not get post", e);
            }
        }
    }
}
*/