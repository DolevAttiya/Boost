
namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class BiggestFan
    {
        public string Name { get; set; }

        public int Likes { get; set; }

        public int Ranking { get; set; }

        public BiggestFan()
        {
            Name = "0";
            Likes = -1;
            Ranking = 0;
        }
    }
}