using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public class AppSettings
    {
        public bool RemeberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RemeberUser = false;
            LastAccessToken = null;
        }
    }
}
