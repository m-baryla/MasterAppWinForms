using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterAppWinForms.ConfigElements;
using PluginInterface;

namespace MasterAppWinForms.HandlingPlugin
{
    public class LoaderPlugin
    {
        private PluginConfigSection _selection;
        private Dictionary<int, string> _imageKey;
        private TreeView _mainTreeView;

        public LoaderPlugin(TreeView mainTreeView)
        {
            this._imageKey = Global.Plugins.IconsNameList;
            this._mainTreeView = mainTreeView;
            this._selection = (PluginConfigSection)ConfigurationManager.GetSection("Plugins"); ;
        }

        public void LoadPlugin()
        {
            if (this._selection != null)
            {
                foreach (PluginElement pluginItem in this._selection.PluginItems)
                {
                    foreach (AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
                    {
                        TreeNode newNode = new TreeNode(pluginOn.Instance.Name);

                        var indexSelect = this._imageKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();

                        if (pluginOn.Instance.Name == pluginItem.PluginName && pluginOn.Instance.IsSubTree == false)
                        {
                            var index = this._imageKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();
                            this._mainTreeView.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                        }
                        else if (pluginOn.Instance.Name == pluginItem.PluginName)
                        {
                            var index = this._imageKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();
                            this._mainTreeView.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                        }

                        newNode = null;
                    }
                }
            }
        }

        public void SelectorPlugin(TreeView mainTreeView,Panel showPanel, Label labelInfo)
        {

            if (mainTreeView.SelectedNode != null)
            {
                AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(mainTreeView.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {
                    labelInfo.Font = new Font(labelInfo.Font, FontStyle.Bold);
                    labelInfo.Text = "Name: " + selectedPlugin.Instance.Name + "\n" +
                                     "Version: ( " + selectedPlugin.Instance.Version + " ) " + "\n" +
                                     "By:  " + selectedPlugin.Instance.Author + "\n" + 
                                     "Description: " + selectedPlugin.Instance.Description;


                    if (selectedPlugin.Instance.MainInterfaceForms != null)
                    {
                        selectedPlugin.Instance.MainInterfaceForms.StartPosition = FormStartPosition.WindowsDefaultLocation;
                        selectedPlugin.Instance.MainInterfaceForms.Show();
                        selectedPlugin.Instance.MainInterfaceForms.TopMost = true;
                    }
                    else
                    {
                        showPanel.Controls.Clear();
                        selectedPlugin.Instance.MainInterfaceUserControl.Dock = DockStyle.Fill;
                        showPanel.Controls.Add(selectedPlugin.Instance.MainInterfaceUserControl);
                    }

                }
            }
        }
    }
}
