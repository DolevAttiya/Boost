using System;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public class Engagement
    {
        #region Properties
        public DateTime TimePosted { get; set; }

        public int LikeCount { get; set; }

        public int CommentCount { get; set; }
        #endregion

        #region Ctor
        public Engagement(FacebookWrapper.ObjectModel.Post i_Post)
        {
            TimePosted = (DateTime)i_Post.CreatedTime;
            LikeCount = i_Post.LikedBy.Count;
            CommentCount = i_Post.Comments.Count;
        }
        #endregion
    }
}
