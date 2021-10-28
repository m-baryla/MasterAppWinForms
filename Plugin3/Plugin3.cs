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
        private readonly string _myName = "Plugin3";
        private readonly string _myDescription = "333333333333333333333333333";
        private readonly string _myAuthor = "333333333333333333333";
        private readonly string _myVersion = "1.0.0";
        private readonly int? _myTreeSubNumber = 0;
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
        public Form MainInterfaceForms => null;
        public UserControl MainInterfaceUserControl => new UserControl1();
        public void Initialize()
        {

        }
        public void Dispose()
        {

        }
    }
}
