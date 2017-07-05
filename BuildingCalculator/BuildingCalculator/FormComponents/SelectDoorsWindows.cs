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
        List<Element> doors = new List<Element>()
        {
            Element.CreateElement
            (
                Entity.ParamName.Height,80,
                Entity.ParamName.Width,200,
                "Дверь",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Height,70,
                Entity.ParamName.Width,200,
                "Дверь",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),
            Element.CreateElement
            (
                Entity.ParamName.Height,90,
                Entity.ParamName.Width,200,
                "Дверь",
                new List<WorkTypeClass.Category>()
                { WorkTypeClass.Category.floorPer,WorkTypeClass.Category.walls }
            ),

        }
        ;
        public SelectDoorsWindows(WorkTypeClass.Category cat)
        {
            InitializeComponent();
            Cat = cat;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = (int)Math.Ceiling(5 / 4.0);
            tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 100;
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            for (int i = 0; i < 5; i++)
            {
                RadioButton radio = new RadioButton();
                radio.Name = "radio" + i;
                radio.Text = "Шаблон:" + " Имя" + " Размер";
                radio.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
                tableLayoutPanel1.Controls.Add(radio, i, i / 5);
            }
        }
        public WorkTypeClass.Category Cat;
        public void Refresh(WorkTypeClass.Category cat)
        {
            
        }
        bool ContainWork(WorkTypeClass work)
        {
            //foreach (ToolStripPanelRow r in tableLayoutPanel1.RowStyles)
            //    foreach (Control p in Controls) 
            //    {
            //            if (p is PictureBox)
            //                if (work.Equals(p.Tag))
            //                    return true;
            //    }
            return false;
        }
        static Image getImage(WorkTypeClass work)
        {
            var dir = Directory.CreateDirectory(ConfigWorksService.getValue("Images"));
            foreach(FileInfo f in dir.EnumerateFiles())
            {
                if (f.Name.Split('.')[0].ToLower() == work.article.ToLower())
                    
                    return Image.FromFile(f.FullName);
            }
            return null;
        }
        void ImageClick(object sender, EventArgs e)
        {
            MessageBox.Show(((sender as Control).Tag as WorkTypeClass).article);
        }

        private void SelectDoorsWindows_Load(object sender, EventArgs e)
        {
            Refresh(Cat);
        }

        private void SelectDoorsWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
