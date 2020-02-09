using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Boost.View
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

        public static void centerControlHorizontally(this Control i_Control, UserControl i_Client)
        {
            i_Control.Left = (i_Client.Width - i_Control.Width) / 2;
        }

        public static void addSubPagesToList(this Control i_Container, List<UserControl> i_PageList)
        {
            foreach (FieldInfo field in i_Container.GetType().GetFields())
            { // TODO - consider removing strategy
                if (!field.FieldType.Name.Contains("View"))
                {
                    continue;
                }

                if (field.Name.Contains("Page"))
                {
                    i_PageList.Add((UserControl)field.GetValue(i_Container));
                }
            }
        }
    }
}
