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

namespace BuildingCalculator.FormComponents
{
    public partial class SelectWorkTypes : Form
    {
        /// <summary>
        /// Список выбранных работ
        /// </summary>
        public List<WorkTypeClass> checkedworks = new List<WorkTypeClass>();
        /// <summary>
        /// Список выбранных категорий
        /// </summary>
        public List<WorkTypeClass.Category> checkedcats = new List<WorkTypeClass.Category>();
        private int currentroom = 0;
        public SelectWorkTypes()
        {
            InitializeComponent();
            List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
            SelectWorksTree.Nodes.Add("Все категории");
            Classes.Functions.BuildList(SelectWorksTree, true);
            if (currentroom + 1 == Form1.Rooms.Count)
                CalculateBut.Text = "Рассчитать";
            else
                CalculateBut.Text = "Следующая комната";            
            RoomTitle.Text = Form1.Rooms[currentroom].Title;
            
        }
        public void GetCheckedNodes(TreeNodeCollection nodes)
        {

            for (int i = 0; i < nodes.Count; i++)
            {
                TreeNode node = nodes[i];
                if (node.Checked && node.Level != 0)
                    //Распределяем узлы по категориям и работам
                    if (node.Tag is WorkTypeClass.Category)
                    {
                        if (node.Nodes.Count != 0)
                            checkedcats.Add((WorkTypeClass.Category)Convert.ToInt32(node.Tag));
                    }
                    else
                        checkedworks.Add(node.Tag as WorkTypeClass);

                if (node.Nodes.Count > 0)
                    GetCheckedNodes(node.Nodes);
            }


        }
        private void Check(TreeNode node, bool check)
        {
            if (node.FirstNode != null)
            {
                if (check)
                {
                    node.ExpandAll();
                    foreach (TreeNode nod in node.Nodes)
                        nod.Checked = true;
                }
                else
                {
                    node.Collapse();
                    foreach (TreeNode nod in node.Nodes)
                        nod.Checked = false;
                }

            }
            else return;
        }
        private void SelectWorksTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Check(e.Node, e.Node.Checked);
        }
        private void SelectWorksTree_DoubleClick(object sender, EventArgs e)
        {

        }
        private void SelectWorksTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void Calculate(object sender, EventArgs e)
        {
            //получаем выбранные категории и работы
            GetCheckedNodes(SelectWorksTree.Nodes);
            List<Room> rooms = Form1.Rooms;
            rooms[currentroom].CheckedCats.AddRange(checkedcats);
            rooms[currentroom].CheckedWorks.AddRange(checkedworks);
            //работа с параметрами
            foreach (WorkTypeClass work in checkedworks)
            {
                //если параметры не входят в список стандартных
                if (work.parametrs.Count>1|| rooms[currentroom].GetAreaFromCat(work.category) == -1)
                {
                    inputparams param = new inputparams();
                    double[] parameters = new double[0];
                    int i1 = 0;
                    //если есть один стандартный 
                    if (rooms[currentroom].GetAreaFromCat(work.category) != -1)
                    {
                        i1++;
                        Array.Resize(ref parameters, parameters.Length + 1);
                        parameters[0] = rooms[currentroom].GetAreaFromCat(work.category);
                    }
                    //заполняем параметры 
                    for (int i =i1; i < work.parametrs.Count; i++)
                    {
                        param.Label.Text = "Введите " + work.parametrs[i] + " в " + work.article;
                        param.Width = param.Label.Text.Length * 10;
                        Functions.CenterForm(param, this);
                        param.ShowDialog();
                        Array.Resize(ref parameters, parameters.Length + 1);
                        if (param.TextBox.Text == "")
                            param.TextBox.Text = "0";
                        parameters[parameters.Length - 1] = double.Parse(param.TextBox.Text);
                        param.Label.Text = "";
                    }           
                    work.Parameters = parameters;
                }
                else
                    work.Parameters = new double[] { rooms[currentroom].GetAreaFromCat(work.category) };
                
            }
            //работа с другими комнатами
            if (currentroom < rooms.Count - 1)
            {
                Functions.RefreshList(SelectWorksTree);
                currentroom++;
                RoomTitle.Text = rooms[currentroom].Title;
            }
            else
            {
                //формируем отчёт
                string filename = "Отчёт";
                PDFWriteService.CreateNewDocument(filename);
                double resultsum = 0;
                for (int i = 0; i < rooms.Count; i++)
                {
                    PDFWriteService.AddHeader(filename, rooms[i].Title, HeaderType.first);
                    string[] headers = { "Наименование работ", "Кол-во", "Цена", "Сумма" };
                    string[,] content = new string[rooms[i].CheckedWorks.Count+1, 4];
                    //Формируем массив для таблицы
                    double sum = 0;
                    for (int j = 0; j < rooms[i].CheckedWorks.Count; j++)
                    {
                        //Название
                        content[j, 0] = rooms[i].CheckedWorks[j].article;
                        string quantity = "";
                        //значения параметров
                        for (int k = 0; k < rooms[i].CheckedWorks[j].parametrs.Count; k++)
                            quantity += rooms[i].CheckedWorks[j].Parameters[k] + " " + rooms[i].CheckedWorks[j].parametrs[k] + "\n";
                        //Количество
                        content[j, 1] = quantity;
                        //Расценка
                        content[j, 2] = rooms[i].CheckedWorks[j].formula;
                        //Цена
                        content[j, 3] = (rooms[i].CheckedWorks[j].GetPrice().ToString() + "р.");
                        sum += rooms[i].CheckedWorks[j].GetPrice();
                    }
                    content[rooms[i].CheckedWorks.Count, 0] = "Сумма";
                    content[rooms[i].CheckedWorks.Count, 3] = sum.ToString()+"р.";
                    PDFWriteService.AddTable(filename, content, headers);
                    resultsum += sum;
                }
                PDFWriteService.AddParagraph(filename,"Общая сумма по всем комнатам: "+resultsum+"р.");
                PDFWriteService.RenderDocToPdf(filename);
                CalculateBut.Enabled = false;
            }
            if (currentroom + 1 == rooms.Count)
                CalculateBut.Text = "Рассчитать";
            else
                CalculateBut.Text = "Следующая комната";
            //сбрасываем выбранные работы
            checkedcats.Clear();
            checkedworks.Clear();
        }
    }
}
