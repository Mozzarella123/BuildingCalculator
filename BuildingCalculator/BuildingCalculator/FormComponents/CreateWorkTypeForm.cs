using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;


namespace BuildingCalculator
{
    public partial class CreateWorkTypeForm : Form
    {
        public CreateWorkTypeForm()
        {
            InitializeComponent();
            List<string> names = new List<string>()
            {
                "Удалить"
            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                Remove
            };
            Functions.ContextMenu(listBox1, names, functions);
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
            if (textBox2.Text != ""){
                listBox1.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
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
            work.category = (WorkTypeClass.Category)(comboBox1.SelectedIndex);
            if (DelegateAssemblyService.isCreatedCorrect(work))
            {
                JSONSerializeService.AddToOutput(work);
                if (RedactedItemIndex != null)
                {
                    JSONSerializeService.OutputItems.RemoveAt((int)RedactedItemIndex);
                    RedactedItemIndex = null;

                }
                JSONSerializeService.Save();
                this.Hide();
            }
            else
                MessageBox.Show("Параметры обьекта заданны некоректно.");
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
                cwf.listBox1.Items.Clear();
                foreach (string str in obj.parametrs)
                    cwf.listBox1.Items.Add(str);
                switch (obj.category)
                {
                    case WorkTypeClass.Category.walls:cwf.comboBox1.SelectedIndex = 0; break;
                    case WorkTypeClass.Category.floor: cwf.comboBox1.SelectedIndex = 1; break;
                    case WorkTypeClass.Category.ceiling: cwf.comboBox1.SelectedIndex = 2; break;
                    case WorkTypeClass.Category.floorPer: cwf.comboBox1.SelectedIndex = 3; break;
                    case WorkTypeClass.Category.ceilingPer: cwf.comboBox1.SelectedIndex = 4; break;
                    case WorkTypeClass.Category.other: cwf.comboBox1.SelectedIndex = 5; break;
                    default:cwf.comboBox1.SelectedIndex = 5;break;
                }
            }
            else
            {
                cwf.comboBox1.SelectedIndex = 3;
                cwf.textBox1.Text = "";
                cwf.textBox3.Text = "";
                cwf.listBox1.Items.Clear();
            }
        }

        private void CreateWorkTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
