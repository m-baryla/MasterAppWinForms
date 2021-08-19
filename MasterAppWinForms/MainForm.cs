using System;
using System.Windows.Forms;
using MasterAppWinForms.HandlingPlugin;

namespace MasterAppWinForms
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Call the find plugins routine, to search in our Plugins Folder
            Global.Plugins.FindPlugins(Application.StartupPath + @"\Plugins");

            //Add each plugin to the treeview
            foreach (AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
            {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);
                this.treeView1.Nodes.Add(newNode);
                newNode = null;
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Make sure there's a selected Plugin
            if (this.treeView1.SelectedNode != null)
            {
                //Get the selected Plugin
                AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(treeView1.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {
                    //Again, if the plugin is found, do some work...


                    ////This part adds the plugin's info to the 'Plugin Information:' Frame
                    this.lblPluginName.Text = selectedPlugin.Instance.Name;
                    this.lblPluginVersion.Text = "(" + selectedPlugin.Instance.Version + ")";
                    this.lblPluginAuthor.Text = "By: " + selectedPlugin.Instance.Author;
                    this.lblPluginDesc.Text = selectedPlugin.Instance.Description;

                    //Clear the current panel of any other plugin controls... 
                    //Note: this only affects visuals.. doesn't close the instance of the plugin
                    this.panel1.Controls.Clear();

                    //Set the dockstyle of the plugin to fill, to fill up the space provided
                    selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;

                    //Finally, add the usercontrol to the panel... Tadah!
                    this.panel1.Controls.Add(selectedPlugin.Instance.MainInterface);

                }

            }
        }
    }
}
