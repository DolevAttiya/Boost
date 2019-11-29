using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
{
    public class BoostEngine
    {

        private const int k_CollectionLimit = 50;//Login method
        public const int k_TopNumber = 3;
        private const string k_AppId = "748532218946260";


        public User LoggedInUser { get; set; }

        public IAnalysis TimeAnalysis { get; private set; }

        public IAnalysis TopFansAnalysis { get; private set; }

        public BoostEngine()
        {
            TimeAnalysis = new TimeAnalysis();
            TopFansAnalysis = new TopFanAnalysis();
        }

        public void FacebookLogin()
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            LoginResult loginResult;
            User o_LoggedInUser = null;
            try
            {
                loginResult = FacebookService.Login(
                    k_AppId,
                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "publish_to_groups",
                    "groups_access_member_info",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            if(!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                o_LoggedInUser = loginResult.LoggedInUser;
            }

            LoggedInUser = o_LoggedInUser;
        }

        public Post GetLastStatus()
        {
            Post o_LastStatus = null;
            foreach(Post postToSearch in LoggedInUser.Posts)
            {
                if(postToSearch.Type == Post.eType.status && postToSearch.Message != null)
                {
                    o_LastStatus = postToSearch;
                    break;
                }
            }

            return o_LastStatus;
        }

        public Post GetTopPost()
        {
            Post mostLikedPost = null;
            const int k_PostMaxCount = 25;
            int topLikes=0,postSearchLimiter = 0;//Cause facebook does not let see the likes

            if (LoggedInUser.Posts[0] != null)
            {
                topLikes = LoggedInUser.Posts[0].LikedBy.Count;
                mostLikedPost = LoggedInUser.Posts[0];//Cause facebook does not let see the likes
            }

            foreach (Post post in LoggedInUser.Posts)
            {
                if(post == null || k_PostMaxCount< postSearchLimiter++)

                {
                    break;
                }
                else
                {
                    if(post.LikedBy.Count < topLikes)
                    {
                        continue;
                    }
                }

                topLikes = post.LikedBy.Count;
                mostLikedPost = post;
            }

            return mostLikedPost;
        }
    }
}
