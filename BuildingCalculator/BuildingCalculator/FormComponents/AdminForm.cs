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
            BuildList();
        }
        private void BuildList()
        {
            if (JSONSerializeService.InputItems != null)
            {
                List<WorkTypeClass> workslist = JSONSerializeService.InputItems;
                //Добавляем категорию
                foreach (var pair in WorkTypeClass.CategoryNames)
                {
                    TreeNode newnode = new TreeNode(pair.Value);
                    newnode.Name = pair.Value;
                    ItemsinTree.Nodes.Add(newnode);
                }
                //Разбиваем по категориям
                foreach (WorkTypeClass ob in workslist)
                {
                    TreeNode newnode = new TreeNode(ob.article);
                    newnode.Name = WorkTypeClass.CategoryNames[ob.category];
                    newnode.Tag = ob;               
                    ItemsinTree.Nodes[WorkTypeClass.CategoryNames[ob.category]].Nodes.Add(newnode);
                }
            }
        }
        public void RefreshList()
        {
            ItemsinTree.Nodes.Clear();
            BuildList();
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
        }
        private void Edit(object sender, EventArgs e)
        {
            if (ItemsinTree.SelectedNode!=null)
                CreateWorkTypeForm.CreateWorkType((WorkTypeClass)ItemsinTree.SelectedNode.Tag);
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
            
        }

        private void ItemsinTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (WorkTypeClass.CategoryNames.ContainsValue(e.Node.Text))
                e.Cancel = true;
        }
    }
}
