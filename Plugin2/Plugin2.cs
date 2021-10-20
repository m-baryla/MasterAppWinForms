using System.Drawing;
using System.Windows.Forms;
using PluginInterface;

namespace Plugin2
{
    public class Plugin2 : IPlugin
    {
        public Plugin2()
        {
            //
            // TODO: Add constructor logic here
            //
        }
		string myName = "Plugin2";
        string myDescription = "2222222222222222222222";
        string myAuthor = "2222222222222222222222";
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
