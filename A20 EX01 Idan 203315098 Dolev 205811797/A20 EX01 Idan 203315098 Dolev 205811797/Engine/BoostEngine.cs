using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;
using Facebook;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
{
    public class BoostEngine 
    {
        #region Data Members & Properties
        #region Data Members
        private const int k_CollectionLimit = 50; //For Login method

        public const int k_NumOfBiggestFans = 3;

        public const int k_NumOfFriendCounters = 3;

        public const int k_NumOfPostsForEngagement = 10;

        private const string k_AppId = "748532218946260";

        public BoostSettings m_BoostSettings = BoostSettings.LoadAppSettingsFromFile();

        public const string k_PostErrorMessage = "Could not get Post!";
        #endregion

        #region Properties
          
        public int FriendChange { get; set; }
    
        public DateAndValue[] EngagementRecentPostLikes { get; set; }

        public DateAndValue[] EngagementRecentPostComments { get; set; }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public IAnalysis TimeAnalysis { get; }

        public IAnalysis BiggestFanAnalysis { get; }
        #endregion
        
        #endregion


        #region Ctor
        public BoostEngine()
        {
            TimeAnalysis = new TimeAnalysis();
            BiggestFanAnalysis = new BiggestFanAnalysis();
            FriendChange= 0;
        }
        #endregion

        #region Methods
        public void FacebookLogin(string i_AccessToken, bool i_RememberUser)
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            User o_LoggedInUser = null;
            if (i_AccessToken != null && i_RememberUser)
            {
                try
                {
                    LoginResult = FacebookService.Connect(i_AccessToken);
                }
                catch (Exception e)
                {
                    throw new FacebookApiException("Couldn't Connect",e);
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
                    throw new FacebookApiException("Couldn't Login",e);
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
            try
            {
                DateAndValue friendCount = new DateAndValue { Value = LoggedInUser.Friends.Count, Date = DateTime.Now };
                if(m_BoostSettings.FriendCounter.Count < 1)
                {
                    m_BoostSettings.FriendCounter.Add(friendCount);
                }
                else
                {
                    if(LoggedInUser.Friends.Count
                       != m_BoostSettings.FriendCounter[m_BoostSettings.FriendCounter.Count - 1].Value)
                    {
                        m_BoostSettings.FriendCounter.Add(friendCount);

                        if(m_BoostSettings.FriendCounter.Count > k_NumOfFriendCounters)
                        {
                            m_BoostSettings.FriendCounter.RemoveAt(0);
                        }
                    }

                    if(m_BoostSettings.FriendCounter.Count > 1)
                    {
                        FriendChange = m_BoostSettings.FriendCounter[m_BoostSettings.FriendCounter.Count - 1].Value
                                       - m_BoostSettings.FriendCounter[m_BoostSettings.FriendCounter.Count - 2].Value;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't get User's Friends", e);
            }
        }

        public void SetupEngagementArrays()
        {
            EngagementRecentPostLikes = new DateAndValue[k_NumOfPostsForEngagement];
            EngagementRecentPostComments = new DateAndValue[k_NumOfPostsForEngagement];

            for(int i = k_NumOfPostsForEngagement - 1; i >= 0; i--)
            {
                EngagementRecentPostLikes[i] = new DateAndValue();
                EngagementRecentPostComments[i] = new DateAndValue();
                try
                {
                    EngagementRecentPostLikes[i].Value = LoggedInUser.Posts[i].LikedBy.Count;
                    EngagementRecentPostComments[i].Value = LoggedInUser.Posts[i].Comments.Count;
                }
                catch(Exception e)
                {
                    throw new FacebookApiException(k_PostErrorMessage, e);
                }

                if(LoggedInUser.Posts[i].CreatedTime.HasValue)
                {
                    try
                    {
                        EngagementRecentPostComments[i].Date = LoggedInUser.Posts[i].CreatedTime.Value;
                        EngagementRecentPostLikes[i].Date = LoggedInUser.Posts[i].CreatedTime.Value;
                    }
                    catch(Exception e)
                    {
                        throw new FacebookApiException(k_PostErrorMessage, e);
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
                throw new NullReferenceException(k_PostErrorMessage);
            }

            return mostLikedPost;
        }

        public static KeyValuePair<object, int>[] SortedSelectedDictionary(Dictionary<object, int> i_DictionaryToSort)
        {
             KeyValuePair<object, int>[] o_SortedDictionaryValues = i_DictionaryToSort.ToArray();
            
            Array.Sort(o_SortedDictionaryValues, (pair1, pair2) => pair1.Value.CompareTo((pair2.Value)));
            return o_SortedDictionaryValues;
        }
              #endregion
    }
}
