using System.Drawing;
using System.Windows.Forms;
using PluginInterface;

namespace Plugin1
{
    public class Plugin1 : IPlugin
    {
        public Plugin1()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        string myName = "Plugin1";
        string myDescription = "11111111111111111111111";
        string myAuthor = "1111111111111";
        string myVersion = "1.0.0";
        IPluginHost myHost = null;
        UserControl myMainInterface = new UserControl1();
        string myTreeName = "0";
        int myTreeSubNumber = 0;
        ImageList imageList;
        string myIconImageName = "1";


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
        public void Initialize()
        {
        }
        public ImageList IconImage
        {
            get
            {
                if (imageList == null)
                {
                    imageList = new ImageList();
                    //imageList.Images.Add("Application", Image.FromFile(@"D:\Source\_MySource\MasterAppWinForms\MasterApp\MasterAppWinForms\Plugin1\bin\Debug\1.jpg"));
                    imageList.Images.Add("1", Image.FromFile(Application.StartupPath + @"\Icons\" + IconImageName + ".jpg"));
                }
                return imageList;
            }
        }

        public string IconImageName
        {
            get { return myIconImageName; }
        }

        public void Dispose()
        {
        }
    }
}
