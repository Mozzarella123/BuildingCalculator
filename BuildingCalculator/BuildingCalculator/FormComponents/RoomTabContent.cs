using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.FormComponents
{
    public partial class RoomTabContent : UserControl
    {
        public RoomTabContent()
        {
            InitializeComponent();
            TypeTabs.ItemSize = new Size(0,1);
        }
    }
}
