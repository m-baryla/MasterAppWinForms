﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace Plugin3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        IPluginHost myHost = null;
        IPlugin myPlugin = null;

        public IPluginHost PluginHost
        {
            get { return myHost; }
            set { myHost = value; }
        }
        public IPlugin Plugin
        {
            get { return myPlugin; }
            set { myPlugin = value; }
        }
    }
}
