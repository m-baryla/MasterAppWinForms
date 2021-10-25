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
        private readonly string myName = "Plugin3";
        private readonly string myDescription = "333333333333333333333333333";
        private readonly string myAuthor = "333333333333333333333";
        private readonly string myVersion = "1.0.0";
        private readonly UserControl myMainInterface = new UserControl1();
        private readonly int? myTreeSubNumber = 0;
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
