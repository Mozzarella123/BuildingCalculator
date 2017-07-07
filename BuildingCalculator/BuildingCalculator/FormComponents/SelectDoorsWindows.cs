    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace BuildingCalculator.FormComponents
{
    public partial class SelectDoorsWindows : Form
    {
        public Element Checked;
        List<Element> doors = new List<Element>()
        {
            Element.CreateElement
            (
                Entity.ParamName.Width,0.8,
                Entity.ParamName.Height,2,
                "Дверь 80x200",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,0.7,
                Entity.ParamName.Height,2,
                "Дверь 70x200",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,0.9,
                Entity.ParamName.Height,2,
                "Дверь 90x200",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),


        }
        ;
        List<Element> windows = new List<Element>()
        {
            Element.CreateElement
            (
                Entity.ParamName.Width,1.15,
                Entity.ParamName.Height,1.42,
                "Окно 137 серия 1420x1150",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,1.7,
                Entity.ParamName.Height,1.42,
                "Окно 137 серия 1420x1700",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,1.5796,
                Entity.ParamName.Height,2,
                "Окно 137 серия с дверью",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,1.48,
                Entity.ParamName.Height,1.53,
                "Окно 504-Д серия 1530x1480",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,2.23,
                Entity.ParamName.Height,1.53,
                "Окно 504-Д серия 1530x2230",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,1.93225,
                Entity.ParamName.Height,2,
                "Окно 504-Д серия с дверью",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,2.36,
                Entity.ParamName.Height,1.13,
                "Окно Корабль серия 1130x2360",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,2.38,
                Entity.ParamName.Height,1.42,
                "Окно Корабль серия 1420x2380",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,2.048,
                Entity.ParamName.Height,2,
                "Окно Корабль серия с дверью",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
                        Element.CreateElement
            (
                Entity.ParamName.Width,1.45,
                Entity.ParamName.Height,1.5,
                "Окно Хрущевка серия 1500x1450",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,2.04,
                Entity.ParamName.Height,1.5,
                "Окно Хрущевка серия 1500x2040",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Width,1.6083,
                Entity.ParamName.Height,2,
                "Окно Хрущевка серия с дверью",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.walls }
            )
        };
        public SelectDoorsWindows()
        {
            InitializeComponent();
            Doors.Controls.Add(CreateTable(doors));
            Windows.Controls.Add(CreateTable(windows));
        }
        TableLayoutPanel CreateTable(List<Element> patterns)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.Dock = DockStyle.Top;
            table.RowCount = (int)Math.Ceiling(patterns.Count / 4.0);
            table.ColumnCount = 3;
            table.Height = table.RowCount * 100;
            for (int i=0;i<table.ColumnCount;i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent) { Width = 33 });
            for (int i = 0; i < table.RowCount; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Absolute) { Height = 100 });
            for (int i = 0; i < patterns.Count; i++)
                table.Controls.Add(new RadioButton() { Anchor = AnchorStyles.Bottom|AnchorStyles.Top,Tag = patterns[i],Text = patterns[i].Title }, i % 3, i / 3);
            return table;
        }
        RadioButton GetCheckedRadio(Control control)
        {
            foreach (RadioButton button in control.Controls)
                if (button.Checked)
                    return button;
            return null;
        }          
        private void SelectDoorsWindows_Load(object sender, EventArgs e)
        {
            
        }
        private void SelectDoorsWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetCheckedRadio(tabControl1.TabPages[tabControl1.SelectedIndex].Controls[0])!=null)
            Checked = GetCheckedRadio(tabControl1.TabPages[tabControl1.SelectedIndex].Controls[0]).Tag as Element;
            Close();
        }
    }
}
