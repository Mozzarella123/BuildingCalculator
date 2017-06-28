using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.FormComponents
{
    public partial class ChangeName : Form
    {
        public ChangeName()
        {
            InitializeComponent();
            RoomTitle.KeyDown += ChangeName_KeyDown;
            
        }

        private void ChangeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter||e.KeyCode==Keys.Escape)
                Dispose();
        }
    }
}
