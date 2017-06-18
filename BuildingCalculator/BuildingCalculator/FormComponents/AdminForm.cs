using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(_FormClosing);
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

        private void button1_Click(object sender, EventArgs e)
        {
            CreateWorkTypeForm.CreateWorkType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                CreateWorkTypeForm.CreateWorkType((WorkTypeClass)listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                JSONSerializeService.OutputItems.Remove((WorkTypeClass)listBox1.SelectedItem);
                JSONSerializeService.Save();
            }
        }
    }
}
