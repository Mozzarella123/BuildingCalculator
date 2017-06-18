using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator
{
    public partial class Slider : UserControl
    {
        //public delegate void MethodContainer(object sender);
        //public event MethodContainer ElementsChanged;
        private List<Element> slides = new List<Element>();
        public List<Element> Slides
        {
            get { return slides; }
        }
        public Slider()
        {
            InitializeComponent();
            slides.Add(new Element());
        }
        private void Slider_Controls_Click(object sender, EventArgs e)
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
                            slides.Add(new Element());
                            CurrentIndex.Text = slides.Count.ToString();
                            Width.Text = "0";
                            Length.Text = "0";
                            //ElementsChanged(this);
                        }
                        else
                        {
                            if (currentindex <= slides.Count)
                            {
                                CurrentIndex.Text = (currentindex).ToString();
                                Width.Text = slides[currentindex - 1].Params["Width"].ToString();
                                Length.Text = slides[currentindex - 1].Params["Length"].ToString();
                            }
                        }
                        break;
                    }
                case "-":
                case "<":
                    {
                        if (currentindex > 1)
                        {
                            currentindex--;
                            if (operation == "-")
                            {
                                slides.RemoveAt(currentindex);
                                //ElementsChanged(this);
                            }
                            CurrentIndex.Text = (currentindex).ToString();
                            Width.Text = slides[currentindex - 1].Params["Width"].ToString();
                            Length.Text = slides[currentindex - 1].Params["Length"].ToString();
                        }
                        break;
                    }
                default: break;
            }
        }
        private void Params_Input(object sender, EventArgs e)
        {
            TextBox input = sender as TextBox;
            int index = Convert.ToInt16(CurrentIndex.Text) - 1;
            Form1.Input(input, slides[index]);                
        }
        private void Params_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox input = sender as TextBox;
            if (input.Text == "0") input.Text = "";
        }
    }
}