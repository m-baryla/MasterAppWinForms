using System.Configuration;

namespace MasterAppWinForms.ConfigElements
{
    public class PluginCollection:ConfigurationElementCollection
    {
        public PluginElement this[int idx]
        {
            get { return (PluginElement) BaseGet(idx); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new PluginElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PluginElement) (element)).PluginName;
        }
    }
}
