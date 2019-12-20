using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model
{
    public class BoostSettings
    {
        #region Data Members & Properties
        public bool FirstLogin { get; set; }

        public bool RememberUser { get; set; }

        public DateTime? LastLogin { get; set; }

        public string LastAccessToken { get; set; }

        public string LastLoggedInEmail { get; set; }

        public string StartupPath { get; set; }
        
        public List<DateAndValue> FriendCounter;

        private static string m_FilePath = string.Format(@"{0}\BoostSettings.xml", Application.StartupPath);
        #endregion

        #region Ctor
        private BoostSettings()
        {
            //FirstLogin = true;
            //LastAccessToken = null;
            //RememberUser = false;
            //LastLogin = null;
            //StartupPath = Application.StartupPath;
            //FriendCounter = new List<DateAndValue>();
            ResetSettingsToDefault();
        }
        #endregion

        #region Methods
        public void ResetSettingsToDefault()
        {
            FirstLogin = true;
            LastAccessToken = null;
            RememberUser = false;
            LastLogin = null;
            StartupPath = Application.StartupPath;
            FriendCounter = new List<DateAndValue>();
        }

        public static BoostSettings LoadAppSettingsFromFile()
        {
            BoostSettings appSettings = null;

            if (File.Exists(m_FilePath))
            {
                try
                {
                    using (Stream stream = new FileStream(m_FilePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(BoostSettings));
                        appSettings = serializer.Deserialize(stream) as BoostSettings;
                    }
                }
                catch
                {
                    File.Delete(m_FilePath);
                    appSettings = new BoostSettings();
                    createNewFile();
                }
            }
            else
            {
                appSettings = new BoostSettings();
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

        public void DeleteAppSettingsFile()
        {
            File.Delete(m_FilePath);
        }
        

        public bool IsFirstLogin()
        {
            if(LastLogin != null)
            {
                FirstLogin = false;
            }

            return FirstLogin;
        }
        #endregion
    }
}
