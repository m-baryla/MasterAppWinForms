using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterAppWinForms.HandlingPlugin
{
    public class VM_AvailablePlugins : System.Collections.CollectionBase
    {
        public void Add(M_AvailablePlugin pluginToAdd)
        {
            this.List.Add(pluginToAdd);
        }

        public void Remove(M_AvailablePlugin pluginToRemove)
        {
            this.List.Remove(pluginToRemove);
        }

        public M_AvailablePlugin Find(string pluginNameOrPath)
        {
            M_AvailablePlugin toReturn = null;

            foreach (M_AvailablePlugin pluginOn in this.List)
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
