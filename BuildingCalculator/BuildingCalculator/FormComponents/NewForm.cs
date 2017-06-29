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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            MainTabs.ItemSize = new Size(0, 1);
        }


        private void MenuClick(object sender, EventArgs e)
        {
            Button but = sender as Button;
            foreach (Button menbut in MenuMarkup.Controls)
                menbut.BackColor = DefaultBackColor;
            but.BackColor = Color.LightGray;
            MainTabs.SelectedIndex = but.TabIndex;
        }
    }
}
