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
            #region Контекстное меню
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
            #endregion
            #region Валидаторы 
            Functions.SetValidator(WidthInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(LengthInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(HeightInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(BottomArea, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(BottomPerInp, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(HeightInp2, Functions.ValidateType.OnlyNumbers);
            #endregion
            Functions.SetToolTip("Щелкните два раза по ячейке с параметром,\n чтобы изменить его", worktable);
            worksTypeTree1.WorksList.CheckBoxes = true;
            worksTypeTree1.CheckedNodesChanged += (sender, eargs) =>
            {
                RefrehTable(sender as TreeNode, new EventArgs());
            };
            worksTypeTree1.Enabled = true;
            worktable.DoubleClick += (sender, ea) =>
             {
                 DataGridView table = sender as DataGridView;
                 if (table.SelectedCells.Count == 1)
                     RefrehTable(new TreeNode() { Tag = table.SelectedCells[0].OwningRow.DataBoundItem as WorkTypeClass, Checked = true }, new EventArgs());
             };
            worktable.AutoGenerateColumns = false;
            NonStandardWorkTable.AutoGenerateColumns = false;
        }
        private void RefrehTable(object sender, EventArgs e)
        {
            //Area.Text = $"Площадь:{Room.Area}\nПериметр:{Room.Perimeter}\nПлощадь стен:{Room.CommonArea}";
            DataGridView worktable;
            switch (RoomTypeSelect.SelectedIndex)
            {
                case 0: worktable = this.worktable; break;
                case 1: worktable = this.NonStandardWorkTable; break;
                default: worktable = null; break;
            }           
            if (sender is TreeNode && (sender as TreeNode).Checked)
            {
                WorkTypeClass work = worksTypeTree1.CheckedWorks.Find(w => w.Equals(((sender as TreeNode).Tag as WorkTypeClass)));
                if (work.ParametersValue.Length != 0)
                {
                    int i1 = 0;
                    if (Room.GetAreaFromCat(work.category) != -1)
                    {
                        work.ParametersValue[0] = Room.GetAreaFromCat(work.category);
                        i1++;
                    }
                    for (int i = i1; i < work.ParametersValue.Length; i++)
                    {
                        inputparams param = new inputparams();
                        param.WorkTitle.Text = work.article;
                        param.Paramname.Text = work.parametrs[i];
                        Classes.Functions.CenterForm(param, ParentForm);
                        param.ShowDialog();
                        if (param.Paramname.Text == "")
                            param.Paramname.Text = "1";
                        work.ParametersValue[i] = double.Parse(param.TextBox.Text);
                    }
                    work.quantity = work.getQuantity();
                }
            }
            else
                foreach (WorkTypeClass work in worksTypeTree1.CheckedWorks)
                {
                    if (Room.GetAreaFromCat(work.category) != -1&& work.ParametersValue.Length!=0)
                        work.ParametersValue[0] = Room.GetAreaFromCat(work.category);
                    work.quantity = work.getQuantity();
                }
            BindingSource source = new BindingSource();
            source.DataSource = worksTypeTree1.CheckedWorks;           
            worktable.DataBindingComplete += (send, ea) =>
             {
                 foreach (DataGridViewRow dgvr in worktable.Rows)
                 {
                     WorkTypeClass work = dgvr.DataBoundItem as WorkTypeClass;
                     if (Room.GetAreaFromCat(work.category) == -1 || work.ParametersValue.Length > 1)
                         dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                 }
             };
            string[] names = new string[4];
            names[0] = "Title";
            names[1] = "Count";
            names[2] = "Price";
            names[3] = "Summ";
            if (worktable == NonStandardWorkTable)
                for (int i = 0; i < names.Length; i++)
                    names[i] += "1";
            worktable.DataSource = source;
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

        private void worktable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {           
            e.ThrowException = false;
            e.Cancel = true;
        }

        private void NonStandardWorkTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }
    }
}
