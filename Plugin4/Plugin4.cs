using PluginInterface;
using System.Drawing;
using System.Windows.Forms;

namespace Plugin4
{
    public class Plugin4 : IPlugin
    {
        public Plugin4()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        string myName = "Plugin4";
        string myDescription = "4444444444444444444";
        string myAuthor = "44444444444444";
        string myVersion = "1.0.0";
        IPluginHost myHost = null;
        UserControl myMainInterface = new UserControl1();
        string myTreeName = "";
        int myTreeSubNumber = 1;
        ImageList imageList;
        string myIconImageName = "4";


        public IPluginHost Host
        {
            get
            {
                return myHost;
            }
            set
            {
                myHost = value;
                UserControl1 mainCtl = (UserControl1)myMainInterface;
                mainCtl.PluginHost = this.Host;
                mainCtl.Plugin = this;
            }
        }
        public string Description
        {
            get { return myDescription; }
        }

        public string Author
        {
            get { return myAuthor; }

        }
        public string Name
        {
            get { return myName; }
        }

        public UserControl MainInterface
        {
            get { return myMainInterface; }
        }

        public string Version
        {
            get { return myVersion; }
        }
        public string TreeName
        {
            get { return myTreeName; }
        }

        public int TreeSubNumber
        {
            get { return myTreeSubNumber; }
        }

        public ImageList IconImage
        {
            get
            {
                if (imageList == null)
                {
                    imageList = new ImageList();
                    //imageList.Images.Add("Application", Image.FromFile(@"D:\Source\_MySource\MasterAppWinForms\MasterApp\MasterAppWinForms\Plugin4\bin\Debug\4.jpg"));
                    imageList.Images.Add("4", Image.FromFile(Application.StartupPath + @"\Icons\" + IconImageName + ".jpg"));
                }
                return imageList;
            }
        }
        public string IconImageName
        {
            get { return myIconImageName; }
        }

        public void Initialize()
        {
        }

        public void Dispose()
        {
        }
    }
}
