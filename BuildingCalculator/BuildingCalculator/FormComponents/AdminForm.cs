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
            Functions.ContextMenu(listBox1, names, functions);
            FormClosing += new FormClosingEventHandler(_FormClosing);
            if (JSONSerializeService.InputItems != null)
                foreach (object ob in JSONSerializeService.InputItems)
                {
                    listBox1.Items.Add(((WorkTypeClass)ob));
                }
            
        }
        public void RefreshList()
        {
            listBox1.Items.Clear();
            if (JSONSerializeService.InputItems != null)
                foreach (object ob in JSONSerializeService.InputItems)
                {
                    listBox1.Items.Add(((WorkTypeClass)ob));
                }
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
            if (listBox1.SelectedItem != null)
                CreateWorkTypeForm.CreateWorkType((WorkTypeClass)listBox1.SelectedItem);
        } 
        private void Remove(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                JSONSerializeService.OutputItems.Remove((WorkTypeClass)listBox1.SelectedItem);
                JSONSerializeService.Save();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
