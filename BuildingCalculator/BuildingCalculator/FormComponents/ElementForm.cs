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
        public event ValueChangedHandler ValueChanged;
        public delegate void ValueChangedHandler(object sender, EventArgs e);
        public ElementForm()
        {
            InitializeComponent();  
            foreach (Control control in MarkUp.Controls)
                if (control is TextBox)
                Functions.SetValidator(control, Functions.ValidateType.OnlyNumbers);
            PatternSelect.SelectedIndex = 0;
            Element = new Element();
            comboBox1_SelectionChangeCommitted(PatternSelect, new EventArgs());
            ContInp.Text = "1";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ContInp.Text = "0";            
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
            ValueChanged?.Invoke(ContInp, new EventArgs());
        }

        private void WidthInp_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            string Text = "";
            if (text.Text == "")
                Text = "0";
            else Text = text.Text;
            if (Element!=null)
            switch (text.Name)
            {
                case "WidthInp": Element.Params[Entity.ParamName.Width] = Convert.ToDouble(Text); break;
                case "HeightInp": Element.Params[Entity.ParamName.Height] = Convert.ToDouble(Text); break;

            }
            ValueChanged?.Invoke(sender as TextBox, new EventArgs());
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (PatternSelect.SelectedIndex)
            {
                case 0:
                    {
                        MarkUp.RowStyles[1].SizeType = SizeType.Absolute;
                        MarkUp.RowStyles[1].Height = 0;
                        SelectDoorsWindows selectpat = new SelectDoorsWindows();
                        Functions.CenterForm(selectpat, NewForm.ActiveForm);
                        selectpat.ShowDialog();
                        if (selectpat.Checked != null)
                        {
                            Element = selectpat.Checked;
                            HeightInp.Text = selectpat.Checked.Params[Entity.ParamName.Height].ToString();
                            WidthInp.Text = selectpat.Checked.Params[Entity.ParamName.Width].ToString();
                            Title.Text = selectpat.Checked.Title;
                        }
                        else
                        {
                            switch (selectpat.tabControl1.SelectedIndex)
                            {
                                case 0: PatternSelect.SelectedIndex = 2;break;
                                case 1: PatternSelect.SelectedIndex = 1;break;
                            }
                        }
                        selectpat.Dispose();
                        ContInp_TextChanged(ContInp, new EventArgs());
                        break;
                    }
                case 1:
                    {
                        Element.Categories.Clear();
                        Element.Categories.Add(WorkTypeClass.Category.walls);
                        MarkUp.RowStyles[1].SizeType = SizeType.AutoSize;
                        Title.Text = "Окно";
                        break;
                    }
                case 2:
                    {
                        Element.Categories.Clear();
                        Element.Categories.Add(WorkTypeClass.Category.walls);
                        Element.Categories.Add(WorkTypeClass.Category.floorPer);
                        MarkUp.RowStyles[1].SizeType = SizeType.AutoSize;
                        Title.Text = "Дверь";
                        break;
                    }
            }
        }
    }
}
