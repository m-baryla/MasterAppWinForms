using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MasterAppWinForms.ConfigElements;
using MasterAppWinForms.HandlingPlugin;
using PluginInterface;

namespace MasterAppWinForms.Forms
{
    public partial class MainForm : Form
    {
        private LoaderPlugin _loaderPlugin;

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
            
            Global.Plugins.FindPlugins(Config.GetDllPath());
            var imageList = Global.Plugins.FindIcons(Config.GetIconsPath());

            this._loaderPlugin = new LoaderPlugin(this.mainTreeView);
            this._loaderPlugin.LoadPlugin();
            
            this.mainTreeView.ImageList = imageList;
        }

        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this._loaderPlugin.SelectorPlugin(this.mainTreeView,this.showPanel,this.labelPluginInfo);
        }
    }
}



