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
using BuildingCalculator.Classes.Static;

namespace BuildingCalculator
{
    public partial class Form1 : Form
    {
        //комната
        public static List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
            JSONSerializeService.ReadInput("works.json");
            Rooms.Add((RoomTabs.TabPages[0].Controls["tabContent1"] as TabContent).Room);
            Rooms[0].Name = RoomTabs.TabPages[0].Text;
            List<string> names = new List<string>()
            {
                "Удалить"
            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                DeleteTab
            };
            Functions.ContextMenu(RoomTabs, names, functions);

            //PDFWriteService.HelloWorld();
            //PDFWriteService.CreateNewDocument("test");
            //PDFWriteService.AddHeader("test", "Заголовок", HeaderType.first);
            //PDFWriteService.AddHeader("test", "Заголовок2", HeaderType.first);
            //PDFWriteService.RenderDocToPdf("test");

            ExcelWorkServicecs.OpenFile("Book.xlsx");

            //string[,] ar = ExcelWorkServicecs.ReadWorkTypes();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lf = LoginClass.SignIn();
            lf.Top = (this.Top + (this.Height / 2)) - lf.Height / 2;
            lf.Left = (this.Left + (this.Width / 2)) - lf.Width / 2;
            lf.StartPosition = FormStartPosition.Manual;
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
                RoomTabs.TabPages[lastindex].Controls.Add(new TabContent());
                RoomTabs.SelectedIndex = lastindex;
                //Добавляем в список комнат
                Rooms.Add((RoomTabs.TabPages[lastindex].Controls["TabContent"] as TabContent).Room);
                Rooms[lastindex].Name = RoomTabs.TabPages[lastindex].Text;

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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Calculate(object sender, EventArgs e)
        {
            FormComponents.SelectWorkTypes selectworktypes = new FormComponents.SelectWorkTypes();
            selectworktypes.ShowDialog();
        }

        private void RoomTabs_DoubleClick(object sender, EventArgs e)
        {
            Form a = new Form();
            TabControl control = sender as TabControl;
            control.TabPages[control.SelectedIndex].Controls.Add(new TextBox());
            a.FormBorderStyle = FormBorderStyle.None;
            TextBox changename = new TextBox();
            a.Controls.Add(new TextBox());
            a.BackColor = Color.Transparent;
            a.Width = changename.Width;
            a.Height = changename.Height;
            //a.Text = control.TabPages[control.SelectedIndex].Text;
            a.Show();
            //new Form().Te((sender as TabControl).Name.ToString());
        }
    }
}
