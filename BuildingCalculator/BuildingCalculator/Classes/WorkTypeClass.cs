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
                {Category.elworks, "Электромонтажные работы" },
                {Category.santechworks, "Сантехнические работы" },
                {Category.other, "Другое" },
            };
        public enum Category { none=-1,walls, floor, ceiling, floorPer, ceilingPer,elworks,santechworks, other};
        double[] parametres = new double[0];
        public double[] Parameters
        {
            get
            {
                return parametres;            
            }
            set
            {
                parametres = value;
            }
        }
        public WorkTypeClass()
        {
            parametrs = new List<string>();
            
        }
        public double GetPrice()
        {
            return DelegateAssemblyService.getPriceforWorkType(this, parametres);
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
