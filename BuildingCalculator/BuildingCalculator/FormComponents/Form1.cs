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
    public partial class Form1 : Form
    {
        //комната
        public List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
            
            JSONSerializeService.ReadInput("works.json");
            Rooms.Add((RoomTabs.TabPages[0].Controls["tabContent1"] as TabContent).Room);
            List<string> names = new List<string>()
            {
                "Удалить"
            };
            List<EventHandler> functions = new List<EventHandler>()
            {
                DeleteTab
            };
            Functions.ContextMenu(RoomTabs, names, functions);

            string[,] content = new string[3, 3];
            string[] headers = new string[3];

            for (int i = 0; i < content.GetLength(0); i++)
            {
                headers[i] = "header" + i;
                for (int j = 0; j < content.GetLength(1); j++)
                    content[i, j] = (i + j).ToString();
            }
            PDFWriteService.InitializeNewFile("test", "test");
            //PDFWriteService.AddHeader(AddType.ActivePage, "Test", 30, 100, 600);
            //PDFWriteService.AddTable(AddType.ActivePage ,content, 400,headers);
            //PDFWriteService.AddPage();
            //PDFWriteService.AddText(AddType.newPage, "INPUTINPUTINPUTINPUTINPUTINPUTINPUTINPUTINPUT", 10, 100, 400);
            //PDFWriteService.endOfFile();

            //PDFWriteService.HelloWorld();
        }
        //private void ElementsChanged(object sender)
        //{
        //    room.Elements = (sender as Slider).Slides;
        //}
        public static void Input(TextBox input, Entity obj)
        {
            try
            {
                double value = Convert.ToDouble(input.Text);
                switch (input.Name)
                {
                    case "Width":
                        obj.Params["Width"] = value;
                        break;
                    case "Length":
                        obj.Params["Length"] = value;
                        break;
                }
            }
            catch (FormatException)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lf = LoginClass.SignIn();
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
                RoomTabs.TabPages.Insert(lastindex,"Комната " + (lastindex+1).ToString());
                RoomTabs.TabPages[lastindex].BackColor = Color.White;
                //добавляем содержимое
                RoomTabs.TabPages[lastindex].Controls.Add(new TabContent());
                RoomTabs.SelectedIndex = lastindex;
                //Добавляем в список комнат
                Rooms.Add((RoomTabs.TabPages[lastindex].Controls["TabContent"] as TabContent).Room);
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
    }
}
