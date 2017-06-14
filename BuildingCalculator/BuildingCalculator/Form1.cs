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

        List<Room.Element> roomelems = new List<Room.Element>();
        public Form1()
        {
            InitializeComponent();
            roomelems.Add(new Room.Element());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
               

        private void Slider_Controls(object sender, EventArgs e)
        {
            int currentindex = Convert.ToInt32(CurrentIndex.Text);
            string operation = (sender as Button).Text;
            switch (operation)
            {
                case "+":
                case ">":
                    {
                        currentindex++;
                        if (operation == "+")
                        {
                            roomelems.Add(new Room.Element());
                            CurrentIndex.Text = roomelems.Count.ToString();
                            Width.Text = "0";
                            Length.Text = "0";
                        }
                        else
                        {
                            if (currentindex<=roomelems.Count)
                            {
                                CurrentIndex.Text = (currentindex).ToString();
                                Width.Text = roomelems[currentindex- 1].Width.ToString();
                                Length.Text = roomelems[currentindex -1].Length.ToString();
                            }
                        }                        
                        break;
                    }
                case "-":
                case "<":
                    {
                        if (currentindex>1)
                        {
                            currentindex--;
                            if (operation == "-")
                                roomelems.RemoveAt(currentindex);
                            CurrentIndex.Text = (currentindex).ToString();
                            Width.Text = roomelems[currentindex-1].Width.ToString();
                            Length.Text = roomelems[currentindex -1].Length.ToString();
                        }
                        break;
                    }
                default: break;
            }
        }

        private void Params_Input(object sender, EventArgs e)
        {
            try
            {
                TextBox input = sender as TextBox;
                double value = Convert.ToDouble(input.Text);
                int index = Convert.ToInt16(CurrentIndex.Text) - 1;
                switch (input.Name)
                {
                    case "Width":
                        roomelems[index].Width = value;
                        break;
                    case "Length":
                        roomelems[index].Length = value;
                        break;
                }
            }
            catch (FormatException)
            { }
        }

        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
