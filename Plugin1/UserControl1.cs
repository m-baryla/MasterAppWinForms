using System.Windows.Forms;
using PluginInterface;

namespace Plugin1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        IPlugin _myPlugin = null;

        public IPlugin Plugin
        {
            get { return _myPlugin; }
            set { _myPlugin = value; }
        }
    }
}
