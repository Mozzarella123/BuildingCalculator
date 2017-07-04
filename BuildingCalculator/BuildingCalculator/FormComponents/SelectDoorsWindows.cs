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
        public SelectDoorsWindows(WorkTypeClass.Category cat)
        {
            InitializeComponent();
            Cat = cat;
            Refresh(Cat);
        }
        public WorkTypeClass.Category Cat;
        public void Refresh(WorkTypeClass.Category cat)
        {
            //tableLayoutPanel1.RowCount = 1;
            foreach (WorkTypeClass work in JSONSerializeService.OutputItems)
            {
                if (work.category == cat&&!ContainWork(work))
                {
                    tableLayoutPanel1.RowCount++;
                    Label l = new Label();
                    l.Dock = DockStyle.Fill;
                    l.Text = work.article;
                    tableLayoutPanel1.Controls.Add(l, 0, tableLayoutPanel1.RowCount - 1);
                    PictureBox p = new PictureBox();
                    p.Dock = DockStyle.Fill;
                    p.Image = getImage(work);
                    p.Tag = work;
                    p.Click += new EventHandler(ImageClick);
                    tableLayoutPanel1.Controls.Add(p, 1, tableLayoutPanel1.RowCount - 1);
                    
                }
            }
        }
        bool ContainWork(WorkTypeClass work)
        {
            foreach (ToolStripPanelRow r in tableLayoutPanel1.RowStyles)
                foreach (Control p in Controls) 
            {
                    if (p is PictureBox)
                        if (work.Equals(p.Tag))
                            return true;
            }
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
    }
}
