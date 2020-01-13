using A20_EX03_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX03_Idan_203315098_Dolev_205811797.ViewModels
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
