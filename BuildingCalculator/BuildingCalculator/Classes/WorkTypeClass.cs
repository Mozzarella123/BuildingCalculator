using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCalculator.Classes;

namespace BuildingCalculator
{
    public class WorkTypeClass
    {
        public static Dictionary<Category, string> CategoryNames = new Dictionary<Category, string>()
            {
                {Category.walls, "Площадь стен" },
                {Category.floor, "Площадь пола" },
                {Category.ceiling, "Площадь потолка" },
                {Category.floorPer, "Периметр пола" },
                {Category.ceilingPer, "Периметр потолка" },
                {Category.other, "Другое" },
            };
        public enum Category { none=-1,walls, floor, ceiling, floorPer, ceilingPer, other};
        public WorkTypeClass()
        {
            parametrs = new List<string>();
            CategoryNames = new Dictionary< Category, string>()
            {
                {Category.walls, "Площадь стен" },
                {Category.floor, "Площадь пола" },
                {Category.ceiling, "Площадь потолка" },
                {Category.floorPer, "Периметр пола" },
                {Category.ceilingPer, "Периметр потолка" },
                {Category.other, "Другое" },
            }
            ;
        }
        public double GetPrice(double[] parameters)
        {
            return DelegateAssemblyService.getPriceforWorkType(this, parameters);
        }
        public string article;
        public string formula;
        public List<string> parametrs;
        public string description;
        public override string ToString()
        {
            return article + " " + formula;
        }
        public string delegateName;
        public Category category;
    }
}
