﻿using System;
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
        public Dictionary<ParamName, double> Params { get; set; }
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
                return (Params[ParamName.Height] + Params[ParamName.Width]) * 2;
            }
        }
    }
    public class Room : Entity
    {
        /// <summary>
        /// Списки элементов разбитые по категориям
        /// </summary>
        public Dictionary<WorkTypeClass.Category, List<List<Element>>> Elements { get; set; }
        public Room() : base()
        {
            Elements = new Dictionary<WorkTypeClass.Category, List<List<Element>>>();
        }
        /// <summary>
        /// Имя комнаты
        /// </summary>
        public string Name;
        /// <summary>
        /// Получить площадь по указанной части комнаты
        /// </summary>
        /// <param name="cat">Категория</param>
        /// <returns>Площадь в double</returns>
        public double GetAreaFromCat(WorkTypeClass.Category cat)
        {
            switch (cat)
            {
                case WorkTypeClass.Category.walls:
                    return CommonArea;
                case WorkTypeClass.Category.floorPer:
                    return BottomPerimeter;
                case WorkTypeClass.Category.ceiling:
                case WorkTypeClass.Category.floor:
                    return Area;
                case WorkTypeClass.Category.ceilingPer:
                    return Perimeter;
            }
            return 0;
        }
        /// <summary>
        /// Общая площадь стен
        /// </summary>
        public double CommonArea
        {
            get
            {
                double sum = 0;
                foreach (var pair in Elements)
                    if (pair.Key == WorkTypeClass.Category.walls)
                        foreach (var listofelements in pair.Value)
                            foreach (Element elem in listofelements)
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
                foreach (var pair in Elements)
                    if (pair.Key == WorkTypeClass.Category.floorPer)
                        foreach (var listofelements in pair.Value)
                            foreach (Element elem in listofelements)
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
        public Element() : base()
        {
        }
    }
}
