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
    public partial class ElementForm : UserControl
    {
        public Element Element = new Element();
        public ElementForm()
        {
            InitializeComponent();
            foreach (Control control in MarkUp.Controls)
                if (control is TextBox)
                Classes.Functions.SetValidator(control, Classes.Functions.ValidateType.OnlyNumbers);
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MarkUp.RowStyles[1].SizeType = SizeType.Absolute;
                MarkUp.RowStyles[1].Height = 0;
            }
            else
                MarkUp.RowStyles[1].SizeType = SizeType.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
