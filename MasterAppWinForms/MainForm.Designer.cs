
namespace MasterAppWinForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPluginDesc = new System.Windows.Forms.Label();
            this.lblPluginAuthor = new System.Windows.Forms.Label();
            this.lblPluginVersion = new System.Windows.Forms.Label();
            this.lblPluginName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(253, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 280);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblPluginDesc);
            this.groupBox1.Controls.Add(this.lblPluginAuthor);
            this.groupBox1.Controls.Add(this.lblPluginVersion);
            this.groupBox1.Controls.Add(this.lblPluginName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(41, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Information:";
            // 
            // lblPluginDesc
            // 
            this.lblPluginDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginDesc.Location = new System.Drawing.Point(8, 64);
            this.lblPluginDesc.Name = "lblPluginDesc";
            this.lblPluginDesc.Size = new System.Drawing.Size(168, 64);
            this.lblPluginDesc.TabIndex = 3;
            this.lblPluginDesc.Text = "   Plugin Description Goes Here... Test One Two Three, This is a Test...";
            // 
            // lblPluginAuthor
            // 
            this.lblPluginAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginAuthor.Location = new System.Drawing.Point(8, 48);
            this.lblPluginAuthor.Name = "lblPluginAuthor";
            this.lblPluginAuthor.Size = new System.Drawing.Size(168, 16);
            this.lblPluginAuthor.TabIndex = 2;
            this.lblPluginAuthor.Text = "By: <Author\'s Name>";
            // 
            // lblPluginVersion
            // 
            this.lblPluginVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginVersion.Location = new System.Drawing.Point(8, 32);
            this.lblPluginVersion.Name = "lblPluginVersion";
            this.lblPluginVersion.Size = new System.Drawing.Size(168, 16);
            this.lblPluginVersion.TabIndex = 1;
            this.lblPluginVersion.Text = "(<Version>)";
            // 
            // lblPluginName
            // 
            this.lblPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginName.Location = new System.Drawing.Point(8, 16);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(168, 16);
            this.lblPluginName.TabIndex = 0;
            this.lblPluginName.Text = "<Plugin Name Here>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPluginDesc;
        private System.Windows.Forms.Label lblPluginAuthor;
        private System.Windows.Forms.Label lblPluginVersion;
        private System.Windows.Forms.Label lblPluginName;
    }
}