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
        //комната
        public Room room = new Room();
        //Элементы комнаты
        public Dictionary<string,List<Element>> Elements = new Dictionary<string, List<Element>>();
        public int PrevSlider=0;
        public Form1()
        {
            InitializeComponent(); 
            //Инициализируем все слайдеры при создании формы
            for(int i=0;i<ElementsNames.Items.Count;i++)
            {
                Sliders.Controls.Add(new Slider());
                (Sliders.Controls[i] as Slider).Visible = false;
                (Sliders.Controls[i] as Slider).Dock = DockStyle.Fill;
                Elements.Add(ElementsNames.Items[i].ToString(), (Sliders.Controls[i] as Slider).Slides);
            }
            //Устанавливаем элемент по умолчанию
            ElementsNames.SelectedIndex = 0;
        }
        //private void ElementsChanged(object sender)
        //{
        //    room.Elements = (sender as Slider).Slides;
        //}
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
        private void админкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lf = new LogInForm();
            lf.Show();
        }
        private void CalculateAll(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SliderChanged(object sender, EventArgs e)
        {

            ComboBox select = sender as ComboBox;
            (Sliders.Controls[PrevSlider] as Slider).Visible = false;
            (Sliders.Controls[select.SelectedIndex] as Slider).Visible = true;
            PrevSlider = select.SelectedIndex;
        }


    }
}
