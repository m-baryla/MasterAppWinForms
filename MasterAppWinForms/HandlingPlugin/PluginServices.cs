﻿using System;
using System.IO;
using System.Reflection;
using MasterAppWinForms.Forms;
using PluginInterface;

namespace MasterAppWinForms.HandlingPlugin
{
	public class PluginServices : IPluginHost   
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

		public void FindPlugins()
		{
			FindPlugins(AppDomain.CurrentDomain.BaseDirectory);
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

							newPlugin.Instance.Host = this;

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

		
		public void Feedback(string Feedback, IPlugin Plugin)
		{
            //This sub makes a new feedback form and fills it out
            //With the appropriate information
            //This method can be called from the actual plugin with its Host Property

            System.Windows.Forms.Form newForm = null;
            FeedBackExample newFeedbackForm = new FeedBackExample();

            //Here we set the frmFeedback's properties that i made custom
            newFeedbackForm.PluginAuthor = "By: " + Plugin.Author;
            newFeedbackForm.PluginDesc = Plugin.Description;
            newFeedbackForm.PluginName = Plugin.Name;
            newFeedbackForm.PluginVersion = Plugin.Version;
            newFeedbackForm.Feedback = Feedback;

            //We also made a Form object to hold the frmFeedback instance
            //If we were to declare if not as  frmFeedback object at first,
            //We wouldn't have access to the properties we need on it
            newForm = newFeedbackForm;
            newForm.ShowDialog();

            newFeedbackForm = null;
            newForm = null;

        }
	}
}
