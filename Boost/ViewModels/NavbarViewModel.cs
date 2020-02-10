using Boost.Model;

namespace Boost.ViewModels
{
    public class NavbarViewModel
    {
        public string UserRealName { get; set; }

        public string PictureSmallURL { get; set; }

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        public void FetchData()
        {
            UserRealName = r_BoostEn.LoggedInUser.Name;
            PictureSmallURL = r_BoostEn.LoggedInUser.PictureSmallURL;
        }
    }
}
