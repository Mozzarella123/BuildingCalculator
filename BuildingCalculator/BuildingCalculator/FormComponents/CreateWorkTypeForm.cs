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
using BuildingCalculator;


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
                Remove_Param
            };
            Functions.ContextMenu(Listofparams, names, functions);
            FormClosing += new FormClosingEventHandler(_FormClosing);
            Classes.Static.TipsService.AddTip( WorkTypeNameInp, "Введите название работы");
            Classes.Static.TipsService.AddTip( Category, "Выберите категорию,\n к которой относится работа");
            Classes.Static.TipsService.AddTip(parameters.TextBox,"Здесь нужно ввести параметры, которые используются в формуле, чтобы добавить параметр нажмите +,первый параметр относится к площади категории");
            Classes.Static.TipsService.AddTip(formula.TextBox,"Здесь нужно ввести формулу для расчёта, с параметрами занесенными в лист справа, по шаблону Цена*Параметр1*Параметр2, пример 100*кв_м*слои");
            Classes.Static.TipsService.AddTip( Listofparams, "Чтобы добавить параметр в формулу нажмите enter или перенесите его на поле формулы");
            parameters.Button.Click += Add_Param;
            formula.TextBox.AllowDrop = true;
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
            
            if (obj != null)
            {
                cwf.AddType.Text = "Редактировать работу";
                cwf.Text = "Редактировать работу";
                RedactedItemIndex = JSONSerializeService.OutputItems.IndexOf(obj);
                cwf.WorkTypeNameInp.Text = obj.article;
                cwf.formula.TextBox.Text = obj.formula;
                cwf.Listofparams.Items.Clear();
                foreach (string str in obj.parametrs)
                    cwf.Listofparams.Items.Add(str);
                cwf.Category.SelectedIndex = (int)obj.category;
            }
            else
            {
                cwf.AddType.Text = "Создать работу";
                cwf.Text = "Создать работу";
                cwf.Category.SelectedIndex = 3;
                cwf.WorkTypeNameInp.Text = "";
                cwf.formula.Text = "";
                cwf.Listofparams.Items.Clear();
            }
            cwf.ShowDialog();
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
            WorkTypeClass work = new WorkTypeClass();
            work.article = WorkTypeNameInp.Text;
            work.setPriceFunc(formula.TextBox.Text);
            var numer = Listofparams.Items.GetEnumerator();
            while (numer.MoveNext())
                work.parametrs.Add(numer.Current.ToString());
            if (Category.SelectedIndex==-1)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
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
