using System;
using System.Windows.Forms;
using A20_EX03_Idan_203315098_Dolev_205811797.View;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Launcher
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Boost());
        }
    }
}
