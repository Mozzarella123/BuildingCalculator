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
        }
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
        private void Input_Room(object sender, EventArgs e)
        {
            Input(sender as TextBox, room);
        }
        private void Length_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox input = sender as TextBox;
            if (input.Text == "0") input.Text = "";
        }
        private void Summ()
        {
            room.Elements = slider1.Slides;
            room.Elements.AddRange(slider2.Slides);

        }

        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lf = new LogInForm();
            lf.Show();
        }
    }
}
