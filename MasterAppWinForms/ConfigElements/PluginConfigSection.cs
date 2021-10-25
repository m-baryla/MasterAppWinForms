using System.Configuration;

namespace MasterAppWinForms.ConfigElements
{
    public class PluginConfigSection: ConfigurationSection
    {
        [ConfigurationProperty("Plugin")]
        public PluginCollection PluginItems
        {
            get { return ((PluginCollection)(base["Plugin"])); }
        }
        
    }
}
