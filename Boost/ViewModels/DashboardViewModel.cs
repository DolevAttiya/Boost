using System;
using System.Collections.Generic;
using Boost.Model;
using Boost.Model.DataClasses;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace Boost.ViewModels
{
    public class DashboardViewModel
    {
        public string UserRealName { get; set; }

        public string PictureLargeURL { get; set; }

        public string UserLocation { get; set; }

        public int FriendsUsingBoost { get; set; }

        public List<DateAndValue> FriendCounter { get; set; }

        public bool? Verified { get; set; }

        public Post LastStatus { get; set; }

        public Post TopPost { get; set; }

        public int FriendChange { get; set; }

        public DateAndValue[] EngagementRecentPostLikes { get; set; }

        public DateAndValue[] EngagementRecentPostComments { get; set; }

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        private const int k_NumOfFriendCounters = 3;

        public readonly string R_PostErrorMessage = "Could not get post!";

        public readonly int R_NumOfPostsForEngagement = 10;

        public void FetchData()
        {
            try
            {
                UserRealName = r_BoostEn.LoggedInUser.Name;
                PictureLargeURL = r_BoostEn.LoggedInUser.PictureLargeURL;
                UserLocation = r_BoostEn.LoggedInUser.Location.Name;
                FriendsUsingBoost = r_BoostEn.LoggedInUser.Friends.Count;
                FriendCounter = r_BoostEn.m_BoostSettings.FriendCounter;
                Verified = r_BoostEn.LoggedInUser.Verfied;
                LastStatus = r_BoostEn.GetLastStatus();
                TopPost = r_BoostEn.GetTopPost();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void FriendCountSetup()
        {
            try
            {
                DateAndValue friendCount =
                    new DateAndValue { Value = r_BoostEn.LoggedInUser.Friends.Count, Date = DateTime.Now };
                if(r_BoostEn.m_BoostSettings.FriendCounter.Count < 1)
                {
                    r_BoostEn.m_BoostSettings.FriendCounter.Add(friendCount);
                }
                else
                {
                    if(r_BoostEn.LoggedInUser.Friends.Count != r_BoostEn.m_BoostSettings
                           .FriendCounter[r_BoostEn.m_BoostSettings.FriendCounter.Count - 1].Value)
                    {
                        r_BoostEn.m_BoostSettings.FriendCounter.Add(friendCount);

                        if(r_BoostEn.m_BoostSettings.FriendCounter.Count > k_NumOfFriendCounters)
                        {
                            r_BoostEn.m_BoostSettings.FriendCounter.RemoveAt(0);
                        }
                    }

                    if(r_BoostEn.m_BoostSettings.FriendCounter.Count > 1)
                    {
                        FriendChange =
                            r_BoostEn.m_BoostSettings.FriendCounter[r_BoostEn.m_BoostSettings.FriendCounter.Count - 1]
                                .Value - r_BoostEn.m_BoostSettings
                                .FriendCounter[r_BoostEn.m_BoostSettings.FriendCounter.Count - 2].Value;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't get user's friends", e);
            }
        }

        public void EngagementArraySetup()
        {
            EngagementRecentPostLikes = new DateAndValue[R_NumOfPostsForEngagement];
            EngagementRecentPostComments = new DateAndValue[R_NumOfPostsForEngagement];

            for(int i = R_NumOfPostsForEngagement - 1; i >= 0; i--)
            {
                EngagementRecentPostLikes[i] = new DateAndValue();
                EngagementRecentPostComments[i] = new DateAndValue();
                try
                {
                    EngagementRecentPostLikes[i].Value = r_BoostEn.LoggedInUser.Posts[i].LikedBy.Count;
                    EngagementRecentPostComments[i].Value = r_BoostEn.LoggedInUser.Posts[i].Comments.Count;
                }
                catch(Exception e)
                {
                    throw new FacebookApiException(R_PostErrorMessage, e);
                }

                if(r_BoostEn.LoggedInUser.Posts[i].CreatedTime.HasValue)
                {
                    try
                    {
                        EngagementRecentPostComments[i].Date = r_BoostEn.LoggedInUser.Posts[i].CreatedTime.Value;
                        EngagementRecentPostLikes[i].Date = r_BoostEn.LoggedInUser.Posts[i].CreatedTime.Value;
                    }
                    catch(Exception e)
                    {
                        throw new FacebookApiException(R_PostErrorMessage, e);
                    }
                }
            }
        }
    }
}
