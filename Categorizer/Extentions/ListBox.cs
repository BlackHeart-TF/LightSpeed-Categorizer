using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorizer.Extentions
{
    static class ListBoxExtentions
    {
        public static int IndexFromScreenPoint(this ListBox lst, Point point)
        {
            // Convert the location to the ListBox's coordinates.
            point = lst.PointToClient(point);

            // Return the index of the item at that position.
            return lst.IndexFromPoint(point);
        }

        public static TreeNode NodeFromScreenPoint(this TreeView tree, Point point)
        {
            point = tree.PointToClient(point);

            return tree.GetNodeAt(point);
        }

        public static T[] ToArray<T>(this ListView.SelectedListViewItemCollection objects)
        {
            T[] array = new T[objects.Count];
            objects.CopyTo(array, 0);
            return array;
        }
    }
}
