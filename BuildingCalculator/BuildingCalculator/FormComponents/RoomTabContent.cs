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
    public partial class RoomTabContent : UserControl
    {
        public Room Room = new Room();
        public RoomTabContent()
        {
            InitializeComponent();
            TypeTabs.ItemSize = new Size(0, 1);
            RoomTypeSelect.SelectedIndex = 0;
            Functions.ContextMenu(this, new List<string>()
                {
                    "Скрыть работы",
                    "Скрыть элементы"
                }, new List<EventHandler>()
                {
                    Hide_Works,
                    Hide_Elems
                }
            );
            Functions.ContextMenu(worktable, new List<string>()
                {
                    "Обновить",
                }, new List<EventHandler>()
                {
                    RefrehTable
                }
            );
            Functions.ContextMenu(NonStandardWorkTable, new List<string>()
                {
                    "Обновить",
                }, new List<EventHandler>()
                {
                    RefrehTable
                }
            );
            worksTypeTree1.WorksList.CheckBoxes = true;
            Functions.SetValidator(WidthInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(LengthInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(HeightInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(BottomArea, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(BottomPerInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(HeightInp2, Functions.ValidateType.OnlyNumbers);
            worksTypeTree1.CheckedNodesChanged += (sender, eargs) =>
            {
                RefrehTable(sender as TreeNode, new EventArgs());
            };
            splitContainer1.Panel1.MouseClick += (sender, eargs) =>
             {
                 if (worksTypeTree1.ClientRectangle.Contains(eargs.Location))
                     if (Room.Params.ContainsValue(0) || (Room.BottomPerimeter != 0 && !Room.Standard))
                     {
                         MessageBox.Show("Сначала заполните параметры комнаты");
                         worksTypeTree1.Enabled = false;
                     }
                     else worksTypeTree1.Enabled = true;
             };
            worktable.AutoGenerateColumns = false;
            NonStandardWorkTable.AutoGenerateColumns = false;
        }
        bool showerror = false;
        private void RefrehTable(object sender, EventArgs e)
        {
            Area.Text = $"Площадь:{Room.Area}\nПериметр:{Room.Perimeter}\nОбщая площадь:{Room.CommonArea}";

            DataGridView worktable;
            switch (RoomTypeSelect.SelectedIndex)
            {
                case 0: worktable = this.worktable; break;
                case 1: worktable = this.NonStandardWorkTable; break;
                default: worktable = null; break;
            }
            if (!Room.Params.ContainsValue(0) || (Room.Perimeter != 0 && !Room.Standard))
                worksTypeTree1.Enabled = true;
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
                    if (sender is TreeNode && (sender as TreeNode).Checked)
                    {
                        if (work.ParametersValue.Length == 0 || work.ParametersValue.Contains(0))
                        {
                            for (int i = i1; i < work.parametrs.Count; i++)
                            {
                                param.WorkTitle.Text = work.article;
                                param.Paramname.Text = work.parametrs[i];
                                //param.Width = param.Label.Text.Length * 10;
                                Classes.Functions.CenterForm(param, ParentForm);
                                param.ShowDialog();
                                Array.Resize(ref parameters, parameters.Length + 1);
                                if (param.Paramname.Text == "")
                                    param.Paramname.Text = "1";
                                parameters[parameters.Length - 1] = double.Parse(param.TextBox.Text);
                                param.WorkTitle.Text = "";
                                param.Paramname.Text = "1";
                            }
                            work.ParametersValue = parameters;
                        }
                    }
                }
                else
                    work.ParametersValue = new double[] { Room.GetAreaFromCat(work.category) };
                string quantity = "";
                //значения параметров
                for (int k = 0; k < work.parametrs.Count; k++)
                    quantity += work.ParametersValue[k] + " " + work.parametrs[k] + "\n";
                work.quantity = quantity;
                //worktable.Rows.Add(new string[] { work.article, quantity, work.formula, work.GetPrice().ToString() });
                //sum += work.GetPrice();
            }
            BindingSource source = new BindingSource();
            source.DataSource = worksTypeTree1.CheckedWorks;

            string[] names = new string[4];
            names[0] = "Title";
            names[1] = "Count";
            names[2] = "Price";
            names[3] = "Summ";
            if (worktable == NonStandardWorkTable)
                for (int i = 0; i < names.Length; i++)
                    names[i] += "1";

            worktable.DataSource = source;
            //worktable.Columns[0].Name = names[0];
            //worktable.Columns[1].Name = names[1];
            //worktable.Columns[2].Name = names[2];
            //worktable.Columns[3].Name = names[3];
            worktable.Columns[names[0]].DisplayIndex = 0;
            worktable.Columns[names[1]].DisplayIndex = 1;
            worktable.Columns[names[2]].DisplayIndex = 2;
            worktable.Columns[names[3]].DisplayIndex = 3;
            worktable.Columns[names[0]].DataPropertyName = "article";
            worktable.Columns[names[1]].DataPropertyName = "quantity";
            worktable.Columns[names[2]].DataPropertyName = "formula";
            worktable.Columns[names[3]].DataPropertyName = "Price";
            for (int i = 5; i < worktable.ColumnCount; i++)
                worktable.Columns[i].Visible = false;
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
                splitContainer1.SplitterDistance = (int)(base.Width * 0.25);
                ContextMenuStrip.Items[0].Text = "Скрыть работы";

            }
            splitContainer1.IsSplitterFixed = !splitContainer1.IsSplitterFixed;
            worksTypeTree1.Visible = !worksTypeTree1.Visible;

        }
        private void Hide_Elems(object sender, EventArgs e)
        {
            SplitContainer splitcontainer2;
            TableLayoutPanel RoomMarkup;
            switch (RoomTypeSelect.SelectedIndex)
            {
                case 0: { splitcontainer2 = this.splitContainer2; RoomMarkup = this.RoomMarkup; break; }
                case 1: { splitcontainer2 = splitContainer3; RoomMarkup = RoomMarkUp2; break; }
                default: { splitcontainer2 = null; RoomMarkup = null; break; }
            }
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
            TableLayoutPanel RoomMarkup;
            switch (RoomTypeSelect.SelectedIndex)
            {
                case 0: RoomMarkup = this.RoomMarkup; break;
                case 1: RoomMarkup = RoomMarkUp2; break;
                default: RoomMarkup = null; break;
            }
            RoomMarkup.RowCount++;
            ElementForm element = new ElementForm();
            element.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
            RoomMarkup.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            RoomMarkup.Controls.Add(element, 0, RoomMarkup.RowCount - 1);
            RoomMarkup.SetColumnSpan(element, RoomMarkup.ColumnCount);
            Room.Elements.Add(element.ElementLists);
            element.Focus();
            element.ValueChanged += RefrehTable;
            RefrehTable(worktable, new EventArgs());
        }
        private void Count_TextChanged(object sender, EventArgs e)
        {

        }
        private void MarkUp_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RoomMarkup_ControlRemoved(object sender, ControlEventArgs e)
        {
            TableLayoutPanel RoomMarkup;
            switch (RoomTypeSelect.SelectedIndex)
            {
                case 0: RoomMarkup = this.RoomMarkup; break;
                case 1: RoomMarkup = RoomMarkUp2; break;
                default: RoomMarkup = null; break;
            }
            RoomMarkup.RowCount--;
            Room.Elements.RemoveAll(item => item.Count == 0);
            RefrehTable(worktable, new EventArgs());
        }
        private void RoomTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeTabs.SelectedIndex = RoomTypeSelect.SelectedIndex;
            switch (TypeTabs.SelectedIndex)
            {
                case 0: Room.Standard = true; break;
                case 1: Room.Standard = false; break;
            }
            Room.Elements.Clear();
        }
        private void LengthInp_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            string Text = "";
            if (text.Text == "")
                Text = "0";
            else Text = text.Text;
            switch (text.Name)
            {
                case "WidthInp": Room.Params[Entity.ParamName.Width] = Convert.ToDouble(Text); break;
                case "HeightInp": Room.Params[Entity.ParamName.Height] = Convert.ToDouble(Text); break;
                case "LengthInp": Room.Params[Entity.ParamName.Length] = Convert.ToDouble(Text); break;
            }
            RefrehTable(worktable, new EventArgs());
        }

        private void worktable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HeightInp2_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            string Text = "";
            if (text.Text == "")
                Text = "0";
            else Text = text.Text;
            switch (text.Name)
            {
                case "BottomArea": Room.Area = Convert.ToDouble(Text); break;
                case "BottomPerInp": Room.BottomPerimeter = Convert.ToDouble(Text); break;
                case "HeightInp2": Room.Params[Entity.ParamName.Height] = Convert.ToDouble(Text); break;
            }
            RefrehTable(NonStandardWorkTable, new EventArgs());
        }
    }
}
