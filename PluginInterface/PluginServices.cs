﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PluginInterface
{
    public class PluginServices 
	{
		
		public PluginServices()
		{
		}

		private VM_AvailablePlugins colAvailablePlugins = new VM_AvailablePlugins();

		public VM_AvailablePlugins AvailablePlugins
		{
			get { return colAvailablePlugins; }
			set { colAvailablePlugins = value; }
		}

		
		public void FindPlugins(string Path)
		{
			colAvailablePlugins.Clear();

			foreach (string fileOn in Directory.GetFiles(Path))
			{
				FileInfo file = new FileInfo(fileOn);

				if (file.Extension.Equals(".dll"))
				{
					this.AddPlugin(fileOn);
				}
			}
		}

        public void ClosePlugins()
		{
			foreach (M_AvailablePlugin pluginOn in colAvailablePlugins)
			{
                pluginOn.Instance.Dispose();

				pluginOn.Instance = null;
			}

			colAvailablePlugins.Clear();
		}

		private void AddPlugin(string FileName)
		{
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);

			foreach (Type pluginType in pluginAssembly.GetTypes())
			{
				if (pluginType.IsPublic) 
				{
					if (!pluginType.IsAbstract)  
					{
						Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);

						if (typeInterface != null)
						{
							M_AvailablePlugin newPlugin = new M_AvailablePlugin();

							newPlugin.AssemblyPath = FileName;

							newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));

							newPlugin.Instance.Initialize();

							this.colAvailablePlugins.Add(newPlugin);

							newPlugin = null;
						}

						typeInterface = null; 		
					}
				}
			}

			pluginAssembly = null;
		}

    }
}