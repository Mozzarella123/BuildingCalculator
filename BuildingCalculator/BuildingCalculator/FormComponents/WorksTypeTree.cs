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
        public static List<WorksTypeTree> treelist = new List<WorksTypeTree>();
        public List<WorkTypeClass> CheckedWorks = new List<WorkTypeClass>();
        public List<WorkTypeClass.Category> CheckedCats = new List<WorkTypeClass.Category>();
        public event CheckedNodesChangedHandler CheckedNodesChanged;
        public delegate void CheckedNodesChangedHandler(object sender, EventArgs e);
        public WorksTypeTree()
        {
            InitializeComponent();
            WorksList.Nodes.Add("Все категории");
            treelist.Add(this);
            treelist.RemoveAll(t => t == null);
            BuildList(true, true);
            Classes.Static.TipsService.AddTip(Search, "Чтобы найти следующую работу, нажмите enter");
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
            if (e.Node != null && e.Node.Nodes.Count != 0)
            {
                e.Cancel = true;
                WorksList.SelectedNode = e.Node.FirstNode;
            }
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
                    if (!CheckedWorks.Exists(w => w.Equals(work)))
                        CheckedWorks.Add((WorkTypeClass)work.Clone());
                }
                else
                    CheckedWorks.Remove(CheckedWorks.Find(x => x.category == work.category && x.article == work.article));
                if (check)
                {
                    if (!CheckedCats.Contains(work.category))
                        CheckedCats.Add(work.category);
                }
                else
                    CheckedCats.Remove(work.category);
                CheckedNodesChanged?.Invoke(node, new EventArgs());
            }
        }
        private void WorksList_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            bool check = e.Node.Checked;
            if (e.Node.Nodes != null)
            {
                if (!check)
                {
                    if (e.Node.Level == 0)
                    {
                        DialogResult res = MessageBox.Show("Вы действительно хотите выбрать все работы?", "Выбрать всё", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            e.Node.Expand();
                            return;
                        }
                    }
                    e.Node.ExpandAll();
                }
                else
                    e.Node.Collapse();
                foreach (TreeNode node in e.Node.Nodes)
                    node.Checked = !check;
            }
        }
        private void WorksList_DoubleClick(object sender, EventArgs e)
        {

        }
        private void WorksList_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Color foreColor;
            if (e.Node == ((TreeView)sender).SelectedNode)
            {
                // is selected, draw a HightliteText rectangle under the text
                foreColor = SystemColors.HighlightText;
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, SystemColors.Highlight);
            }
            else
            {
                foreColor = (e.Node.ForeColor == Color.Empty) ? ((TreeView)sender).ForeColor : e.Node.ForeColor;
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            }

            TextRenderer.DrawText(
                e.Graphics,
                e.Node.Text,
                e.Node.NodeFont ?? e.Node.TreeView.Font,
                e.Bounds,
                foreColor,
                TextFormatFlags.GlyphOverhangPadding);
        }
        public void BuildList(bool allcats = true, bool sorted = true)
        {
            if (JSONSerializeService.InputItems != null)
            {
                TreeNodeCollection tree;
                if (!allcats)
                    tree = WorksList.Nodes;
                else
                    tree = WorksList.Nodes[0].Nodes;
                List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
                //Добавляем категорию
                foreach (var pair in WorkTypeClass.CategoryNames)
                {
                    TreeNode newnode = new TreeNode(pair.Value);
                    if (WorksList.CheckBoxes)
                        if (CheckedCats.Contains(pair.Key))
                            newnode.Checked = true;
                    newnode.Name = pair.Value;
                    newnode.Tag = pair.Key;
                    tree.Add(newnode);
                }
                //Разбиваем по категориям
                foreach (WorkTypeClass ob in workslist)
                {
                    TreeNode newnode = new TreeNode(ob.article);
                    newnode.Text = ob.article + " " + ob.formula;
                    newnode.Name = ob.article;
                    newnode.Tag = ob;
                    if (WorksList.CheckBoxes)
                        if (CheckedWorks.Find(w => w.Equals(ob)) != null)
                            newnode.Checked = true;
                    tree[WorkTypeClass.CategoryNames[ob.category]].Nodes.Add(newnode);
                }
                if (WorksList.CheckBoxes)
                    for (int i = 0; i < CheckedWorks.Count; i++)
                    {
                        if (workslist.Find(w => w.Equals(CheckedWorks[i])) == null)
                        {
                            CheckedWorks.Remove(CheckedWorks[i]);
                            i--;
                        }
                        List<WorkTypeClass> works = workslist.FindAll(w => w.category == CheckedWorks[i].category && w.article == CheckedWorks[i].article && (w.formula != CheckedWorks[i].formula) || w.parametrs.Count != CheckedWorks[i].parametrs.Count);
                        if (works!=null)
                        {
                            foreach (WorkTypeClass work in works)
                                if (CheckedWorks.Find(w => w.Equals(work)) != null)
                                {
                                    CheckedWorks.Remove(CheckedWorks[i]);
                                    CheckedWorks.Insert(i, (WorkTypeClass)work.Clone());
                                }
                        }
                    }

                if (sorted)
                    WorksList.Sort();
            }
        }
        public void RefreshList()
        {
            WorksList.Nodes.Clear();
            WorksList.Nodes.Add("Все категории");
            BuildList(true, true);
        }
        public void AddtoList(WorkTypeClass work)
        {
            foreach (WorksTypeTree tree in treelist)
            {
                tree.WorksList.Nodes
            }
        }
    }
}
