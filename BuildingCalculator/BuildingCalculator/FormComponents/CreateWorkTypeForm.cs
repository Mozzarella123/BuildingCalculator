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
using BuildingCalculator.FormComponents;


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
            Functions.SetToolTip("Введите название работы", WorkTypeNameInp);
            Functions.SetToolTip("Выберите категорию,\n к которой относится работа", Category);
            Functions.SetToolTip("Чтобы добавить параметр для формулы расчёта,\n нажмите +",parameters.TextBox);
            Functions.SetToolTip("Формула для расчёта, например: 20*Площадь\n перенести параметры на это поле, \n ПКМ, чтобы очистить", formula.TextBox);
            Functions.SetToolTip("Добавить в формулу с помощью Enter или переноса \n Удалить правой кнопкой мыши ", Listofparams);
            Button = AddType;
            parameters.Button.Click += Add_Param;
            formula.TextBox.AllowDrop = true;
            //formula.TextBox.ReadOnly = true;
            formula.TextBox.Cursor = Cursors.Default;
            formula.TextBox.DragDrop += formula_DragDrop;
            formula.TextBox.DragEnter += formula_DragEnter;
            foreach (var pair in WorkTypeClass.CategoryNames)
                Category.Items.Add(pair.Value);
            Functions.ContextMenu(formula.TextBox, new List<string>() { "Очистить" }, new List<EventHandler>() { ClearFormula});
        }
        private void ClearFormula(object sender, EventArgs e)
        {
            formula.TextBox.Clear();
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
            Functions.CenterForm(cwf, NewForm.MainForm);
            cwf.Show();
            if (obj != null)
            {
                RedactedItemIndex = JSONSerializeService.OutputItems.IndexOf(obj);
                cwf.WorkTypeNameInp.Text = obj.article;
                cwf.formula.TextBox.Text = obj.formula;
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
                Clipboard.SetData(DataFormats.StringFormat, x.SelectedItem.ToString());
            if (e.KeyCode==Keys.Enter&& (formula.TextBox.Text == "" || !(Char.IsDigit(formula.TextBox.Text[formula.TextBox.Text.Length - 1]) || Char.IsLetter(formula.TextBox.Text[formula.TextBox.Text.Length - 1]))))
                formula.TextBox.Text += x.SelectedItem.ToString();
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {     
            if (e.Button != MouseButtons.Right)
            if(Listofparams.SelectedItem != null && Listofparams.SelectedItem.ToString() != "Журнал пуст")
                Listofparams.DoDragDrop(Listofparams.SelectedItem, DragDropEffects.Copy);
            
        }
        private void formula_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy ||
            e.Effect == DragDropEffects.Move)
            {
                if (formula.TextBox.Text==""||!(Char.IsDigit(formula.TextBox.Text[formula.TextBox.Text.Length-1])|| Char.IsLetter(formula.TextBox.Text[formula.TextBox.Text.Length - 1])))
                formula.TextBox.Text += e.Data.GetData(DataFormats.Text);
            }
        }
        private void formula_DragEnter(object sender, DragEventArgs e)
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
            //if (FCreate == null)
            //    FCreate = new FormulaCreater();
            //List<string> par = new List<string>();
            //for (int i = 0; i < Listofparams.Items.Count; i++)
            //    par.Add(Listofparams.Items[i].ToString());
            //FCreate.setParam(par);
            //FCreate.Show();
            WorkTypeClass work = new WorkTypeClass();
            work.article = WorkTypeNameInp.Text;
            work.formula = formula.TextBox.Text;
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

        private void formula_Load(object sender, EventArgs e)
        {

        }
    }
}
