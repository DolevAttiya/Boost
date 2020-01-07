using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using static System.Environment;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model
{
    public class BoostSettings
    {
        #region Data Members & Properties

        // App Settings
        public bool FirstLogin { get; set; }

        public DateTime? LastLogin { get; set; }

        public string LastAccessToken { get; set; }

        public string LastLoggedInEmail { get; set; }

        public string LastUsedVersion { get; set; }

        public string StartupPath { get; set; }

        private static string s_FilePath =
            $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}\BoostSettings.xml";

        // User Settings
        public string FirstName { get; set; }

        public bool RememberUser { get; set; }

        public eTimeFrame DefaultAnalysisTimeFrame { get; set; }

        public eAnalysisDataBasis DefaultAnalysisDataBasis { get; set; }

        public List<DateAndValue> FriendCounter;

        #endregion

        #region Ctor

        private BoostSettings()
        {
            ResetSettingsToDefault();
        }

        #endregion

        #region Methods

        public static BoostSettings LoadAppSettingsFromFile()
        {
            BoostSettings appSettings = null;

            try
            {
                if(File.Exists(s_FilePath))
                {
                    try
                    {
                        using(Stream stream = new FileStream(s_FilePath, FileMode.Open))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(BoostSettings));
                            appSettings = serializer.Deserialize(stream) as BoostSettings;
                        }
                    }
                    catch
                    {
                        File.Delete(s_FilePath);
                        appSettings = new BoostSettings();
                        createNewFile();
                    }
                }
                else
                {
                    appSettings = new BoostSettings();
                    createNewFile();
                }
            }
            catch(UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }

            return appSettings;
        }

        public void ResetSettingsToDefault()
        {
            FirstName = null;
            FirstLogin = true;
            LastAccessToken = null;
            RememberUser = false;
            LastLogin = null;
            LastUsedVersion = null;
            StartupPath = Application.StartupPath;
            FriendCounter = new List<DateAndValue>();
            DefaultAnalysisTimeFrame = eTimeFrame.Month;
            DefaultAnalysisDataBasis = eAnalysisDataBasis.Combined;
        }

        public void SaveAppSettingsToFile()
        {
            if(!File.Exists(s_FilePath))
            {
                createNewFile();
            }

            using(Stream streamSave = new FileStream(s_FilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(streamSave, this);
            }
        }

        private static void createNewFile()
        {
            Stream streamCreateNew = new FileStream(s_FilePath, FileMode.CreateNew);
            streamCreateNew.Close();
        }

        public void DeleteAppSettingsFile()
        {
            try
            {
                if(File.Exists(s_FilePath))
                {
                    File.Delete(s_FilePath);
                }
            }
            catch(UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IsFirstLogin(string i_CurrentUserEmail)
        {
            if(LastLogin != null)
            {
                if(i_CurrentUserEmail != LastLoggedInEmail)
                {
                    LastLogin = null;
                    FirstLogin = true;
                }
                else
                {
                    FirstLogin = false;
                }
            }

            return FirstLogin;
        }

        #endregion
    }
}