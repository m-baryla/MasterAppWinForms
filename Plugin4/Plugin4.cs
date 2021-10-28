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
        private readonly string _myName = "Plugin4";
        private readonly string _myDescription = "4444444444444444444";
        private readonly string _myAuthor = "44444444444444";
        private readonly string _myVersion = "1.0.0";
        private readonly int? _myTreeSubNumber = 1;
        private readonly bool _myIsSubTree = true;


        public bool IsSubTree
        {
            get { return _myIsSubTree; }
        }
        public string Description
        {
            get { return _myDescription; }
        }
        public string Author
        {
            get { return _myAuthor; }
        }
        public string Name
        {
            get { return _myName; }
        }
        public string Version
        {
            get { return _myVersion; }
        }
        public int TreeSubNumber
        {
            get { return (int)_myTreeSubNumber; }
        }

        public Form MainInterfaceForms => new Form1();
        public UserControl MainInterfaceUserControl => null;

        public void Initialize()
        {

        }
        public void Dispose()
        {

        }
    }
}
