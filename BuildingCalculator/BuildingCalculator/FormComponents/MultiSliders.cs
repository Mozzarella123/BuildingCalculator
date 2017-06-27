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
    public partial class MultiSliders : UserControl
    {
        //Нужен для того, чтобы скрыть предыдущий слайдер
        public int PrevSlider = 0;
        /// <summary>
        /// Списки элементов комнаты разбитые по категориям
        /// </summary>
        public Dictionary<WorkTypeClass.Category, List<List<Element>>> Elements = new Dictionary<WorkTypeClass.Category, List<List<Element>>>();
        /// <summary>
        /// Название категорий
        /// </summary>
        public Dictionary<WorkTypeClass.Category,List<string>> Categories = new Dictionary<WorkTypeClass.Category, List<string>>();
        public MultiSliders()
        {
            InitializeComponent();       
            Sliders.Controls.Clear();
            Categories.Add(WorkTypeClass.Category.walls,new List<string>() { "Окна", "Двери" });
            Categories.Add(WorkTypeClass.Category.floorPer, new List<string>() { "Двери" });
            Functions.SetToolTip("Выберите элементы", ElementsNames);
            foreach (var pair in Categories)
            {
                foreach (string name in pair.Value)
                {
                    //Формируем выпадающее меню
                    if (!ElementsNames.Items.Contains(name))
                    {
                        ElementsNames.Items.Add(name);
                        Slider curslider = new Slider();
                        //Добавляем категорию к которой принадлижит слайдер
                        curslider.Categories.Add(pair.Key);
                        curslider.Visible = false;
                        curslider.Dock = DockStyle.Fill;
                        //Имя категории в Name
                        curslider.Name = name;
                        Sliders.Controls.Add(curslider);
                    }
                    else

                        (Sliders.Controls[name] as Slider).Categories.Add(pair.Key);
                }
            }
            //Формируем список элементов по категориям
            foreach (Slider slider in Sliders.Controls)
            {
                foreach (WorkTypeClass.Category cat in slider.Categories)
                    if (Elements.ContainsKey(cat))
                        Elements[cat].Add(slider.Slides);
                    else Elements.Add(cat, new List<List<Element>>() { slider.Slides });
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
