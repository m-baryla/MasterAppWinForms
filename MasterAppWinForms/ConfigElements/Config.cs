using System.Configuration;
using System.Windows.Forms;

namespace MasterAppWinForms.ConfigElements
{
    public static class Config
    {
        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.AppSettings.Get("sqlConnectionString");
        }

        public static string GetDllPath()
        {
            return Application.StartupPath  + ConfigurationManager.AppSettings.Get("dllsPath");
        }

        public static string GetIconsPath()
        {
            return Application.StartupPath  + ConfigurationManager.AppSettings.Get("iconsPath");
        }
    }
}
