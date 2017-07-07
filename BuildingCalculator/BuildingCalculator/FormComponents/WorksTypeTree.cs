using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;

namespace BuildingCalculator.FormComponents
{
    public partial class WorksTypeTree : UserControl
    {
        public List<WorkTypeClass> CheckedWorks = new List<WorkTypeClass>();
        public List<WorkTypeClass.Category> CheckedCats = new List<WorkTypeClass.Category>();
        public event CheckedNodesChangedHandler CheckedNodesChanged;
        public delegate void CheckedNodesChangedHandler(object sender, EventArgs e);
        public WorksTypeTree()
        {
            InitializeComponent();
            WorksList.Nodes.Add("Все категории");
            Functions.BuildList(WorksList, true, true);            
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            Functions.Search((sender as TextBox).Text, WorksList);

        }
        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                e.Handled = true;
            Functions.Search((sender as TextBox).Text, WorksList);
        }
        private void WorksList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count != 0)
            {
                e.Cancel = true;
                WorksList.SelectedNode = e.Node.FirstNode;
            }
            //e.Cancel = true;
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
        private void WorksList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            bool check = node.Checked;
            WorkTypeClass work = null;
            if (node.Tag is WorkTypeClass)
                work = node.Tag as WorkTypeClass;

            if (work != null)
            {
                if (check)
                {
                    if (!CheckedWorks.Contains(work))
                        CheckedWorks.Add((WorkTypeClass)work.Clone());
                }
                else
                    CheckedWorks.Remove(CheckedWorks.Find(x => x.category==work.category&&x.article==work.article));
                if (check)
                {
                    if (!CheckedCats.Contains(work.category))
                        CheckedCats.Add(work.category);
                }
                else
                    CheckedCats.Remove(work.category);
                if (CheckedNodesChanged!=null)
                CheckedNodesChanged(node, new EventArgs());
            }
        }
        private void WorksList_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            bool check = e.Node.Checked;
            if (e.Node.Nodes != null)
            {
                if (!check)
                    e.Node.ExpandAll();
                else
                    e.Node.Collapse();
                foreach (TreeNode node in e.Node.Nodes)
                    node.Checked = !check;
            }
        }
    }
}
