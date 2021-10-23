
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
            this.lblPluginInfo = new System.Windows.Forms.Label();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.groupBoxPluginInfo = new System.Windows.Forms.GroupBox();
            this.lblPluginInfoAuthor = new System.Windows.Forms.Label();
            this.lblPluginDesc = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.groupBoxPluginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPluginInfo
            // 
            this.lblPluginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPluginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPluginInfo.Location = new System.Drawing.Point(6, 19);
            this.lblPluginInfo.Name = "lblPluginInfo";
            this.lblPluginInfo.Size = new System.Drawing.Size(178, 18);
            this.lblPluginInfo.TabIndex = 3;
            this.lblPluginInfo.Text = "(<PluginName>)(<Version>)";
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
            this.groupBoxPluginInfo.Controls.Add(this.lblPluginInfoAuthor);
            this.groupBoxPluginInfo.Controls.Add(this.lblPluginInfo);
            this.groupBoxPluginInfo.Controls.Add(this.lblPluginDesc);
            this.groupBoxPluginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPluginInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxPluginInfo.Location = new System.Drawing.Point(201, 717);
            this.groupBoxPluginInfo.Name = "groupBoxPluginInfo";
            this.groupBoxPluginInfo.Size = new System.Drawing.Size(1062, 67);
            this.groupBoxPluginInfo.TabIndex = 2;
            this.groupBoxPluginInfo.TabStop = false;
            this.groupBoxPluginInfo.Text = "Plugin Information:";
            // 
            // lblPluginInfoAuthor
            // 
            this.lblPluginInfoAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginInfoAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPluginInfoAuthor.Location = new System.Drawing.Point(707, 37);
            this.lblPluginInfoAuthor.Name = "lblPluginInfoAuthor";
            this.lblPluginInfoAuthor.Size = new System.Drawing.Size(343, 21);
            this.lblPluginInfoAuthor.TabIndex = 4;
            this.lblPluginInfoAuthor.Text = "(<Author>)";
            // 
            // lblPluginDesc
            // 
            this.lblPluginDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPluginDesc.Location = new System.Drawing.Point(7, 37);
            this.lblPluginDesc.Name = "lblPluginDesc";
            this.lblPluginDesc.Size = new System.Drawing.Size(746, 25);
            this.lblPluginDesc.TabIndex = 0;
            this.lblPluginDesc.Text = "Plugin Description Goes Here... Test One Two Three, This is a Test...";
            // 
            // showPanel
            // 
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(201, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1062, 717);
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
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxPluginInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.GroupBox groupBoxPluginInfo;
        private System.Windows.Forms.Label lblPluginDesc;
        private System.Windows.Forms.Label lblPluginInfo;
        private System.Windows.Forms.Label lblPluginInfoAuthor;
        private System.Windows.Forms.Panel showPanel;
    }
}