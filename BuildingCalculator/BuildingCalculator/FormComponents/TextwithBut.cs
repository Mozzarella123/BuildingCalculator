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
    public partial class TextwithBut : UserControl
    {
        public Button Button { get; set; }
        public TextBox TextBox { get; set; }
        public TextwithBut()
        {
            InitializeComponent();
            Button = button1;
            TextBox = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
