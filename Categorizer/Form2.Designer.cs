using System;

namespace Categorizer
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemControl1 = new Categorizer.ItemControl();
            this.panel1.SuspendLayout();
            this.UserMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ContextMenuStrip = this.UserMenu;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsername.Location = new System.Drawing.Point(766, 0);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 5, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblUsername.Size = new System.Drawing.Size(34, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // UserMenu
            // 
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(197, 420);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.Tree_DragOver);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(659, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 420);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete Category";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Merge Categories";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Rename Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.rename_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(197, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(194, 420);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 194;
            // 
            // itemControl1
            // 
            this.itemControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemControl1.Item = null;
            this.itemControl1.ItemCount = 0;
            this.itemControl1.Location = new System.Drawing.Point(391, 30);
            this.itemControl1.Name = "itemControl1";
            this.itemControl1.Size = new System.Drawing.Size(268, 420);
            this.itemControl1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Lightspeed Categorizer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private ItemControl itemControl1;
    }
}