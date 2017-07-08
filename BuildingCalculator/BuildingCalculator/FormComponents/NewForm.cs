﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;
using BuildingCalculator.FormComponents;
using BuildingCalculator.Classes.Static;
using System.IO;

namespace BuildingCalculator.FormComponents
{
    public partial class NewForm : Form
    {
        public static List<Room> Rooms = new List<Room>();
        public List<string[]> table = new List<string[]>();
        public NewForm()
        {
            JSONSerializeService.ReadInput("works.json");
            InitializeComponent();
            MainTabs.ItemSize = new Size(0, 1);
            Rooms.Add(roomTabContent1.Room);
            roomTabContent1.worktable.RowsAdded += Refresh;
            roomTabContent1.worktable.RowsRemoved += Refresh;
            finaltable.Rows[finaltable.RowCount - 1].ReadOnly = false;
            Functions.ContextMenu(RoomTabs, new List<string>()
            {
                "Удалить"
            },
            new List<EventHandler>()
            {
                DeleteTab
            }
            );
            Functions.ContextMenu(AdminWorks.WorksList, new List<string>()
            {
                "Добавить",
                "Редактировать",
                "Удалить"
            }, 
            new List<EventHandler>()
            {
                Add,
                Edit,
                Remove
            });
            Functions.ContextMenu(finaltable, new List<string>()
            {
                "Обновить"
            },
            new List<EventHandler>()
            {
                Refresh
                
            });
            roomTabContent1.Room.CheckedWorks = roomTabContent1.worksTypeTree1.CheckedWorks;
            
            
        }
        private void Create_Report(object sender, EventArgs e)
        {
            string[,] content = new string[finaltable.RowCount, finaltable.ColumnCount];
            string[] headers = new string[finaltable.ColumnCount];
            for (int i = 0; i < finaltable.ColumnCount; i++)
                headers[i] = finaltable.Columns[i].HeaderText;
            for (int i = 0; i < finaltable.RowCount; i++)
                for (int j = 0; j < finaltable.ColumnCount; j++)
                {
                    if (finaltable.Rows[i].Cells[j].Value != null)
                        content[i, j] = finaltable.Rows[i].Cells[j].Value.ToString();
                    else
                        content[i, j] = "";
                }
            string path = ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory) + "\\Отчёт" + PDFWriteService.CurrentDocumentsCount;
            PDFWriteService.CreateNewDocument(path);
            PDFWriteService.AddTable(path, content, headers,new bool[] { true,false,true,false });
            PDFWriteService.RenderDocToPdf(path);
            MessageBox.Show("Отчёт создан");
        }
        private void Refresh(object sender, EventArgs e)
        {
            finaltable.Rows.Clear();
            //сумма для каждой работы
            Dictionary<WorkTypeClass, double> everyworksumm = new Dictionary<WorkTypeClass, double>();
            //сумма параметров
            Dictionary<WorkTypeClass, double[]> paramssumm = new Dictionary<WorkTypeClass, double[]>();
            double commonsum = 0;
            for (int i=0;i<Rooms.Count;i++)
            {
                for  (int j=0;j<Rooms[i].CheckedWorks.Count;j++)
                {
                    WorkTypeClass work = Rooms[i].CheckedWorks[j];
                    if (work.ParametersValue.Length == 0)
                        work.ParametersValue = new double[work.parametrs.Count];
                    //проверяем содержит 
                    if (everyworksumm.FirstOrDefault(x => x.Key.article == work.article && x.Key.category == work.category).Key == null)
                        {
                            everyworksumm.Add(work, 0);
                            paramssumm.Add(work, new double[work.ParametersValue.Length]);
                        }
                    if (work.ParametersValue.Length == 0)
                        work.ParametersValue = new double[work.parametrs.Count];
                    for (int k = 0; k < Rooms[i].CheckedWorks[j].parametrs.Count; k++)
                        paramssumm.First(x => x.Key.article == work.article && x.Key.category == work.category).Value[k] += work.ParametersValue[k];
                    everyworksumm[everyworksumm.First(x => x.Key.article == work.article && x.Key.category == work.category).Key] += work.GetPrice();
                    commonsum += work.GetPrice();
                }
            }
            foreach (var pair in everyworksumm)
            {
                string quantity = "";
                for (int i = 0; i < paramssumm[pair.Key].Length; i++)
                    quantity += paramssumm[pair.Key][i]+ " " + pair.Key.parametrs[i] + "\n";
                finaltable.Rows.Add(new string[] { pair.Key.article, quantity, pair.Key.formula, pair.Value.ToString() });
                finaltable.Rows[finaltable.RowCount - 2].ReadOnly = true;

            }
            DataGridViewRow row = new DataGridViewRow();
            finaltable.Rows.Add(new string[] { "", "", "Сумма", commonsum.ToString() });
            finaltable.Rows[finaltable.RowCount - 2].ReadOnly = true;
        }
        private void DeleteTab(object sender, EventArgs e)
        {
            int index = RoomTabs.SelectedIndex;
            if (index != 0)
            {
                Rooms.RemoveAt(index);
                RoomTabs.TabPages.RemoveAt(index);
                RoomTabs.SelectedIndex = --index;
            }
        }
        private void MenuClick(object sender, EventArgs e)
        {
            Button but = sender as Button;
            foreach (Button menbut in MenuMarkup.Controls)
                menbut.BackColor = DefaultBackColor;
            but.BackColor = Color.LightGray;
            MainTabs.SelectedIndex = but.TabIndex;
            if (MainTabs.SelectedIndex==2)
            {
                SaveDirectoryInp.Text = ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory);
                if (ConfigWorksService.getValue(ConfigWorksService.Options.Units) == "sm")
                    cmRadio.Checked = true;
                else
                    mRadio.Checked = true;
            }
        }
        private void RoomTabs_DoubleClick(object sender, EventArgs e)
        {
            ChangeName a = new ChangeName();
            TabControl control = sender as TabControl;
            Functions.CenterForm(a, this);
            a.RoomTitle.TextChanged += ChangeRoomName;
            a.RoomTitle.Text = RoomTabs.SelectedTab.Text;
            Functions.SetToolTip("Escape или enter, чтобы применить", a.RoomTitle);           
            a.ShowDialog();
        }
        private void ChangeRoomName(object sender, EventArgs e)
        {
            RoomTabs.SelectedTab.Text = (sender as TextBox).Text;
            Rooms[RoomTabs.SelectedIndex].Title = (sender as TextBox).Text;
        }
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {

        }
        private void RoomTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lastindex = RoomTabs.TabPages.Count - 1;
            if (RoomTabs.SelectedIndex == lastindex)
            {
                //Добавляем новую вкладку
                RoomTabs.TabPages.Insert(lastindex, "Комната " + (lastindex + 1).ToString());
                RoomTabs.TabPages[lastindex].BackColor = Color.White;
                //добавляем содержимое
                RoomTabContent content = new RoomTabContent();
                content.worktable.RowsAdded += Refresh;
                content.worktable.RowsRemoved += Refresh;
                content.NonStandardWorkTable.RowsAdded += Refresh;
                content.NonStandardWorkTable.RowsRemoved += Refresh;
                content.Dock = DockStyle.Fill;
                content.HeightInp.Text = roomTabContent1.HeightInp.Text;
                RoomTabs.TabPages[lastindex].Controls.Add(content);
                RoomTabs.SelectedIndex = lastindex;
                //Добавляем в список комнат
                Rooms.Add(content.Room);
                Rooms[lastindex].Title = RoomTabs.TabPages[lastindex].Text;
                Rooms[lastindex].CheckedWorks = content.worksTypeTree1.CheckedWorks;

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

            if (AdminWorks.WorksList.SelectedNode != null)
            {

                CreateWorkTypeForm.CreateWorkType((WorkTypeClass)AdminWorks.WorksList.SelectedNode.Tag);

                CreateWorkTypeForm.Button.Text = "Редактировать тип работ";
                CreateWorkTypeForm.ActiveForm.Text = "Редактировать тип работ";
            }

        }
        private void Remove(object sender, EventArgs e)
        {
            if (AdminWorks.WorksList.SelectedNode != null&& AdminWorks.WorksList.SelectedNode.Tag is WorkTypeClass)
            {
                JSONSerializeService.OutputItems.Remove((WorkTypeClass)AdminWorks.WorksList.SelectedNode.Tag);
                JSONSerializeService.Save();
            }
        }
        private void splitContainer2_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (AdminTable.ClientRectangle.Contains(e.Location))
            {
                if (!LoginClass.IsLoged&&!Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.Remebered)))
                {
                    Form lf = LoginClass.SignIn();
                    Functions.CenterForm(lf, this);
                    lf.Show();
                }
                else
                    AdminTable.Enabled = true;
            }
        }
        private void DownloadfromExcel_Click(object sender, EventArgs e)
        {
            ExcelDownloadDialog.ShowDialog();
            Functions.BuildList(AdminWorks.WorksList);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            AdminWorks.WorksList.Nodes.Clear();
            JSONSerializeService.OutputItems.Clear();
            JSONSerializeService.Save();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Classes.Static.ExcelWorkServicecs.OpenFile(ExcelDownloadDialog.FileName);
        }
        private void SaveSetBut_Click(object sender, EventArgs e)
        {
            ConfigWorksService.ChangeValue("tutorial", Help.Checked.ToString());
            if (cmRadio.Checked)
                ConfigWorksService.ChangeValue("units", "sm");
            if (mRadio.Checked)
                ConfigWorksService.ChangeValue("units", "m");
            ConfigWorksService.ChangeValue("endDir", SelectReportDirDialog.SelectedPath);
        }
        private void ChangeSaveDirectory_Click(object sender, EventArgs e)
        {
            if (SelectReportDirDialog.ShowDialog() == DialogResult.OK)
            {
                SaveDirectoryInp.Text = SelectReportDirDialog.SelectedPath;
            }
        }
        private void CreateReportBut_Click(object sender, EventArgs e)
        {
            Create_Report(finaltable, new EventArgs());
        }
    }
}
