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

namespace BuildingCalculator.FormComponents
{
    public partial class SelectWorkTypes : Form
    {
        public SelectWorkTypes()
        {
            InitializeComponent();
            //JSONSerializeService.ReadInput(Directory.GetCurrentDirectory() + "\\works.json");
            List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
            SelectWorksTree.Nodes.Add("Все категории");
            //Добавляем категорию
            foreach (var pair in WorkTypeClass.CategoryNames)
            {
                TreeNode newnode = new TreeNode(pair.Value);
                newnode.Name = pair.Value;
                SelectWorksTree.Nodes[0].Nodes.Add(newnode);
            }
            //Разбиваем по категориям
            foreach (WorkTypeClass ob in workslist)
            {
                TreeNode newnode = new TreeNode(ob.article);
                newnode.Name = WorkTypeClass.CategoryNames[ob.category];
                newnode.Tag = ob;
                SelectWorksTree.Nodes[0].Nodes[WorkTypeClass.CategoryNames[ob.category]].Nodes.Add(newnode);
            }


        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            foreach (WorkTypeClass elem in JSONSerializeService.OutputItems)
            {

            }
            PDFWriteService.InitializeNewFile("отчёт", Directory.GetCurrentDirectory());
            
        }
        private void Check(TreeNode node,bool check)
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
