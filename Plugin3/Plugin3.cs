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
        private string myName = "Plugin3";
        private string myDescription = "333333333333333333333333333";
        private string myAuthor = "333333333333333333333";
        private string myVersion = "1.0.0";
        private UserControl myMainInterface = new UserControl1();
        private int? myTreeSubNumber = 0;
        private bool myIsSubTree = true;


        public bool IsSubTree
        {
            get { return myIsSubTree; }
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
