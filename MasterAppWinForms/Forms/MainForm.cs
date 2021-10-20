using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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

            foreach (M_AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
            {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);

                var indexSelect = imgKey.Where(o => o.Value == "Pick" + ".jpg").Select(x => x.Key).SingleOrDefault();

                // main tree
                if (pluginOn.Instance.Name == "Plugin1")
                {
                    var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
                    this.treeView1.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                }
                else if (pluginOn.Instance.Name == "Plugin2")
                {
                    var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
                    this.treeView1.Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                }
                // sub-main tree
                else
                {
                    if (pluginOn.Instance.Name == "Plugin3")
                    {
                        var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
                        this.treeView1.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                    }
                    else if (pluginOn.Instance.Name == "Plugin4")
                    {
                        var index = imgKey.Where(o => o.Value == pluginOn.Instance.Name + ".jpg").Select(x => x.Key).SingleOrDefault();
                        this.treeView1.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(pluginOn.Instance.Name, newNode.Text, index, indexSelect);
                    }
                }
                newNode = null;
            }

            this.treeView1.ImageList = img;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
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

            if (this.treeView1.SelectedNode != null)
            {
                M_AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(treeView1.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {
                    this.lblPluginName.Text = selectedPlugin.Instance.Name;
                    this.lblPluginVersion.Text = "(" + selectedPlugin.Instance.Version + ")";
                    this.lblPluginAuthor.Text = "By: " + selectedPlugin.Instance.Author;
                    this.lblPluginDesc.Text = selectedPlugin.Instance.Description;

                    this.panel1.Controls.Clear();

                    selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;

                    this.panel1.Controls.Add(selectedPlugin.Instance.MainInterface);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.Plugins.ClosePlugins();
        }
    }
}
