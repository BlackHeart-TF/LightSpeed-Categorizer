using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorizer
{
    class DragItem
    {
        public ListView Client;
        public Controls.ListItem[] Items;

        public DragItem(ListView client, Controls.ListItem[] item)
        {
            Client = client;
            Items = item;
        }
    }
}
