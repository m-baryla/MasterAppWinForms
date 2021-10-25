namespace PluginInterface
{
    public class AvailablePlugins : System.Collections.CollectionBase
    {
        public void Add(AvailablePlugin pluginToAdd)
        {
            this.List.Add(pluginToAdd);
        }

        public void Remove(AvailablePlugin pluginToRemove)
        {
            this.List.Remove(pluginToRemove);
        }

        public AvailablePlugin Find(string pluginNameOrPath)
        {
            AvailablePlugin toReturn = null;

            foreach (AvailablePlugin pluginOn in this.List)
            {
                if ((pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath))
                {
                    toReturn = pluginOn;
                    break;
                }
            }
            return toReturn;
        }
    }
}
