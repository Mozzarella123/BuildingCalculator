using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    public class Entity
    {
        /// <summary>
        /// Измерение элемента
        /// </summary>
        public enum ParamName
        {
            Length,
            Width,
            Height
        }
        public Dictionary<ParamName, double> Params { get; private set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }
        public Entity()
        {
            Params = new Dictionary<ParamName, double>()
            {
                {ParamName.Length,0 },
                {ParamName.Width,0 },
                {ParamName.Height,0 }
            };

        }
        /// <summary>
        /// Площадь
        /// </summary>
        public virtual double Area
        {
            get
            {
                return Params[ParamName.Height] * Params[ParamName.Width];
            }
            set { Area = value; }
        }
        /// <summary>
        /// Периметр
        /// </summary>
        public virtual double Perimeter
        {
            get
            {
                return (Params[ParamName.Length] + Params[ParamName.Width]) * 2;
            }
            set { Perimeter = value; }
        }
    }
    public class Room : Entity
    {
        /// <summary>
        /// Списки элементов разбитые по категориям
        /// </summary>
        public List<List<Element>> Elements { get; set; }
        public List<WorkTypeClass.Category> CheckedCats { get; set; }
        public List<WorkTypeClass> CheckedWorks { get; set; }
        public bool Standard { get; set; }
        public Room() : base()
        {
            Elements = new List<List<Element>>();
            CheckedCats = new List<WorkTypeClass.Category>();
            CheckedWorks = new List<WorkTypeClass>();
            Standard = true;
        }
        /// <summary>
        /// Получить площадь по указанной части комнаты
        /// </summary>
        /// <param name="cat">Категория</param>
        /// <returns>Площадь в double</returns>
        public double GetAreaFromCat(WorkTypeClass.Category cat)
        {
            double unit = 1;
            if (ConfigWorksService.getValue(ConfigWorksService.Options.Units) == "sm")
                unit = 0.01;
            switch (cat)
            {
                case WorkTypeClass.Category.walls:
                    return CommonArea * unit;
                case WorkTypeClass.Category.floorPer:
                    return BottomPerimeter * unit;
                case WorkTypeClass.Category.ceiling:
                case WorkTypeClass.Category.floor:
                    return Area * unit;
                case WorkTypeClass.Category.ceilingPer:
                    {
                        if (Standard)
                            return Perimeter * unit;
                        return BottomPerimeter * unit;
                    }
            }
            return -1;
        }       
        /// <summary>
        /// Общая площадь стен
        /// </summary>
        public double CommonArea
        {
            get
            {
                double sum = 0;
                foreach (var list in Elements)
                    foreach (var elem in list)
                        //вычитаем все элементы, которые относятся к стенам
                        if (elem.Categories.Find(x => x == WorkTypeClass.Category.walls) == WorkTypeClass.Category.walls)
                            sum += elem.Area;

                if (Standard)
                    return (base.Area + Params[ParamName.Height] * Params[ParamName.Length]) * 2 - sum;
                //если нестандартная комната
                return BottomPerimeter * Params[ParamName.Height] - sum;
            }
        }
        /// <summary>
        /// Площадь потолка и пола
        /// </summary>
        private double area;
        public override double Area
        {
            get
            {
                if (Standard)
                    return Params[ParamName.Width] * Params[ParamName.Length];
                return area;
            }
            set { if (!Standard) area = value; }
        }
        /// <summary>
        /// Периметр пола
        /// </summary>
        private double bottomperimeter;
        public double BottomPerimeter
        {
            get
            {

                double sum = 0;
                foreach (var list in Elements)
                    foreach (var elem in list)
                        //вычитаем все элементы, которые отностятся к периметру пола
                        if (elem.Categories.Find(x => x == WorkTypeClass.Category.floorPer) == WorkTypeClass.Category.floorPer)
                            sum += elem.Params[ParamName.Width];
                if (Standard)
                    return (Params[ParamName.Width] + Params[ParamName.Length]) * 2 - sum;
                return bottomperimeter - sum;
            }
            set { if (!Standard) bottomperimeter = value; }
        }
    }
    public class Element : Entity
    {
        /// <summary>
        /// Части комнаты к которым принадлежит элемент
        /// </summary>
        public List<WorkTypeClass.Category> Categories { get; set; }
        /// <summary>
        /// Элемент с двумя заданными параметрами и категориями, к которым он относится
        /// </summary>
        /// <param name="param1">Параметр 1</param>
        /// <param name="valueparam1">Значения параметра 1</param>
        /// <param name="param2">Параметр 2</param>
        /// <param name="valueparam2">Значение параметра 2</param>
        /// <param name="Title">Название</param>
        /// <param name="cats">Категории</param>
        public Element(ParamName param1, double valueparam1, ParamName param2, double valueparam2, string Title = null, List<WorkTypeClass.Category> cats = null)
        {
            Element element = new Element();
            element.Params[param1] = valueparam1;
            element.Params[param2] = valueparam2;
            if (Title != null)
                element.Title = Title;
            if (cats != null)
                foreach (WorkTypeClass.Category cat in cats)
                    element.Categories.Add(cat);           
        }
        public Element() : base()
        {
            Categories = new List<WorkTypeClass.Category>();
        }
    }
}
