using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        IPlugin myPlugin = null;

        public IPlugin Plugin
        {
            get { return myPlugin; }
            set { myPlugin = value; }
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(this, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }
    }
}
