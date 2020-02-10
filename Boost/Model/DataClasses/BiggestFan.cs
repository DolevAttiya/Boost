namespace Boost.Model.DataClasses
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