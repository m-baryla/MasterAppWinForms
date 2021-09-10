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
        UserControl myMainInterface = new UserControl1();
        string myTreeName = "";
        int myTreeSubNumber = 0;


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
        public string Icon
        {
            get { return Application.StartupPath + @"\Icons\" + Name; }
        }
        public void Initialize()
        {
        }

        public void Dispose()
        {
        }
    }
}
