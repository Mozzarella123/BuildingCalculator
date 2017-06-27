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
        public void setCategory(string catName)
        {
            foreach(KeyValuePair<Category,string> rec in CategoryNames)
                if (catName.ToLower() == rec.Value.ToLower())
                {
                    category = rec.Key;
                    return;
                }
            category = Category.other;
        }
        public bool Equals(WorkTypeClass work)
        {
            bool ret = article.Equals(work.article);
            ret &= Equals(parametrs,work.parametrs);
            ret &= formula.Equals(work.formula);
            ret &= category.Equals(work.category);
            return ret;
        }
        static bool Equals(List<string> s1,List<string> s2)
        {
            if (s1 == null && s2 == null)
                return true;
            if (s1.Count != s2.Count)
                return false;
            else
            {
                for (int i = 0; i < s1.Count; i++)
                    if (s1[i] != s2[i])
                        return false;
                return true;
            }
        }
    }
}
