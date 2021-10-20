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
        UserControl myMainInterface = new UserControl1();
        int? myTreeSubNumber = 1; 


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
