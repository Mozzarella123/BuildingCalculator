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
    public partial class TextWithOperations : UserControl
    {
        public Button Plus { get; private set; }
        public Button Minus { get; private set; }
        public Button Prop { get; private set; }
        public Button Div { get; private set; }
        public TextBox TextBox { get; private set; }
        public TextWithOperations()
        {
            InitializeComponent();
            Plus = plus;
            Minus = minus;
            Prop = prop;
            Div = div;
            TextBox = textbox;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            if (TextBox.Text != "" && TextBox.Text[TextBox.Text.Length - 1].ToString() != but.Text)
            {
                if (!(Char.IsDigit(TextBox.Text[TextBox.Text.Length - 1]) || Char.IsLetter(TextBox.Text[TextBox.Text.Length - 1])))
                    textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                textbox.Text += but.Text;
            }
        }
    }
}
