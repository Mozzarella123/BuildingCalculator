using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator
{
    public partial class CreateWorkTypeForm : Form
    {
        public CreateWorkTypeForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(_FormClosing);
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkTypeClass work = new WorkTypeClass();
            work.article = textBox1.Text;
            work.formula = textBox3.Text;
            var numer = listBox1.Items.GetEnumerator();
            while (numer.MoveNext())
                work.parametrs.Add(numer.Current.ToString());
            JSONSerializeService.AddToOutput(work);
            if (RedactedItemIndex != null)
            {
                JSONSerializeService.OutputItems.RemoveAt((int)RedactedItemIndex);
                RedactedItemIndex = null;
                
            }
            JSONSerializeService.Save();
            this.Hide();
        }
        static CreateWorkTypeForm cwf = new CreateWorkTypeForm();
        static int? RedactedItemIndex = null;
        
        public static void CreateWorkType(WorkTypeClass obj=null)
        {
            cwf.Show();
            if (obj != null)
            {
                RedactedItemIndex = JSONSerializeService.OutputItems.IndexOf(obj);
                cwf.textBox1.Text = obj.article;
                cwf.textBox3.Text = obj.formula;
                foreach (string str in obj.parametrs)
                    cwf.listBox1.Items.Add(str);
            }
            else
            {
                
                cwf.textBox1.Text = "";
                cwf.textBox3.Text = "";
                cwf.listBox1.Items.Clear();
            }
        } 
    }
}
