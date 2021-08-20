﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginInterface
{
    public interface IPlugin
    {
        IPluginHost Host { get; set; }
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        string TreeName { get; }
        int TreeSubNumber { get; }
        ImageList IconImage { get; }
        string IconImageName { get; }
        UserControl MainInterface { get; }
        void Initialize();
        void Dispose();
    }
}
