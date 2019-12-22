using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public static class UITools
    {
        public static void displayHTMLPage(WebBrowser i_WebBrowser, string i_ResourceName)
        {
            string filePath = getFilepath(i_ResourceName);

            if (System.IO.File.Exists(filePath))
            {
                Uri uri = new Uri(filePath);
                i_WebBrowser.ScriptErrorsSuppressed = true;
                i_WebBrowser.Navigate(uri);
            }
        }

        private static string getFilepath(string i_ResourceName)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, string.Format("Resources\\{0}.html", i_ResourceName));

            return filePath;
        }
    }
}
