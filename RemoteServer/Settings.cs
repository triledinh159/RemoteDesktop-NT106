using System.Windows.Forms;
using Microsoft.Win32;

namespace RemoteServer
{
    public class Settings
    {// This class is just used to share setting and to then save them to the registry
        public static bool FirstTime = true;
        public static string MainProgramName = "Remote desktop server";
        public static string Password = "letmein";
        public static Menu FormService = null;
        public static int Port = 4000;
        public static bool Debug = false;
        public static int ScreenServerX = 1920;
        public static int ScreenServerY = 1080;
        
        public static void LoadSettings()
        {
            Settings.FirstTime = bool.Parse(LoadSetting("FirstTime","true"));
            Settings.ScreenServerX = Screen.PrimaryScreen.Bounds.Width + 5;
            Settings.ScreenServerY = Screen.PrimaryScreen.Bounds.Height + 5;
            Settings.Port = int.Parse(LoadSetting("Port", "4000"));
            Settings.Password = LoadSetting("id", "letmein");
            Settings.ScreenServerX = int.Parse(LoadSetting("ScreenServerX", Settings.ScreenServerX.ToString()));
            Settings.ScreenServerY = int.Parse(LoadSetting("ScreenServerY", Settings.ScreenServerY.ToString()));
        }

        public static void SaveSettings()
        {
            SaveSetting("ScreenServerX", Settings.ScreenServerX.ToString());
            SaveSetting("ScreenServerY", Settings.ScreenServerY.ToString());
            SaveSetting("Port", Settings.Port.ToString());
            SaveSetting("id", Settings.Password);
            SaveSetting("FirstTime", Settings.FirstTime.ToString());
        }

        public static void SaveSetting(string Name, string Value)
        {
            try
            {
                RegistryKey Root = Registry.CurrentUser.CreateSubKey(MainProgramName);
                Root.SetValue(Name, Value);
            }
            catch { ;}
        }

        public static string LoadSetting(string Name, string Default)
        {
            try
            {
                RegistryKey Root = Registry.CurrentUser.CreateSubKey(MainProgramName);
                return Root.GetValue(Name)?.ToString() ?? Default;
            }
            catch
            {
                SaveSetting(Name, Default);
                return Default;
            }
        }
    }
}
