namespace PluginInterface
{
	public class AvailablePlugin
    {
        private IPlugin _myInstance = null;
        private string _myAssemblyPath = "";

        public IPlugin Instance
        {
            get { return _myInstance; }
            set { _myInstance = value; }
        }
        public string AssemblyPath
        {
            get { return _myAssemblyPath; }
            set { _myAssemblyPath = value; }
        }
    }
}
