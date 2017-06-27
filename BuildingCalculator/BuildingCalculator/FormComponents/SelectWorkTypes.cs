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
            GetCheckedNodes(SelectWorksTree.Nodes);
            Form1.Rooms[currentroom].CheckedCats = checkedcats;
            Form1.Rooms[currentroom].CheckedWorks = checkedworks;
            if (currentroom<Form1.Rooms.Count-1)
            {
                Functions.RefreshList(SelectWorksTree);
                currentroom++;
                RoomTitle.Text = Form1.Rooms[currentroom].Title;
            }
            else
            {
                string filename = "Отчёт";
                PDFWriteService.CreateNewDocument(filename);
                for (int i = 0; i < Form1.Rooms.Count; i++)
                {
                    PDFWriteService.AddHeader(filename, Form1.Rooms[i].Title, HeaderType.first);
                    foreach (var pair in WorkTypeClass.CategoryNames)
                    {
                        //Идем по выбранным категориям
                        if (Form1.Rooms[i].CheckedCats.Contains(pair.Key))
                        {
                            PDFWriteService.AddHeader(filename, WorkTypeClass.CategoryNames[pair.Key], HeaderType.second);
                            string[] headers = { "Название работы", "Площадь", "Цена" };
                            List<WorkTypeClass> cont = new List<WorkTypeClass>();
                            //Идем по всем выбранным работам 
                            foreach (WorkTypeClass ob in Form1.Rooms[i].CheckedWorks)
                            {
                                //Проверяем на принадлежность работы к категории
                                if (ob.category == pair.Key)
                                    cont.Add(ob);
                            }
                            string[,] content = new string[cont.Count, 3];
                            //Формируем массив для таблицы
                            for (int j = 0; j < cont.Count; j++)
                            {
                                content[j, 0] = cont[j].article;
                                content[j, 1] = Form1.Rooms[i].GetAreaFromCat(cont[j].category).ToString();
                                //формирование массива параметров
                                double[] parametrs = new double[0];
                                if (Form1.Rooms[i].GetAreaFromCat(cont[j].category)==-1)
                                {
                                    Array.Resize(ref parametrs, parametrs.Length + 1);

                                }
                                content[j, 2] = (cont[j].GetPrice(new double[] { Form1.Rooms[i].GetAreaFromCat(cont[j].category) })).ToString() + '\u2714';

                            }
                            PDFWriteService.AddTable(filename, content, headers);
                        }
                    }
                }
                PDFWriteService.RenderDocToPdf(filename);
                CalculateBut.Enabled = false;
            }
            if (currentroom + 1 == Form1.Rooms.Count)
                CalculateBut.Text = "Рассчитать";
            else
                CalculateBut.Text = "Следующая комната";                
        }
    }
}
