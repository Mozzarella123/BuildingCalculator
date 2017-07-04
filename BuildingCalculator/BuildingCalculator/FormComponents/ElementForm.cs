using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;

namespace BuildingCalculator.FormComponents
{
    public partial class ElementForm : UserControl
    {
        public Element Element;
        public List<Element> ElementLists = new List<Element>();
        public WorkTypeClass.Category Category;
        public ElementForm()
        {
            InitializeComponent();
            Element = new Element();
            foreach (Control control in MarkUp.Controls)
                if (control is TextBox)
                Functions.SetValidator(control, Functions.ValidateType.OnlyNumbers);
            comboBox1.SelectedIndex = 0;

            ContInp.Text = "1";
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

        private void ContInp_TextChanged(object sender, EventArgs e)
        {
            ElementLists.Clear();
            TextBox text = sender as TextBox;
            int count = 0;
            if (text.Text != "")
                count = Convert.ToInt16(text.Text);
            for (int i = 0; i < count; i++)
                ElementLists.Add(Element);
        }

        private void WidthInp_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            switch (text.Name)
            {
                case "WidthInp": Element.Params[Entity.ParamName.Width] = Convert.ToDouble(text.Text); break;
                case "HeightInp": Element.Params[Entity.ParamName.Height] = Convert.ToDouble(text.Text); break;

            }
        }
    }
}
