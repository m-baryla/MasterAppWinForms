using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MasterAppWinForms.ConfigElements;
using MasterAppWinForms.HandlingPlugin;
using PluginInterface;

namespace MasterAppWinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        private  void MainForm_Load(object sender, EventArgs e)
        {
            Global.Plugins.FindPlugins(Application.StartupPath + @"\Plugins");
            var img = Global.Plugins.FindIco(Application.StartupPath + @"\Icons");
            var imgKey = Global.Plugins.DictImage;
            var selection = (PluginConfigSection)ConfigurationManager.GetSection("Plugins");

            if (selection != null)
            {
                foreach (PluginElement pluginItem in selection.PluginItems)
                {
                    foreach (M_AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
                    {
                        TreeNode newNode = new TreeNode(pluginOn.Instance.Name);

                        var indexSelect = imgKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();

                        if (pluginOn.Instance.Name == pluginItem.PluginName && pluginOn.Instance.IsSubTree == false)
                        {
                            var index = imgKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();
                            this.mainTreeView.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                        }
                        else if (pluginOn.Instance.Name == pluginItem.PluginName && pluginOn.Instance.IsSubTree == true)
                        {
                            var index = imgKey.Where(o => o.Value == pluginItem.IcoName).Select(x => x.Key).SingleOrDefault();
                            this.mainTreeView.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                        }
                        
                        newNode = null;
                    }
                }
            }

            this.mainTreeView.ImageList = img;
        }

        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TreeNode sectedNode = treeView1.SelectedNode;
            //switch (sectedNode.Text)
            //{
            //    case "Plugin1":
            //        {
            //            MessageBox.Show("Plugin1");
            //        }
            //        break;
            //    case "Plugin2":
            //        {
            //            MessageBox.Show("Plugin1");
            //        }
            //        break;
            //    case "Plugin3":
            //        {
            //            MessageBox.Show("Plugin1");
            //        }
            //        break;
            //    case "Plugin4":
            //        {
            //            MessageBox.Show("Plugin1");
            //        }
            //        break;
            //}

            if (this.mainTreeView.SelectedNode != null)
            {
                M_AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(mainTreeView.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {
                    this.lblPluginInfo.Text = "Name: " + selectedPlugin.Instance.Name + " " +
                                              " Version: ( " + selectedPlugin.Instance.Version + " ) ";
                    this.lblPluginInfoAuthor.Text = "By:  " + selectedPlugin.Instance.Author;
                    this.lblPluginDesc.Text = selectedPlugin.Instance.Description;

                    this.showPanel.Controls.Clear();
                    selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;
                    this.showPanel.Controls.Add(selectedPlugin.Instance.MainInterface);
                }
            }
        }
    }
}



//// main tree
//if (pluginOn.Instance.Name == "Plugin1")
//{
//    var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
//    this.mainTreeView.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
//}
//else if (pluginOn.Instance.Name == "Plugin2")
//{
//    var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
//    this.mainTreeView.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
//}
//// sub-main tree
//else
//{
//    if (pluginOn.Instance.Name == "Plugin3")
//    {
//        var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
//        this.mainTreeView.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
//    }
//    else if (pluginOn.Instance.Name == "Plugin4")
//    {
//        var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
//        this.mainTreeView.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
//    }
//}
//newNode = null;