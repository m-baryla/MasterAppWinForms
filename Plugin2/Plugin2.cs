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
        string myTreeName = "1";
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
