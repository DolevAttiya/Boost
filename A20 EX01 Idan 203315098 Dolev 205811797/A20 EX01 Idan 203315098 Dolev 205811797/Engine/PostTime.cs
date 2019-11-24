using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
{
    public class PostTime
    {
        public DateTime Time { get; set; }
        public int Likes { get; set; }

        public PostTime()
        {
            Likes = 0;
        }
    }
}
