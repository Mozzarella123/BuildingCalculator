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
        public NewForm()
        {
            InitializeComponent();
            MainTabs.ItemSize = new Size(0, 1);
            roomTabContent1.worksTypeTree1.WorksList.CheckBoxes = true;
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
            //Functions.SetToolTip("Escape или enter, чтобы применить", a.RoomTitle);           
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
    }
}
