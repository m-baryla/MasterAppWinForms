
namespace MasterAppWinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.groupBoxPluginInfo = new System.Windows.Forms.GroupBox();
            this.labelPluginInfo = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.groupBoxPluginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainTreeView.ItemHeight = 36;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainTreeView.Size = new System.Drawing.Size(201, 784);
            this.mainTreeView.TabIndex = 1;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeView_AfterSelect);
            // 
            // groupBoxPluginInfo
            // 
            this.groupBoxPluginInfo.Controls.Add(this.labelPluginInfo);
            this.groupBoxPluginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPluginInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxPluginInfo.Location = new System.Drawing.Point(201, 704);
            this.groupBoxPluginInfo.Name = "groupBoxPluginInfo";
            this.groupBoxPluginInfo.Size = new System.Drawing.Size(1062, 80);
            this.groupBoxPluginInfo.TabIndex = 2;
            this.groupBoxPluginInfo.TabStop = false;
            this.groupBoxPluginInfo.Text = "Plugin Information:";
            // 
            // labelPluginInfo
            // 
            this.labelPluginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPluginInfo.Location = new System.Drawing.Point(7, 18);
            this.labelPluginInfo.Name = "labelPluginInfo";
            this.labelPluginInfo.Size = new System.Drawing.Size(1043, 57);
            this.labelPluginInfo.TabIndex = 0;
            this.labelPluginInfo.Text = "PLUGIN INFO ";
            // 
            // showPanel
            // 
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(201, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1062, 704);
            this.showPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 784);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.groupBoxPluginInfo);
            this.Controls.Add(this.mainTreeView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxPluginInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.GroupBox groupBoxPluginInfo;
        private System.Windows.Forms.Label labelPluginInfo;
        private System.Windows.Forms.Panel showPanel;
    }
}