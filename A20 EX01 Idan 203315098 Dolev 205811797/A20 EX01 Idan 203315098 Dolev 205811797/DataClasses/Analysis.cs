using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{

    public abstract class Analysis
    {
        public Analysis()
        {
            const int k_NumberDaysOfWeek = 7;
            const int k_NumberHoursADay = 24;
            const int k_MinutesAndSecond = 0;
            PhotosMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            VideosMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            PostsMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            CombinedAnalysisHolders = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];

            for(int days = 0; days < k_NumberDaysOfWeek; days++)
            {
                for(int hour = 0; hour < k_NumberHoursADay; hour++)
                {

                    PhotosMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    VideosMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    PostsMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    CombinedAnalysisHolders[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                }
            }
        }

        public AnalysisHolder[,] PhotosMatrix { get; }

        public AnalysisHolder[,] VideosMatrix { get; }

        public AnalysisHolder[,] PostsMatrix { get; }

        public AnalysisHolder[,] CombinedAnalysisHolders { get; }

        public void AddLikesSchedule(TimerSelector i_Time)
        {
            LoginResult result = FacebookWrapper.FacebookService.Login(
                "748532218946260",
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

            User loggedInUser = result.LoggedInUser;
            foreach(Post postToAnalysis in loggedInUser.Posts)
            {
                if(postToAnalysis.CreatedTime != null)
                {
                    PostsMatrix[(int)postToAnalysis.CreatedTime.Value.DayOfWeek,
                        postToAnalysis.CreatedTime.Value.Hour].AddLikes(postToAnalysis.LikedBy.Count);
                    CombinedAnalysisHolders[(int)postToAnalysis.CreatedTime.Value.DayOfWeek,
                        postToAnalysis.CreatedTime.Value.Hour].AddLikes(postToAnalysis.LikedBy.Count);
                }
            }

            /*foreach (Album albumToAnalaysis in loggedInUser.Albums)
            {
                foreach(var VARIABLE in albumToAnalaysis.Pictures)
                {
                    
                }
                PostsArrayList[(int)postToAnalaysis.CreatedTime.Value.DayOfWeek,
                        postToAnalaysis.CreatedTime.Value.Hour]
                    .AddLikes(postToAnalaysis.LikedBy.Count);
                CombinedAnalysisHolders[(int)postToAnalaysis.CreatedTime.Value.DayOfWeek,
                        postToAnalaysis.CreatedTime.Value.Hour]
                    .AddLikes(postToAnalaysis.LikedBy.Count);
            }*/
            foreach(Video videoToAnalysis in loggedInUser.Videos)
            {
                if(videoToAnalysis.CreatedTime != null)
                {
                    VideosMatrix[(int)videoToAnalysis.CreatedTime.Value.DayOfWeek,
                        videoToAnalysis.CreatedTime.Value.Hour].AddLikes(videoToAnalysis.LikedBy.Count);
                    CombinedAnalysisHolders[(int)videoToAnalysis.CreatedTime.Value.DayOfWeek,
                        videoToAnalysis.CreatedTime.Value.Hour].AddLikes(videoToAnalysis.LikedBy.Count);
                }
            }
        }
    }

    public enum TimerSelector
    {
    Day = 7,
    Month=31,
    Year=365
    }
}
    


