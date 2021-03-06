using System;
using System.IO;
using Westwind.Utilities;

namespace WebSurge
{
    public class App
    {
        public static WebSurgeConfiguration Configuration { get; set; }

        public static string UserDataPath { get; set; }
        public static string LogFile { get; set; }
        public static string VersionCheckUrl { get; set; }
        public static string InstallerDownloadUrl { get; set; }
        public static string WebHomeUrl { get; set; }
        public bool ReloadTemplates { get; set; }

        internal static string EncryptionMachineKey { get; set; }
        internal static string ProKey { get; set; }

        static App()
        {
            UserDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                           "\\West Wind WebSurge\\";
            if (!Directory.Exists(UserDataPath))
                Directory.CreateDirectory(UserDataPath);

            LogFile = UserDataPath + "WebSurgeErrors.log";
            VersionCheckUrl = "http://west-wind.com/files/WebSurge_Version.xml";
            InstallerDownloadUrl = "http://west-wind.com/files/WebsurgeSetup.exe";
            WebHomeUrl = "http://west-wind.com/websurge";

            Configuration = new WebSurgeConfiguration();
            Configuration.Initialize();
            
            // Encryption key is only valid on the current machine
            EncryptionMachineKey = "22653K0U*He73kj4$JJ" + Environment.MachineName;
            ProKey = "Kuhela_100";  // "3bd0f6e";
        }


        /// <summary>
        /// Logs exceptions in the applications
        /// </summary>
        /// <param name="ex"></param>
        public static void Log(Exception ex)
        {
            ex = ex.GetBaseException();

            var msg = ex.Message + "\r\n---\r\n" + ex.Source + "\r\n" + ex.StackTrace + "\r\n";
            Log(msg);
        }

        /// <summary>
        /// Logs messages to the log file
        /// </summary>
        /// <param name="msg"></param>
        public static void Log(string msg)
        {
            var text = msg +
                       "\r\n\r\n---------------------------\r\n\r\n";
            StringUtils.LogString(msg, UserDataPath + "WebSurgeErrors.log");
        }
    }
}