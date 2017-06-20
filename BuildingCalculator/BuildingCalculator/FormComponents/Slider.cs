using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;

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
            Functions.SetValidator(Height, Functions.ValidateType.OnlyNumbers);
            Functions.SetValidator(Width, Functions.ValidateType.OnlyNumbers);
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
                            Height.Text = "0";
                            Width.Text = "0";
                        }
                        else
                        {
                            if (currentindex <= slides.Count)
                            {
                                CurrentIndex.Text = (currentindex).ToString();
                                Height.Text = slides[currentindex - 1].Params["Height"].ToString();
                                Width.Text = slides[currentindex - 1].Params["Width"].ToString();
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
                            }
                            CurrentIndex.Text = (currentindex).ToString();
                            Height.Text = slides[currentindex - 1].Params["Height"].ToString();
                            Width.Text = slides[currentindex - 1].Params["Width"].ToString();
                        }
                        break;
                    }
                default: break;
            }
        }
        private void Params_Input(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(CurrentIndex.Text) - 1;
            Functions.SetEntityParams(slides[index], sender as TextBox);                
        }
    }
}