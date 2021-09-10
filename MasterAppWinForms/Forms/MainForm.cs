using System;
using System.Drawing;
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

            ImageList imageList = new ImageList();

            foreach (M_AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
            {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);

                if (pluginOn.Instance.TreeName == "0" || pluginOn.Instance.TreeName == "1")
                {
                    this.treeView1.Nodes.Add(newNode);

                    if (!string.IsNullOrEmpty(pluginOn.Instance.Icon))
                    {
                        imageList.Images.Add(Image.FromFile(pluginOn.Instance.Icon + ".jpg"));
                    }
                    
                    this.treeView1.ImageList = imageList;
                }
                else
                {
                    this.treeView1.Nodes[pluginOn.Instance.TreeSubNumber].Nodes.Add(newNode);

                   
                }
                newNode = null;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
