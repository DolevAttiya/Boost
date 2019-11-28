using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class BoostEngine
    {
        public const int k_TopNumber = 10;
        
        public static User LoggedInUser { get; set; }

        public IAnalysis TimeAnalysis {  get;private set;  }

        public IAnalysis TopFansAnalysis { get; private set; }

        public BoostEngine()
        {
            LoginResult result = FacebookService.Login(
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
            TimeAnalysis = new TimeAnalysis();
            TopFansAnalysis = new TopFanAnalysis();
            LoggedInUser = loggedInUser;
        }
    }
}
