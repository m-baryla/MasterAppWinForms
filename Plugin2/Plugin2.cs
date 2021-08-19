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
        IPluginHost myHost = null;
        System.Windows.Forms.UserControl myMainInterface = new UserControl1();

        public IPluginHost Host
        {
            get
            {
                return myHost;
            }
            set
            {
                myHost = value;
                UserControl1 mainCtl = (UserControl1)myMainInterface;
                mainCtl.PluginHost = this.Host;
                mainCtl.Plugin = this;
            }
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

		public System.Windows.Forms.UserControl MainInterface
		{
			get { return myMainInterface; }
		}

		public string Version
		{
			get { return myVersion; }
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}
	}
}
