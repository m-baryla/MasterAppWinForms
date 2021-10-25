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
        private readonly string myName = "Plugin1";
        private readonly string myDescription = "Aplikacja do niczego konkretnego....";
        private readonly string myAuthor = "Mateusz Baryla";
        private readonly string myVersion = "1.0.0";
        private readonly UserControl myMainInterface = new UserControl1();
        private readonly int? myTreeSubNumber = null;
        private readonly bool myIsSubTree = false;


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
