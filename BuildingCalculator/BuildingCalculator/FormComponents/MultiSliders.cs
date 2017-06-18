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
    public partial class MultiSliders : UserControl
    {
        public int PrevSlider = 0;
        public Dictionary<string, List<Element>> Elements = new Dictionary<string, List<Element>>();
        public List<object> ElementsNamesCollection = new List<object>();
        public MultiSliders()
        {
            InitializeComponent();
            ElementsNamesCollection.Add("Окна");
            ElementsNamesCollection.Add("Двери");
            foreach (object name in ElementsNamesCollection)
                ElementsNames.Items.Add(name);
            //Инициализируем все слайдеры при создании формы
            for (int i = 0; i < ElementsNames.Items.Count; i++)
            {
                Sliders.Controls.Add(new Slider());
                (Sliders.Controls[i] as Slider).Visible = false;
                (Sliders.Controls[i] as Slider).Dock = DockStyle.Fill;
                Elements.Add(ElementsNames.Items[i].ToString(), (Sliders.Controls[i] as Slider).Slides);
            }
            //Устанавливаем элемент по умолчанию
            ElementsNames.SelectedIndex = 0;
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
