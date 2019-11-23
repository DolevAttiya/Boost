using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{

    public abstract class Analysis
    {
        protected Analysis()
        {
            const int k_NumberDaysOfWeek = 7;
            const int k_NumberHoursADay = 24;
            const int k_MinutesAndSecond = 0;
            PhotosMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            VideosMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            StatusMatrix = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];
            CombinedAnalysisHolders = new AnalysisHolder[k_NumberDaysOfWeek, k_NumberHoursADay];

            for(int days = 0; days < k_NumberDaysOfWeek; days++)
            {
                for(int hour = 0; hour < k_NumberHoursADay; hour++)
                {
                    // Created At that exact time in order to match the days of the week (Sunday - Saturday ) with the date: Sunday = 1 Monday= 2 etc.
                    PhotosMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    VideosMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    StatusMatrix[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                    CombinedAnalysisHolders[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, k_MinutesAndSecond, k_MinutesAndSecond));
                }
            }
        }

        public AnalysisHolder[,] PhotosMatrix { get; private set; }

        public AnalysisHolder[,] VideosMatrix { get; private set; }

        public AnalysisHolder[,] StatusMatrix { get; private set; }

        public AnalysisHolder[,] CombinedAnalysisHolders { get; private set; }

        public void AddLikesSchedule(eTimerSelector i_TimeToStrict)
        {
             
            LoginResult result = FacebookWrapper.FacebookService.Login( /*TODO*/
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

            User loggedInUser = result.LoggedInUser; //TODO
            foreach(Post postToAnalysis in loggedInUser.Posts)
            {
                postsParser(i_TimeToStrict, postToAnalysis, CombinedAnalysisHolders);
                switch(postToAnalysis.Type)
                {
                    case Post.eType.status:
                        StatusMatrix = postsParser(i_TimeToStrict, postToAnalysis, StatusMatrix);// TODO
                        break;
                    case Post.eType.photo:
                        PhotosMatrix = postsParser(i_TimeToStrict, postToAnalysis, PhotosMatrix);
                        break;
                    case Post.eType.video:
                        VideosMatrix = postsParser(i_TimeToStrict, postToAnalysis, VideosMatrix);
                        break;
                }
            }
        }

        private AnalysisHolder[,] postsParser(
            eTimerSelector i_TimeSelector,
            Post i_PostToAnalysis,
            AnalysisHolder[,] io_MatrixToAnalysisHolders)
        {
            DateTime timeIndicator = DateTime.Now;
            timeIndicator.AddDays((-1) * double.Parse(i_TimeSelector.ToString())); //TODO 
            if(i_PostToAnalysis.CreatedTime != null)
            {
                if(timeIndicator.CompareTo(i_PostToAnalysis.CreatedTime.Value.Date) >= 0)
                {
                    io_MatrixToAnalysisHolders[(int)i_PostToAnalysis.CreatedTime.Value.DayOfWeek,
                        i_PostToAnalysis.CreatedTime.Value.Hour].AddLikes(i_PostToAnalysis.LikedBy.Count);
                    CombinedAnalysisHolders[(int)i_PostToAnalysis.CreatedTime.Value.DayOfWeek,
                        i_PostToAnalysis.CreatedTime.Value.Hour].AddLikes(i_PostToAnalysis.LikedBy.Count);
                }
            }

            return io_MatrixToAnalysisHolders;
        }

    }
}
    


