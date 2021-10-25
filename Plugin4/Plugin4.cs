using PluginInterface;
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
        private readonly string myName = "Plugin4";
        private readonly string myDescription = "4444444444444444444";
        private readonly string myAuthor = "44444444444444";
        private readonly string myVersion = "1.0.0";
        private readonly UserControl myMainInterface = new UserControl1();
        private readonly int? myTreeSubNumber = 1;
        private readonly bool myIsSubTree = true;


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
