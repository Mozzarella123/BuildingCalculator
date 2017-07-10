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
using BuildingCalculator.FormComponents;
using BuildingCalculator.Classes.Static;
using System.Text.RegularExpressions;
using System.IO;

namespace BuildingCalculator.FormComponents
{
    public partial class NewForm : Form
    {
        public static List<Room> Rooms = new List<Room>();
        public static Form MainForm;
        public List<string[]> table = new List<string[]>();
        public NewForm()
        {
            JSONSerializeService.ReadInput("works.json");
            foreach(WorkTypeClass work in JSONSerializeService.OutputItems)
                work.ParametersValue = new double[work.parametrs.Count];
            ConfigWorksService.CheckSettings();
            InitializeComponent();
            MainForm = this;
            MainTabs.ItemSize = new Size(0, 1);
            Rooms.Add(roomTabContent1.Room);
            roomTabContent1.worktable.RowsAdded += Refresh;
            roomTabContent1.worktable.RowsRemoved += Refresh;
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
            AdminWorks.Title.Text = "Настройка работ";
            roomTabContent1.Room.CheckedWorks = roomTabContent1.worksTypeTree1.CheckedWorks;
            roomTabContent1.Room.Title = "Комната";
            
        }
        private void Create_Report(object sender, EventArgs e)
        {

            if (finaltable.RowCount != 1)
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
                string path = "";
                if (!Directory.Exists(ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory)))
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.ShowDialog();
                    path = dialog.SelectedPath + "\\Отчёт";
                    dialog.Dispose();
                }
                else
                    path = ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory) + "\\Отчёт" + PDFWriteService.CurrentDocumentsCount;
                int k;
                for ( k = 0; File.Exists(path + "(" + k + ").pdf"); k++) ;
                if (File.Exists(path+".pdf"))
                path += "(" + k + ")";
                PDFWriteService.CreateNewDocument(path);
                PDFWriteService.AddTable(path, content, headers,
                    new MigraDoc.DocumentObjectModel.ParagraphAlignment[] 
                    { MigraDoc.DocumentObjectModel.ParagraphAlignment.Left,
                        MigraDoc.DocumentObjectModel.ParagraphAlignment.Center,
                        MigraDoc.DocumentObjectModel.ParagraphAlignment.Center,
                        MigraDoc.DocumentObjectModel.ParagraphAlignment.Center }, 
                    new bool[] { false, false, false, false });
                PDFWriteService.RenderDocToPdf(path);
                MessageBox.Show("Отчёт создан");
            }
            else MessageBox.Show("Отчёт не создан, пустая таблица");
        }
        private void Refresh(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"[0-9]+");
            finaltable.Rows.Clear();
            RoomResT.Text = "";
            double[] results = new double[4];
            foreach (Room room in Rooms)
            {
                RoomResT.Text += 
                    room.Title + "\n" + 
                    "Периметр пола: "+room.BottomPerimeter + "\n" + 
                    "Площадь потолка и пола: "+room.Area + "\n" +
                    "Периметр потолка: " +room.Perimeter + "\n" +
                    "Площадь стен: " +room.CommonArea+ "\n" ;
                results[0] += room.BottomPerimeter;
                results[1] += room.Area;
                results[2] += room.Perimeter;
                results[3] += room.CommonArea;
            }
            RoomResT.Text += "==Общее=="+ "\n" +
                    "Периметр пола:" + results[0] + "\n" +
                    "Площадь потолка и пола: " + results[1] + "\n" +
                    "Периметр потолка: " + results[2] + "\n" +
                    "Площадь стен:" + results[3];
            SummT.Text = "========\n";
            double commonsumm = 0;
            for (int i = 0; i < Rooms.Count; i++)
            {
                SummT.Text += Rooms[i].Title + "\nСумма:" + Rooms[i].Summ +"\n";
                commonsumm += Rooms[i].Summ;
            }
            SummT.Text += "========" + "\nОбщая сумма:" + commonsumm;
            if (Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.ReportRooms)))
            {
                double commonsum = 0;
                foreach (Room room in Rooms)
                {
                    double sum = 0;
                    finaltable.Rows.Add(new string[] { room.Title, "", "", "" });
                    finaltable.Rows.Add(new string[] { "Площадь стен", room.CommonArea.ToString(), "", "" });
                    finaltable.Rows.Add(new string[] { "Площадь пола", room.Area.ToString(), "", "" });
                    finaltable.Rows.Add(new string[] { "Периметр пола", room.BottomPerimeter.ToString(), "", "" });
                    foreach (WorkTypeClass work in room.CheckedWorks)
                    {
                        finaltable.Rows.Add(new string[] { work.article, work.quantity, reg.Match(work.formula,0).Value, work.Price });
                        sum += work.GetPrice();
                    }
                    finaltable.Rows.Add(new string[] { "", "", "Сумма", sum.ToString() });
                    commonsum += sum;
                }
                finaltable.Rows.Add(new string[] { "", "", "Общая сумма", commonsum.ToString() });
                foreach (DataGridViewRow row in finaltable.Rows)
                    row.ReadOnly = true;
                finaltable.Rows[finaltable.RowCount - 1].ReadOnly = false;
            }
            else
            {
                //сумма для каждой работы
                Dictionary<WorkTypeClass, double> everyworksumm = new Dictionary<WorkTypeClass, double>();
                //сумма параметров
                Dictionary<WorkTypeClass, double[]> paramssumm = new Dictionary<WorkTypeClass, double[]>();
                double commonsum = 0;
                for (int i = 0; i < Rooms.Count; i++)
                {
                    for (int j = 0; j < Rooms[i].CheckedWorks.Count; j++)
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
                        quantity += paramssumm[pair.Key][i] + " " + pair.Key.parametrs[i] + "\n";
                    finaltable.Rows.Add(new string[] { pair.Key.article, quantity, reg.Match(pair.Key.formula, 0).Value, pair.Value.ToString() });
                    finaltable.Rows[finaltable.RowCount - 2].ReadOnly = true;

                }
                DataGridViewRow row = new DataGridViewRow();
                finaltable.Rows.Add(new string[] { "", "", "Сумма", commonsum.ToString() });
                finaltable.Rows[finaltable.RowCount - 2].ReadOnly = false;
            }
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
            foreach (Control menbut in MenuMarkup.Controls)
                if (menbut is Button)
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
                RepotRooms.Checked =  Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.ReportRooms)) ? true:false;
                Help.Checked = Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.Hints)) ? true : false;
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
                RoomTabContent content = new RoomTabContent() {Dock=DockStyle.Fill};
                content.worktable.RowsAdded += Refresh;
                content.worktable.RowsRemoved += Refresh;
                content.NonStandardWorkTable.RowsAdded += Refresh;
                content.NonStandardWorkTable.RowsRemoved += Refresh;
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
            //CreateWorkTypeForm.ActiveForm.Text 
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
                if (!LoginClass.IsLoged&&!Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.Remebered)))
                {
                    Form lf = LoginClass.SignIn();
                    Functions.CenterForm(lf, this);
                    lf.Show();
                    if (LoginClass.IsLoged)
                        AdminTable.Enabled = true;
                }
                else
                    AdminTable.Enabled = true;
        }
        private void DownloadfromExcel_Click(object sender, EventArgs e)
        {
            ExcelDownloadDialog.ShowDialog();
            
        }
        public void RefreshTrees()
        {
            Functions.RefreshList(AdminWorks.WorksList);
            Functions.RefreshList(roomTabContent1.worksTypeTree1.WorksList);
            foreach (WorkTypeClass work in JSONSerializeService.OutputItems)
                work.ParametersValue = new double[work.parametrs.Count];
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
            ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.Hints), Help.Checked.ToString());
            if (cmRadio.Checked)
                ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.Units), "sm");
            if (mRadio.Checked)
                ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.Units), "m");
            if (RepotRooms.Checked)
                ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.ReportRooms), "true");
            else
                ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.ReportRooms), "false");
            ConfigWorksService.ChangeValue(ConfigWorksService.getKey(ConfigWorksService.Options.ReportDirectory), SelectReportDirDialog.SelectedPath);
        }
        private void ChangeSaveDirectory_Click(object sender, EventArgs e)
        {
            if (SelectReportDirDialog.ShowDialog() == DialogResult.OK)
                SaveDirectoryInp.Text = SelectReportDirDialog.SelectedPath;
        }
        private void CreateReportBut_Click(object sender, EventArgs e)
        {
            Create_Report(finaltable, new EventArgs());
        }
        private void MenuMarkup_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RefreshTable_Click(object sender, EventArgs e)
        {
            Refresh(sender,e);
        }
    }
}
