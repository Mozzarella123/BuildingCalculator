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
            FindNode((sender as TextBox).Text);

        }
        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                e.Handled = true;
            FindNode((sender as TextBox).Text);
        }
        protected  List<TreeNode> CurrentNodeMatches = new List<TreeNode>();
        protected int LastNodeIndex = 0;
        protected  string LastSearchText;
        protected void FindNode(string pattern)
        {
            TreeView tree = WorksList;
            string searchText = pattern;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };
            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, tree.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                if (tree.SelectedNode != null && tree.SelectedNode.Parent != null && tree.SelectedNode.Parent != selectedNode.Parent)
                    tree.SelectedNode.Parent.Collapse();
                tree.SelectedNode = selectedNode;
                tree.SelectedNode.Expand();
                if (LastNodeIndex == CurrentNodeMatches.Count)
                    LastNodeIndex = 0;
            }
        }
        protected  void SearchNodes(string SearchText, TreeNode StartNode)
        {
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//Recursive Search 
                };
                StartNode = StartNode.NextNode;
            };

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
                    CheckedWorks.Remove(CheckedWorks.Find(x => x.category == work.category && x.Article == work.Article));
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
                    TreeNode newnode = new TreeNode(ob.Article);
                    newnode.Text = ob.Article + " " + ob.Formula;
                    newnode.Name = ob.Article;
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
                        List<WorkTypeClass> works = workslist.FindAll(w => w.category == CheckedWorks[i].category && w.Article == CheckedWorks[i].Article && (w.Formula != CheckedWorks[i].Formula) || w.parametrs.Count != CheckedWorks[i].parametrs.Count);
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
                //tree.WorksList.
            }
        }
    }
}
