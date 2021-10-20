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
        UserControl myMainInterface = new UserControl1();
        int? myTreeSubNumber = null;


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
        public int TreeSubNumber
        {
            get { return (int)myTreeSubNumber; }
        }
        public void Initialize()
        {
        }
        public void Dispose()
        {
        }
    }
}
