using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
{
    public class BoostEngine
    {
        private const int k_CollectionLimit = 50; ////Login method
        public const int k_NumOfBiggestFans = 3;
        public const int k_NumOfFriendCounters = 3;
        private const string k_AppId = "748532218946260";
        public AppSettings m_AppSettings = AppSettings.LoadAppSettingsFromFile();

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public IAnalysis TimeAnalysis { get; private set; }

        public IAnalysis BiggestFansAnalysis { get; private set; }

        public BoostEngine()
        {
            TimeAnalysis = new TimeAnalysis();
            BiggestFansAnalysis = new BiggestFanAnalysis();
        }

        public void FacebookLogin(string i_AccessToken, bool i_RememberUser)
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            User o_LoggedInUser = null;
            if (i_AccessToken != null && i_RememberUser == true)
            {
                try
                {
                    LoginResult = FacebookService.Connect(i_AccessToken);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    LoginResult = FacebookService.Login(
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            if(!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                o_LoggedInUser = LoginResult.LoggedInUser;
            }

            LoggedInUser = o_LoggedInUser;
        }

        public Post GetLastStatus()
        {
            Post o_LastStatus = null;
            foreach(Post postToSearch in LoggedInUser.Posts)
            {
                if(postToSearch == null)
                {
                    continue;
                }

                if(postToSearch.Type == Post.eType.status && postToSearch.Message != null)
                {
                    o_LastStatus = postToSearch;
                    break;
                }
            }

            return o_LastStatus;
        }

        public void FriendCountSetup()
        {
            DateAndValue friendCount = new DateAndValue();

            friendCount.Value = LoggedInUser.Friends.Count;
            friendCount.Date = DateTime.Now;

            if (m_AppSettings.FriendCounter.Count < 1)
            {
                m_AppSettings.FriendCounter.Add(friendCount);
            }
            else
            {
                if(LoggedInUser.Friends.Count != m_AppSettings.FriendCounter[m_AppSettings.FriendCounter.Count - 1].Value)
                {
                    m_AppSettings.FriendCounter.Add(friendCount);

                    if(m_AppSettings.FriendCounter.Count > k_NumOfFriendCounters)
                    {
                        m_AppSettings.FriendCounter.RemoveAt(0);
                    }
                }
            } 
        }

        public Post GetTopPost()
        {
            Post mostLikedPost = null;
            const int k_PostMaxCount = 25;
            int topLikes = 0, postSearchLimiter = 0; ////Cause Facebook does not let see the likes

            if(LoggedInUser.Posts[0] != null)
            {
                topLikes = LoggedInUser.Posts[0].LikedBy.Count;
                mostLikedPost = LoggedInUser.Posts[0]; ////Cause Facebook does not let see the likes
            }

            foreach(Post post in LoggedInUser.Posts)
            {
                if(post == null || k_PostMaxCount < postSearchLimiter++)
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

            if(mostLikedPost == null)
            {
                throw new NullReferenceException("Couldn't get the Top Post");
            }

            return mostLikedPost;
        }
    }
}
