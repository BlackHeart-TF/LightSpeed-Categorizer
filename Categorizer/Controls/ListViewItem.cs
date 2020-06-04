using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorizer.Controls
{
    class ListItem : System.Windows.Forms.ListViewItem
    {
        private LightspeedNET.Models.Item _item;
        public LightspeedNET.Models.Item Item { get { return _item; }
            set { _item = value;
                //base.Name = _item.Description;
                base.Text = _item.Description;
            } }

        public ListItem(LightspeedNET.Models.Item Item)
        {
            this.Item = Item;
        }
    }
}
