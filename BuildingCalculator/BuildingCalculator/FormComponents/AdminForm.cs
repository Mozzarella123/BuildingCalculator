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
    }
}
