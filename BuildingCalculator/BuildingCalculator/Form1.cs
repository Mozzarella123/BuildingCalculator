using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator
{
    public partial class Form1 : Form
    {

        Room room = new Room();
        public Form1()
        {
            InitializeComponent();
            room.Elements.Add(new Element());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
                 
        
    }
}
