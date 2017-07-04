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

namespace BuildingCalculator.FormComponents
{
    public partial class NewForm : Form
    {
        List<Room> Rooms = new List<Room>();
        public List<string[]> table = new List<string[]>();
        public NewForm()
        {
            InitializeComponent();
            MainTabs.ItemSize = new Size(0, 1);
            Rooms.Add(roomTabContent1.Room);
            Functions.ContextMenu(RoomTabs, new List<string>()
            {
                "Удалить"
            },
            new List<EventHandler>()
            {
                DeleteTab
            }
            );
            Functions.ContextMenu(dataGridView1, new List<string>()
            {
                "Обновить"
            },
            new List<EventHandler>()
            {
                Refresh
            });
            roomTabContent1.Room.CheckedWorks = roomTabContent1.worksTypeTree1.CheckedWorks;
        }
        private void Refresh(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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

                        //проверяем содержит 
                        if (everyworksumm.FirstOrDefault(x => x.Key.article == work.article && x.Key.category == work.category).Key == null)
                        {
                            everyworksumm.Add(work, 0);
                            paramssumm.Add(work, new double[work.ParametersValue.Length]);
                        }
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
                dataGridView1.Rows.Add(new string[] { pair.Key.article, quantity, pair.Key.formula, pair.Value.ToString() });
            }
            dataGridView1.Rows.Add(new string[] { "", "", "Сумма", commonsum.ToString() });

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
    }
}
