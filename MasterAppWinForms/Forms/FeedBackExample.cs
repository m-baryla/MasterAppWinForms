﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterAppWinForms.Forms
{
    public partial class FeedBackExample : Form
    {
        public FeedBackExample()
        {
            InitializeComponent();
        }

        public string PluginAuthor
        {
            get { return this.lblPluginAuthor.Text; }
            set { this.lblPluginAuthor.Text = value; }
        }

        public string PluginDesc
        {
            get { return this.lblPluginDesc.Text; }
            set { this.lblPluginDesc.Text = value; }
        }

        public string PluginName
        {
            get { return this.lblPluginName.Text; }
            set { this.lblPluginName.Text = value; }
        }
        public string PluginVersion
        {
            get { return this.lblPluginVersion.Text; }
            set { this.lblPluginVersion.Text = value; }
        }
        public string Feedback
        {
            get { return this.lblFeedback.Text; }
            set { this.lblFeedback.Text = value; }
        }
	}
}