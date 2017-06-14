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
                            room.Elements.Add(new Element());
                            CurrentIndex.Text = room.Elements.Count.ToString();
                            Width.Text = "0";
                            Length.Text = "0";
                        }
                        else
                        {
                            if (currentindex<=room.Elements.Count)
                            {
                                CurrentIndex.Text = (currentindex).ToString();
                                Width.Text = room.Elements[currentindex- 1].Params["Width"].ToString();
                                Length.Text = room.Elements[currentindex -1].Params["Length"].ToString();
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
                                room.Elements.RemoveAt(currentindex);
                            CurrentIndex.Text = (currentindex).ToString();
                            Width.Text = room.Elements[currentindex-1].Params["Width"].ToString();
                            Length.Text = room.Elements[currentindex -1].Params["Length"].ToString();
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
                        room.Elements[index].Params["Width"] = value;
                        break;
                    case "Length":
                        room.Elements[index].Params["Length"] = value;
                        break;
                }
            }
            catch (FormatException)
            { }
        }
    }
}
