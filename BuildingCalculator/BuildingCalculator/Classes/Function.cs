using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.Classes
{
    public static class Functions
    {
        public static ContextMenuStrip ContextMenu(Control control,List<string> names,List<EventHandler> funcs)
        {           
            ContextMenuStrip menu = new ContextMenuStrip();
            for (int i=0;i<names.Count;i++)
            {
                menu.Items.Add(names[i]);
                menu.Items[i].Click += funcs[i];
            }
            control.ContextMenuStrip = menu;
            return menu;         
        }       
    }
}
