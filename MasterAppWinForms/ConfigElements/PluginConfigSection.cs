using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
