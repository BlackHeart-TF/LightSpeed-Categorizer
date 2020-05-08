using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Categorizer.Controls;
using Categorizer.Extentions;
using LightspeedNET;
using LightspeedNET.Models;
using LightspeedNET.Extentions;

namespace Categorizer
{
    public partial class Form2 : Form
    {
        public Lightspeed _Lightspeed;
        public Form2()
        {
            InitializeComponent();
            treeView1.PathSeparator = "/";
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            (sender as Label).ContextMenuStrip.Show(MousePosition);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Lightspeed = null;
            this.Hide();
            var login = new Form1();
            if (login.ShowDialog() == DialogResult.OK)
            {
                _Lightspeed = login.Lightspeed;
                this.Show();
                var session = _Lightspeed.GetLightspeedSession();
                lblUsername.Text = session.Employee.FullName;
            }
            else
                Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_Lightspeed == null)
            {
                this.Hide();
                var login = new Form1();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    _Lightspeed = login.Lightspeed;
                    this.Show();
                    var session = _Lightspeed.GetLightspeedSession();
                    lblUsername.Text = session.Employee.FullName;
                    PopulateTree();
                    
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private void PopulateTree()
        {

            var categories = LightspeedNET.Categories.GetAllCategories();
            
            string subPathAgg;
            foreach (var path in categories)
            {
                TreeNode lastNode = null;
                subPathAgg = string.Empty;
                foreach (string subPath in path.FullPathName.Split('/'))
                {
                    subPathAgg += subPath + '/';
                    TreeNode[] nodes = treeView1.Nodes.Find(subPathAgg, true);
                    if (nodes.Length == 0)
                        if (lastNode == null)
                            lastNode = treeView1.Nodes.Add(subPathAgg, subPath);
                        else
                            lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                    else
                        lastNode = nodes[0];
                }
            }
            treeView1.ExpandAll();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var cat = Categories.getCategoryByPath(e.Node.FullPath);
            Item[] items = null;
            if (cat != null)
                items = Categories.GetItemsByCategory(cat.CategoryID);
            listView1.Items.Clear();
            if (items == null) return;
            foreach (var value in items)
            {
                var item = new ListItem(value);
                listView1.Items.Add(item);
            }
        }

        bool isMouseDown = false;
        bool isDragAndDrop = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ListView;
            if (box.SelectedIndices.Count > 1)
                itemControl1.ItemCount = box.SelectedItems.Count;
            else
            itemControl1.Item = ((sender as ListView).SelectedItems[0] as ListItem).Item;
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown || isDragAndDrop) return;

            var lst = sender as ListView;
            // Find the item under the mouse.
            //var point = lst.PointToClient(e.Location);
            //var index = lst.GetItemAt(point.X, point.Y) as ListItem;
            //lst.SelectedItems = new ListView.SelectedListViewItemCollection(lst) { index as ListItem; };
            //if (index < 0) return;

            // Drag the item.
            DragItem drag_item = new DragItem(lst, lst.SelectedItems.ToArray<ListItem>());
            lst.DoDragDrop(drag_item, DragDropEffects.Move);
            isDragAndDrop = true;
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            isDragAndDrop = false;
        }

        // See if we should allow this kind of drag.
        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            TreeView tree = sender as TreeView;

            // Allow a Move for DragItem objects that are
            // dragged to the control that started the drag.
            if (!e.Data.GetDataPresent(typeof(DragItem)))
            {
                // Not a DragItem. Don't allow it.
                e.Effect = DragDropEffects.None;
            }
            else if ((e.AllowedEffect & DragDropEffects.Move) == 0)
            {
                // Not a Move. Do not allow it.
                e.Effect = DragDropEffects.None;
            }
            else
            {
                // Get the DragItem.
                DragItem drag_item = (DragItem)e.Data.GetData(typeof(DragItem));

                // Verify that this is the control that started the drag.
                if (drag_item.Client != listView1)
                {
                    // Not the congtrol that started the drag. Do not allow it.
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    // Allow it.
                    e.Effect = DragDropEffects.Move;
                }
            }
        }
        // Select the item under the mouse during a drag.
        private void Tree_DragOver(object sender, DragEventArgs e)
        {
            // Do nothing if the drag is not allowed.
            if (e.Effect != DragDropEffects.Move) return;

            TreeView tree = sender as TreeView;

            // Select the item at this screen location.
            tree.SelectedNode = tree.NodeFromScreenPoint(new Point(e.X, e.Y));
        }

        // Drop the item here.
        private void tree_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tree = sender as TreeView;

            // Get the ListBox item data.
            DragItem drag_item = (DragItem)e.Data.GetData(typeof(DragItem));

            // Get the index of the item at this position.
            TreeNode new_node = tree.NodeFromScreenPoint(new Point(e.X, e.Y));
            foreach(var item in drag_item.Items)
            {
                var category = Categories.getCategoryByPath(new_node.FullPath);
                item.Item.MoveCategory(category).Update();
            }
            
            // Select the item.
            tree.SelectedNode = new_node;
            treeView1_NodeMouseClick(tree, new TreeNodeMouseClickEventArgs(new_node, MouseButtons.Left, 1, e.X, e.Y));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            var result = MessageBox.Show($"Are you sure you want to delete {node.Name}?", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var path = node.FullPath;
                Categories.getCategoryByPath(path).Delete();
                treeView1.Nodes.Remove(node);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            var parentNode = treeView1.SelectedNode;
            var dialog = new NewCategory(parentNode.FullPath);
            
            if (dialog.ShowDialog() != DialogResult.OK) return;

            var parentCategory = Categories.getCategoryByPath(parentNode.FullPath);
            var newCategory = Categories.CreateCategory(dialog.Result, parentNode.FullPath + "/" + dialog.Result, parentCategory.CategoryID);
            parentNode.Nodes.Add(newCategory.Name);
        }

        private void rename_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            var node = treeView1.SelectedNode;
            var category = Categories.getCategoryByPath(node.FullPath);
            var dialog = new NewCategory(category.FullPathName, "Rename");
            if (dialog.ShowDialog() != DialogResult.OK) return;

            category.Rename(dialog.Result).Update();
            node.Text = dialog.Result;
        }
    }
}
