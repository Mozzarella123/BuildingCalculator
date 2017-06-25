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
        public static Button Button;
        public CreateWorkTypeForm()
        {
            InitializeComponent();
            List<string> names = new List<string>()
            {
                "Удалить"

            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                Remove_Param
            };
            Functions.ContextMenu(Listofparams, names, functions);
            FormClosing += new FormClosingEventHandler(_FormClosing);
            Button = AddType;
            parameters.Button.Click += Add_Param;
        }
        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        private void Add_Param(object sender, EventArgs e)
        {
            if (parameters.TextBox.Text != ""){
                Listofparams.Items.Add(parameters.TextBox.Text);
                parameters.TextBox.Text = "";
            }
        }
        private void Remove_Param(object sender, EventArgs e)
        {
            if (Listofparams.SelectedItem != null)
                Listofparams.Items.RemoveAt(Listofparams.SelectedIndex);
        }
        static CreateWorkTypeForm cwf = new CreateWorkTypeForm();
        static int? RedactedItemIndex = null;      
        public static void CreateWorkType(WorkTypeClass obj=null)
        {
            cwf.Top = (ActiveForm.Top + (ActiveForm.Height / 2)) - cwf.Height / 2;
            cwf.Left = (ActiveForm.Left + (ActiveForm.Width / 2)) - cwf.Width / 2;
            cwf.StartPosition = FormStartPosition.Manual;
            cwf.Show();
            if (obj != null)
            {
                RedactedItemIndex = JSONSerializeService.OutputItems.IndexOf(obj);
                cwf.WorkTypeNameInp.Text = obj.article;
                cwf.formula.Text = obj.formula;
                cwf.Listofparams.Items.Clear();
                foreach (string str in obj.parametrs)
                    cwf.Listofparams.Items.Add(str);
                switch (obj.category)
                {
                    case WorkTypeClass.Category.walls:cwf.Category.SelectedIndex = 0; break;
                    case WorkTypeClass.Category.floor: cwf.Category.SelectedIndex = 1; break;
                    case WorkTypeClass.Category.ceiling: cwf.Category.SelectedIndex = 2; break;
                    case WorkTypeClass.Category.floorPer: cwf.Category.SelectedIndex = 3; break;
                    case WorkTypeClass.Category.ceilingPer: cwf.Category.SelectedIndex = 4; break;
                    case WorkTypeClass.Category.other: cwf.Category.SelectedIndex = 5; break;
                    default:cwf.Category.SelectedIndex = 5;break;
                }
            }
            else
            {
                cwf.Category.SelectedIndex = 3;
                cwf.WorkTypeNameInp.Text = "";
                cwf.formula.Text = "";
                cwf.Listofparams.Items.Clear();
            }
            
        }
        private void CreateWorkTypeForm_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox x = sender as ListBox;
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                Clipboard.SetData(DataFormats.StringFormat, x.SelectedItem.ToString());
            }
            
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {     
            if (e.Button != MouseButtons.Right)
            if(Listofparams.SelectedItem != null && Listofparams.SelectedItem.ToString() != "Журнал пуст")
                Listofparams.DoDragDrop(Listofparams.SelectedItem, DragDropEffects.Copy);
            
        }
        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy ||
            e.Effect == DragDropEffects.Move)
            {
                formula.Text += e.Data.GetData(DataFormats.Text);
            }
        }
        private void textBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddWorkType(object sender, EventArgs e)
        {
            WorkTypeClass work = new WorkTypeClass();
            work.article = WorkTypeName.Text;
            work.formula = formula.Text;
            var numer = Listofparams.Items.GetEnumerator();
            while (numer.MoveNext())
                work.parametrs.Add(numer.Current.ToString());
            work.category = (WorkTypeClass.Category)(Category.SelectedIndex);
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
    }
}
