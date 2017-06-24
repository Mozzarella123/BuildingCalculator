using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using MigraDoc.RtfRendering;

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
        public SelectWorkTypes()
        {
            InitializeComponent();
            List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
            SelectWorksTree.Nodes.Add("Все категории");
            //Добавляем категорию
            foreach (var pair in WorkTypeClass.CategoryNames)
            {
                TreeNode newnode = new TreeNode(pair.Value);
                newnode.Name = pair.Value;
                //Задаем категорию
                newnode.Tag = pair.Key;
                SelectWorksTree.Nodes[0].Nodes.Add(newnode);
            }
            //Разбиваем по категориям
            foreach (WorkTypeClass ob in workslist)
            {
                TreeNode newnode = new TreeNode(ob.article);
                newnode.Name = WorkTypeClass.CategoryNames[ob.category];
                //Задаем тип работ
                newnode.Tag = ob;
                SelectWorksTree.Nodes[0].Nodes[WorkTypeClass.CategoryNames[ob.category]].Nodes.Add(newnode);
            }
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
        private void Calculate_Click(object sender, EventArgs e)
        {
            GetCheckedNodes(SelectWorksTree.Nodes);
            Document otchet = new Document();
            PDFWriteService.InitializeNewFile(otchet, "Отчёт");
            otchet.Info.Title = "Otchet";
            otchet.Info.Subject = "Отчёт";
            for (int i = 0; i < Form1.Rooms.Count; i++)
            {
                otchet.AddSection();
                otchet.LastSection.AddParagraph(Form1.Rooms[i].Name, "Heading1");
                foreach (var pair in WorkTypeClass.CategoryNames)
                {
                    //Идем по выбранным категориям
                    if (checkedcats.Contains(pair.Key))
                    {
                        otchet.LastSection.AddParagraph(WorkTypeClass.CategoryNames[pair.Key], "Heading2");
                        string[] headers = { "Название работы", "Площадь", "Цена" };
                        List<WorkTypeClass> cont = new List<WorkTypeClass>();
                        //Идем по всем выбранным работам 
                        foreach (WorkTypeClass ob in checkedworks)
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
                            content[j, 2] = (cont[j].GetPrice(new double[] { Form1.Rooms[i].GetAreaFromCat(cont[j].category) }) ).ToString() + '\u2714';
                        }
                        PDFWriteService.AddTable(otchet, content, headers);
                    }
                }
            }
            PDFWriteService.SaveDocument(otchet);
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
    }
}
