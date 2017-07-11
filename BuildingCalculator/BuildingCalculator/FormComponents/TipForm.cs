using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes.Static;
using System.Diagnostics;

namespace BuildingCalculator.FormComponents
{
    public partial class TipForm : Form
    {
        public TipForm(TipsService.Tip tip)
        {
            InitializeComponent();
            inviseTimer = new Timer();
            LifeTimer = new Timer();
            _tip = tip;
        }
        TipsService.Tip _tip;
        public new void Show()
        {
            
            if (Visible)
            {
                Reincarnation();
                return;
            }
            //if (!Visible)
            //    Reincarnation();
            TipText.Text = _tip._Text;
            this.Height = TipText.Height + 100;
            //this.Width = TipText.Width + 20;
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y + 20);
            base.Show();
            LifeTimer.Start();
        }

        private void TipForm_Load(object sender, EventArgs e)
        {
            LifeForm();
            inviseTimer.Stop(); 
        }
        public void LifeForm()
        {
            
            LifeTimer.Interval = 600;
            LifeTimer.Tick += new EventHandler((object sender, EventArgs e) => { InviseForm(); LifeTimer.Stop(); });
            LifeTimer.Start();   
        }
        public void Reincarnation()
        {
            Opacity = 1;
            inviseTimer.Stop();
            LifeForm();
        }
        Timer LifeTimer;
        Timer inviseTimer;
        public void InviseForm()
        {
            
            inviseTimer.Interval = 50;
            inviseTimer.Tick += new EventHandler((object sender, EventArgs e) => { Opacity -= 0.01; if (Opacity == 0) { Hide(); inviseTimer.Stop(); } });
            inviseTimer.Start();
        }

        private void TipForm_MouseEnter(object sender, EventArgs e)
        {
            Reincarnation();
        }
    }
}
