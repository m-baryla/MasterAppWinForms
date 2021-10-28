using System.Windows.Forms;
using PluginInterface;

namespace Plugin4
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

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(this, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }
    }
}
