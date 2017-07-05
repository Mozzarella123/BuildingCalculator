using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    public class IInterface
    {
        //То что считается у комнаты
        //приравнять в WorkTypeClass
        enum RoomPart
        {
            WallsArea = WorkTypeClass.Category.walls,
            CeilingArea = WorkTypeClass.Category.ceiling,
            FloorArea = WorkTypeClass.Category.floor,
            CeilingPerimeter = WorkTypeClass.Category.ceilingPer,
            FloorPerimeter = WorkTypeClass.Category.floorPer
        } 
    }
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
        }
    }
    public class Room : Entity
    {
        /// <summary>
        /// Списки элементов разбитые по категориям
        /// </summary>
        public List<Element> Elements { get; set; }
        public List<WorkTypeClass.Category> CheckedCats { get; set; }
        public List<WorkTypeClass> CheckedWorks { get; set; }

        public Room() : base()
        {
            Elements = new List<Element>();
            CheckedCats = new List<WorkTypeClass.Category>();
            CheckedWorks = new List<WorkTypeClass>();
        }
        /// <summary>
        /// Получить площадь по указанной части комнаты
        /// </summary>
        /// <param name="cat">Категория</param>
        /// <returns>Площадь в double</returns>
        public double GetAreaFromCat(WorkTypeClass.Category cat)
        {
            double unit = 1;
            switch (cat)
            {
                case WorkTypeClass.Category.walls:
                    return CommonArea*unit;
                case WorkTypeClass.Category.floorPer:
                    return BottomPerimeter * unit;
                case WorkTypeClass.Category.ceiling:
                case WorkTypeClass.Category.floor:
                    return Area * unit;
                case WorkTypeClass.Category.ceilingPer:
                    return Perimeter * unit;
            }
            return -1;
        }
        public string GetUnits(WorkTypeClass.Category cat)
        {
            switch (cat)
            {
                case WorkTypeClass.Category.walls:
                case WorkTypeClass.Category.floor:
                case WorkTypeClass.Category.ceiling:
                    return "м2";
                case WorkTypeClass.Category.floorPer:
                case WorkTypeClass.Category.ceilingPer:
                    return "м";
            }
            return "";
        }
        public void GetSumFromCat()
        {
            
        }
        /// <summary>
        /// Общая площадь стен
        /// </summary>
        public double CommonArea
        {
            get
            {
                double sum = 0;
                foreach (var elem in Elements)
                    if (elem.Categories.Find(x => x == WorkTypeClass.Category.walls)==WorkTypeClass.Category.walls)
                                sum += elem.Area;
                return (base.Area + Params[ParamName.Height] * Params[ParamName.Length]) * 2 - sum;
            }
        }
        /// <summary>
        /// Площадь потолка и пола
        /// </summary>
        public override double Area
        {
            get
            {
                return Params[ParamName.Width] * Params[ParamName.Length];
            }
        }
        /// <summary>
        /// Периметр пола
        /// </summary>
        public double BottomPerimeter
        {
            get
            {
                double sum = 0;
                foreach (var elem in Elements)
                    if (elem.Categories.Find(x => x == WorkTypeClass.Category.floorPer) == WorkTypeClass.Category.floorPer)
                                sum += elem.Params[ParamName.Width];
                return (Params[ParamName.Width] + Params[ParamName.Length]) * 2 - sum;
            }
        }
    }
    public class Element : Entity
    {
        /// <summary>
        /// Части комнаты к которым принадлежит элемент
        /// </summary>
        public List<WorkTypeClass.Category> Categories { get; set; }
        public static Element CreateElement(ParamName param1,double valueparam1,ParamName param2,double valueparam2,string Title =null,List<WorkTypeClass.Category> cats=null)
        {
            Element element = new Element();
            element.Params[param1] = valueparam1;
            element.Params[param2] = valueparam2;
            if (cats!=null)
                foreach (WorkTypeClass.Category cat in cats)
                    element.Categories.Add(cat);
            return element;
        }
        public Element() : base()
        {
            Categories = new List<WorkTypeClass.Category>();
        }
    }
}
