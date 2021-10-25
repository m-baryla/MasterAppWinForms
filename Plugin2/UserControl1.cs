using System;
using System.Windows.Forms;
using PluginInterface;

namespace Plugin2
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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
