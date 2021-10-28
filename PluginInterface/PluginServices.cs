using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PluginInterface
{
    public class PluginServices 
	{
        public PluginServices() {}

		private AvailablePlugins _colAvailablePlugins = new AvailablePlugins();
        public Dictionary<int, string> IconsNameList = new Dictionary<int, string>(); 

		public AvailablePlugins AvailablePlugins
		{
			get { return _colAvailablePlugins; }
			set { _colAvailablePlugins = value; }
		}

        public void FindPlugins(string path)
		{
			_colAvailablePlugins.Clear();

			foreach (string fileOn in Directory.GetFiles(path))
			{
				FileInfo file = new FileInfo(fileOn);

				if (file.Extension.Equals(".dll"))
				{
					this.AddPlugin(fileOn);
				}
			}
		}

        public ImageList FindIcons(string path)
        {
            ImageList imageList = new ImageList();
            int i = 0;
			foreach (string fileOn in Directory.GetFiles(path))
            {
                FileInfo file = new FileInfo(fileOn);

                if (file.Extension.Equals(".jpg"))
                {
                    imageList.Images.Add(Image.FromFile(fileOn));
                    IconsNameList.Add(i, file.Name);
                    i++;
				}
            }
			return imageList;
        }

        public void ClosePlugins()
		{
			foreach (AvailablePlugin pluginOn in _colAvailablePlugins)
			{
                pluginOn.Instance.Dispose();

				pluginOn.Instance = null;
			}
            _colAvailablePlugins.Clear();
		}

		private void AddPlugin(string fileName)
		{
			Assembly pluginAssembly = Assembly.LoadFrom(fileName);

			foreach (Type pluginType in pluginAssembly.GetTypes())
			{
				if (pluginType.IsPublic) 
				{
					if (!pluginType.IsAbstract)  
					{
						Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);

						if (typeInterface != null)
						{
							AvailablePlugin newPlugin = new AvailablePlugin();

							newPlugin.AssemblyPath = fileName;

							newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));

							newPlugin.Instance.Initialize();

							this._colAvailablePlugins.Add(newPlugin);

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
