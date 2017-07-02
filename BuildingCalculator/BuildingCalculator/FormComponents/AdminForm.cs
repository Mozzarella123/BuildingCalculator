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
using BuildingCalculator.Classes.Static;

namespace BuildingCalculator
{
    public partial class AdminForm : Form
    {
        const string divider = "=----------------------------------------=";
        public AdminForm()
        {
            
            InitializeComponent();
            List<string> names = new List<string>()
            {
                "Добавить",
                "Редактировать",
                "Удалить"
            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                Add,
                Edit,
                Remove
            };
            Functions.ContextMenu(ItemsinTree, names, functions);
            FormClosing += new FormClosingEventHandler(_FormClosing);
            Functions.BuildList(ItemsinTree);
            Functions.SetToolTip("Нажмите правую кнопку мыши.\n Для редактирования выберите работу", ItemsinTree);
        }
        public void RefreshList()
        {
            Functions.RefreshList(ItemsinTree);
            
        }
        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        private void Add(object sender, EventArgs e)
        {
            CreateWorkTypeForm.CreateWorkType();
            CreateWorkTypeForm.Button.Text = "Добавить тип работ";
            CreateWorkTypeForm.ActiveForm.Text = "Добавить тип работ";

        }
        private void Edit(object sender, EventArgs e)
        {

            if (ItemsinTree.SelectedNode != null)
            {
                
                CreateWorkTypeForm.CreateWorkType((WorkTypeClass)ItemsinTree.SelectedNode.Tag);
                
                CreateWorkTypeForm.Button.Text = "Редактировать тип работ";
                CreateWorkTypeForm.ActiveForm.Text = "Редактировать тип работ";
            }

        }
        private void Remove(object sender, EventArgs e)
        {
            if (ItemsinTree.SelectedNode != null)
            {
                JSONSerializeService.OutputItems.Remove((WorkTypeClass)ItemsinTree.SelectedNode.Tag);
                JSONSerializeService.Save();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemsinTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ItemsinTree.SelectedNode = e.Node;
        }

        private void ItemsinTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level == 0)
            {               
                e.Cancel = true;
                if (e.Node.Nodes.Count!=0)
                e.Node.TreeView.SelectedNode = e.Node.Nodes[0];
            }                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ExcelWorkServicecs.OpenFile(openFileDialog1.FileName);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ItemsinTree.Nodes.Clear();
            JSONSerializeService.OutputItems.Clear();
            JSONSerializeService.Save();
        }
        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

        private string LastSearchText;


        private void Search()
        {
            string searchText = SearchInp.Text;
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
                SearchNodes(searchText, ItemsinTree.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 )
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                this.ItemsinTree.SelectedNode = selectedNode;
                this.ItemsinTree.SelectedNode.Expand();
                this.ItemsinTree.Select();
                if (LastNodeIndex == CurrentNodeMatches.Count)
                    LastNodeIndex = 0;
            }
        }

        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
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
        private void Search(object sender, EventArgs e)
        {
            Functions.Search((sender as TextBox).Text, ItemsinTree);
        }

        private void SearchInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            e.Handled = true;
            Functions.Search((sender as TextBox).Text, ItemsinTree);
        }
    }
}
