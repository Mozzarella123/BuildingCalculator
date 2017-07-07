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
using System.IO;

namespace BuildingCalculator
{
    public partial class Form1 : Form
    {
        //комната
        internal static List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
            //JSONSerializeService.ReadInput("works.json");
            Rooms.Add((RoomTabs.TabPages[0].Controls["tabContent1"] as TabContent).Room);
            Rooms[0].Title = RoomTabs.TabPages[0].Text;
            List<string> names = new List<string>()
            {
                "Удалить"
            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                DeleteTab
            };
            Functions.ContextMenu(RoomTabs, names, functions);
            Functions.SetToolTip("Чтобы изменить имя комнаты, щелкните два раза\nЧтобы добавить, нажмите +", RoomTabs);
            if (!ConfigWorksService.Contains("Images"))
                ConfigWorksService.Add("Images", "Data");
            if (!Directory.Exists(ConfigWorksService.getValue("Images")))
                Directory.CreateDirectory(ConfigWorksService.getValue("Images"));
            s = new SelectDoorsWindows();
            if (!ConfigWorksService.Contains("tutorial"))
                ConfigWorksService.Add("tutorial", "true");
            if (!ConfigWorksService.Contains("units"))
                ConfigWorksService.Add("units", "m");
            if (!ConfigWorksService.Contains("endDir"))
                ConfigWorksService.Add("endDir", Application.StartupPath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lf = LoginClass.SignIn();
            Functions.CenterForm(lf, this);
            lf.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONSerializeService.WriteOutput();
        }
        private void RoomTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            int lastindex = RoomTabs.TabPages.Count - 1;
            if (RoomTabs.SelectedIndex == lastindex)
            {
                //Добавляем новую вкладку
                RoomTabs.TabPages.Insert(lastindex, "Комната " + (lastindex + 1).ToString());
                RoomTabs.TabPages[lastindex].BackColor = Color.White;
                //добавляем содержимое
                TabContent content = new TabContent();
                content.Dock = DockStyle.Fill;
                content.Height.Text = tabContent1.Height.Text;                
                RoomTabs.TabPages[lastindex].Controls.Add(content);
                RoomTabs.SelectedIndex = lastindex;
                //Добавляем в список комнат
                Rooms.Add((RoomTabs.TabPages[lastindex].Controls["TabContent"] as TabContent).Room);
                Rooms[lastindex].Title = RoomTabs.TabPages[lastindex].Text;

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
        private void Calculate(object sender, EventArgs e)
        {
            SelectWorkTypes selectworktypes = new SelectWorkTypes();
            Functions.CenterForm(selectworktypes, this);
            selectworktypes.ShowDialog();
        }

        private void RoomTabs_DoubleClick(object sender, EventArgs e)
        {
            ChangeName a = new ChangeName();
            TabControl control = sender as TabControl;
            Functions.CenterForm(a, this);
            a.RoomTitle.TextChanged += changeName;
            a.RoomTitle.Text = RoomTabs.SelectedTab.Text;
            Functions.SetToolTip("Escape или enter, чтобы применить", a.RoomTitle);
            a.ShowDialog();
        }
        private void changeName(object sender, EventArgs e)
        {
            RoomTabs.SelectedTab.Text = (sender as TextBox).Text;
            Rooms[RoomTabs.SelectedIndex].Title = (sender as TextBox).Text;
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void tabContent1_Load(object sender, EventArgs e)
        {

        }
        static SettingForm sf = new SettingForm();
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.Show();
        }

        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSONSerializeService.SaveProject(Project.getProjectForSave(),"save.json");
        }

        private void загрузитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project load = JSONSerializeService.LoadProject("save.json");
            if (!load.compatibility)
                MessageBox.Show("");
            Rooms = load.Rooms;
        }
        private void новаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm a = new NewForm();
            a.Show();
        }
        SelectDoorsWindows s;
        private void button1_Click(object sender, EventArgs e)
        {
            s.Show();
        }
    }
}
