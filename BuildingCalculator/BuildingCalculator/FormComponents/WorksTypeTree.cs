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
            treelist.Add(this);
            treelist.RemoveAll(t => t == null);
            BuildList();
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
        public TreeNode FromID(WorkTypeClass work, TreeNode rootNode)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (node.Tag is WorkTypeClass&&node.Tag as WorkTypeClass == work) return node;
                TreeNode next = FromID(work, node);
                if (next != null) return next;
            }
            return null;
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
                    CheckedWorks.Remove(CheckedWorks.Find(x => x.FullEquals(work)));
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
        public void BuildList()
        {
            WorksList.Nodes.Clear();
            WorksList.Nodes.Add("Все категории");
            if (JSONSerializeService.InputItems != null)
            {
                TreeNodeCollection tree = WorksList.Nodes[0].Nodes;
                List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
                //Добавляем категорию
                foreach (var pair in WorkTypeClass.CategoryNames)
                {
                    TreeNode newnode = new TreeNode(pair.Value);
                    newnode.Name = pair.Value;
                    newnode.Tag = pair.Key;
                    tree.Add(newnode);
                }
                //Разбиваем по категориям
                foreach (WorkTypeClass ob in workslist)
                {
                    TreeNode newnode = new TreeNode(ob.Article);
                    newnode.Text = ob.Article;
                    newnode.Name = workslist.IndexOf(ob).ToString();
                    newnode.Tag = ob;
                    tree[WorkTypeClass.CategoryNames[ob.category]].Nodes.Add(newnode);
                }
                WorksList.Sort();
            }

        }
        public static void RefreshLists()
        {
            foreach (WorksTypeTree comp in treelist)
                comp.BuildList();
        }
        public static void AddtoList(WorkTypeClass work,bool check = false)
        {
            foreach (WorksTypeTree comp in treelist)
            {
                TreeNodeCollection tree = comp.WorksList.Nodes[0].Nodes;
                TreeNode newnode = new TreeNode();
                newnode.Text = work.Article;
                newnode.Name = work.ToString();
                newnode.Tag = work;
                if (check)
                    if (comp.CheckedWorks.Find(w => w.FullEquals(work))!=null)
                    newnode.Checked = check;
                tree[WorkTypeClass.CategoryNames[work.category]].Nodes.Add(newnode);
            }
        }
        public static void RemovefromList(WorkTypeClass work,bool edit=false)
        {
            foreach (WorksTypeTree comp in treelist)
            {
                TreeNodeCollection tree = comp.WorksList.Nodes[0].Nodes;
                TreeNode itemNode = null;
                foreach (TreeNode node in tree)
                {
                    itemNode = comp.FromID(work, node);
                    if (itemNode != null) { break; }
                }
                if (!edit)
                {
                    WorkTypeClass del;
                    if ((del = comp.CheckedWorks.Find(w => w.Equals(work))) != null)
                        comp.CheckedWorks.Remove(del);
                }
                tree[WorkTypeClass.CategoryNames[work.category]].Nodes.Remove(itemNode);
            }

        }
        public static void Edit(WorkTypeClass work,WorkTypeClass newwork)
        {
            RemovefromList(work,true);
            bool check = false;
            foreach (WorksTypeTree comp in treelist)
            {
                if (comp.WorksList.CheckBoxes)
                {
                    WorkTypeClass oldwork = comp.CheckedWorks.Find(w => w.FullEquals(work));
                    if (oldwork != null)
                    {                       
                        check = true;
                        comp.CheckedWorks.Remove(oldwork);
                        WorkTypeClass newwork1 = newwork.Clone() as WorkTypeClass;
                        if (oldwork.parametrs.Count == newwork.parametrs.Count)
                            oldwork.ParametersValue.CopyTo(newwork1.ParametersValue, 0);
                        comp.CheckedWorks.Add(newwork1 as WorkTypeClass);
                    }
                }
            }
            AddtoList(newwork, check);
        }
    }
}
