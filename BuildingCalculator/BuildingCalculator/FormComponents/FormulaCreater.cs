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
    public partial class FormulaCreater : Form
    {
        public FormulaCreater()
        {
            InitializeComponent();
            
        }
        public void setParam(List<string> param)
        {
            foreach (string str in param)
                listBox1.Items.Add(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastIsDigit(textBox1.SelectionStart - 1))
                textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + (sender as Button).Text + textBox1.Text.Substring(textBox1.SelectionStart);
            textBox1.Select(textBox1.Text.Length, 0);

        }
        bool lastIsDigit(int pos)
        {

            if (textBox1.Text.Length > 0)
            {
                if (pos > 0)
                {
                    MessageBox.Show(textBox1.Text[pos].ToString());
                    return char.IsDigit(textBox1.Text[pos]);
                }
                return false;
            }
            //if(pos>=0)
            //return true;
            return false;
        }

        private void FormulaCreater_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        static int carret = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            //string addStr = "";
            //if (lastIsDigit(textBox1.SelectionStart-1))
            //    addStr += "*";
            //addStr += "Sqrt()";
            //textBox1.Text = textBox1.Text.Substring(0,textBox1.SelectionStart)+addStr+textBox1.Text.Substring(textBox1.SelectionStart);
            ////carret += 1;
            //textBox1.Select(textBox1.Text.Length, 0);
            //textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string addStr = "";
            //if (lastIsDigit(textBox1.SelectionStart - 1))
            //    addStr += "*";
            //addStr += "Pow(,)";
            //textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + addStr + textBox1.Text.Substring(textBox1.SelectionStart);
            ////carret += 2;
            //textBox1.Select(textBox1.Text.Length, 0);
            //textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //if (lastIsDigit(textBox1.SelectionStart - 1))
            //    textBox1.Text += "*";
            //textBox1.Text += "()";
            ////carret += 1;
            //textBox1.Select(textBox1.Text.Length, 0);
            //textBox1.Focus();
        }
    }
}
