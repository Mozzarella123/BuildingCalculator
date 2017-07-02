using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.FormComponents
{
    public partial class RoomTabContent : UserControl
    {
        public List<string[]> table = new List<string[]>();
        public Room Room = new Room();
        public RoomTabContent()
        {
            InitializeComponent();
            TypeTabs.ItemSize = new Size(0,1);
            RoomTypeSelect.SelectedIndex = 0;
            Classes.Functions.ContextMenu(this, new List<string>()
                {
                    "Скрыть работы",
                    "Скрыть элементы"
                }, new List<EventHandler>()
                {
                    Hide_Works,
                    Hide_Elems
                }
            );
            Classes.Functions.ContextMenu(dataGridView1, new List<string>()
                {
                    "Обновить",
                }, new List<EventHandler>()
                {
                    RefrehTable
                }
            );
            
        }
        private void RefrehTable(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (WorkTypeClass work in worksTypeTree1.CheckedWorks)
            {
                //если параметры не входят в список стандартных
                if (work.parametrs.Count > 1 || Room.GetAreaFromCat(work.category) == -1)
                {
                    inputparams param = new inputparams();
                    double[] parameters = new double[0];
                    int i1 = 0;
                    //если есть один стандартный 
                    if (Room.GetAreaFromCat(work.category) != -1)
                    {
                        i1++;
                        Array.Resize(ref parameters, parameters.Length + 1);
                        parameters[0] = Room.GetAreaFromCat(work.category);
                    }
                    //заполняем параметры 
                    for (int i = i1; i < work.parametrs.Count; i++)
                    {
                        param.Label.Text = "Введите " + work.parametrs[i] + " в " + work.article;
                        param.Width = param.Label.Text.Length * 10;
                        Classes.Functions.CenterForm(param, this.ParentForm);
                        param.ShowDialog();
                        Array.Resize(ref parameters, parameters.Length + 1);
                        if (param.TextBox.Text == "")
                            param.TextBox.Text = "0";
                        parameters[parameters.Length - 1] = double.Parse(param.TextBox.Text);
                        param.Label.Text = "";
                    }
                    work.Parameters = parameters;
                }
                else
                    work.Parameters = new double[] { Room.GetAreaFromCat(work.category) };
                string quantity = "";
                //значения параметров
                for (int k = 0; k < work.parametrs.Count; k++)
                    quantity += work.Parameters[k] + " " + work.parametrs[k] + "\n";
                dataGridView1.Rows.Add(new string[] { work.article, quantity, work.formula, work.GetPrice().ToString() });
            }

        }
        private void Hide_Works(object sender, EventArgs e)
        {
            
            if (worksTypeTree1.Visible)
            {
                splitContainer1.SplitterDistance = 0;
                ContextMenuStrip.Items[0].Text = "Показать работы";
            }
            else
            {
                splitContainer1.SplitterDistance = (int)(base.Width*0.25);
                ContextMenuStrip.Items[0].Text = "Скрыть работы";

            }
            splitContainer1.IsSplitterFixed = !splitContainer1.IsSplitterFixed;
            worksTypeTree1.Visible = !worksTypeTree1.Visible;
            
        }
        private void Hide_Elems(object sender, EventArgs e)
        {
            if (RoomMarkup.Visible)
            {
                splitContainer2.SplitterDistance = 0;
                ContextMenuStrip.Items[1].Text = "Показать элементы";
            }
            else
            {
                splitContainer2.SplitterDistance = (int)(base.Width * 0.25);
                ContextMenuStrip.Items[1].Text = "Скрыть элементы";

            }
            splitContainer2.IsSplitterFixed = !splitContainer2.IsSplitterFixed;
            RoomMarkup.Visible = !RoomMarkup.Visible;
        }
        private void AddElement_Click(object sender, EventArgs e)
        {
            RoomMarkup.RowCount++;
            ElementForm element = new ElementForm();
            element.ContInp.TextChanged += Count_TextChanged;
            element.Anchor = (AnchorStyles.Top|AnchorStyles.Bottom);
            RoomMarkup.Height += element.Height;
            RoomMarkup.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            RoomMarkup.Controls.Add(element,0, RoomMarkup.RowCount - 1);                   
            RoomMarkup.SetColumnSpan(element, RoomMarkup.ColumnCount);
            element.Focus();
        }
        private void Count_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MarkUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoomMarkup_ControlRemoved(object sender, ControlEventArgs e)
        {
            ElementForm element = new ElementForm();
            RoomMarkup.Height -= element.Height;
            RoomMarkup.RowCount--;

        }

        private void RoomTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeTabs.SelectedIndex = RoomTypeSelect.SelectedIndex;
        }
    }
}
