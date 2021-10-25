using System.Configuration;

namespace MasterAppWinForms.ConfigElements
{
    public class PluginElement: ConfigurationElement
    {
        [ConfigurationProperty("pluginName", DefaultValue = "",IsKey = true,IsRequired = true)]
        public string PluginName
        {
            get { return ((string) (base["pluginName"])); }
            set { base["pluginName"] = value; }
        }
        [ConfigurationProperty("nameIco", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string IcoName
        {
            get { return ((string)(base["nameIco"])); }
            set { base["nameIco"] = value; }
        }
    }
}
