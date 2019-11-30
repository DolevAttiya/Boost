using System;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.GUI;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Launcher
{
    static class Program
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
