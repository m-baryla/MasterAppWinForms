using System.Drawing;
using System.Windows.Forms;
using PluginInterface;

namespace Plugin3
{
    public class Plugin3 : IPlugin
    {
        public Plugin3()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        string myName = "Plugin3";
        string myDescription = "333333333333333333333333333";
        string myAuthor = "333333333333333333333";
        string myVersion = "1.0.0";
        IPluginHost myHost = null;
        UserControl myMainInterface = new UserControl1();
        string myTreeName = "";
        int myTreeSubNumber = 0;
        ImageList imageList;
        string myIconImageName = "3";

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
                    //imageList.Images.Add("Application", Image.FromFile(@"D:\Source\_MySource\MasterAppWinForms\MasterApp\MasterAppWinForms\Plugin3\bin\Debug\3.jpg"));
                    imageList.Images.Add("3", Image.FromFile(Application.StartupPath + @"\Icons\" + IconImageName + ".jpg"));
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
