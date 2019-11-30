using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine
{
    public class AppSettings
    {
        public bool FirstLogin { get; set; }

        public bool RememberUser { get; set; }

        public DateTime? LastLogin { get; set; }

        public string LastAccessToken { get; set; }

        public string LastLoggedInEmail { get; set; }

        public string StartupPath { get; set; }
        
        public List<DateAndValue> FriendCounter;

        private static string m_FilePath = string.Format(@"{0}\boostAppSettings.xml", Application.StartupPath);

        private AppSettings()
        {
            FirstLogin = true;
            LastAccessToken = null;
            RememberUser = false;
            LastLogin = null;
            StartupPath = Application.StartupPath;
            FriendCounter = new List<DateAndValue>();
        }

        public static AppSettings LoadAppSettingsFromFile()
        {
            AppSettings appSettings = null;

            if (File.Exists(m_FilePath))
            {
                try
                {
                    using (Stream stream = new FileStream(m_FilePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                appSettings = new AppSettings();
                createNewFile();
            }

            return appSettings;
        }

        public void SaveAppSettingsToFile()
        {
            if (!File.Exists(m_FilePath))
            {
                createNewFile();
            }

            using (Stream streamSave = new FileStream(m_FilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(streamSave, this);
            }
        }

        private static void createNewFile()
        {
            Stream streamCreateNew = new FileStream(m_FilePath, FileMode.CreateNew);
            streamCreateNew.Close();
        }

        public bool IsFirstLogin()
        {
            if(LastLogin != null)
            {
                FirstLogin = false;
            }

            return FirstLogin;
        }
    }
}
