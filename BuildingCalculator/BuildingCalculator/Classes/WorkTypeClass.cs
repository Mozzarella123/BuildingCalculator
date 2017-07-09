using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCalculator.Classes;
using System.Text.RegularExpressions;

namespace BuildingCalculator
{
    public class WorkTypeClass:ICloneable
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
                {Category.windowsanddoors,"Окна,двери" },
                {Category.ventilation,"Вентиляция" },
                {Category.corners,"Углы наружние и внутрение" },
                {Category.boring,"Сверление,резка,крепеж" },
                {Category.curtain,"Гардины,карнизы,вешалки,тумбы" },
                {Category.other, "Другое" },
            };    
        public enum Category {
            none =-1,
            walls,
            floor,
            ceiling,
            floorPer,
            ceilingPer,
            elworks,
            santechworks,
            windowsanddoors,
            ventilation,
            corners,
            boring,
            curtain,
            other };
        public double[] ParametersValue { get; set; }
        public WorkTypeClass()
        {
            parametrs = new List<string>();
            ParametersValue = new double[parametrs.Count];
            isFixedPrice = false;
            
        }
        public WorkTypeClass(double price)
        {
            parametrs = new List<string>();
            isFixedPrice = true;
            fixedPrice = price;
        }
        public void setPriceFunc(string f)
        {
            if (double.TryParse(f, out fixedPrice))
                isFixedPrice = true;
            else
            {
                formula = f;
                isFixedPrice = false;
            }

        }
        public double GetPrice()
        {
            if (isFixedPrice)
                return fixedPrice;
            double result = DelegateAssemblyService.getPriceforWorkType(this, ParametersValue);
            return result;
        }
        public string Price { get { return GetPrice().ToString(); } }
        public bool isFixedPrice { get; private set; }
        public double fixedPrice;
        public string article { get; set; }
        public string formula { get; set; }
        public string quantity { get; set; }
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
        public bool FullEquals(WorkTypeClass work)
        {
            bool ret = article.Equals(work.article);
            ret &= Equals(ParametersValue, work.ParametersValue);
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
        public object Clone()
        {
            WorkTypeClass copywork = new WorkTypeClass();
            copywork.article = article;
            copywork.category = category;
            copywork.delegateName = delegateName;
            copywork.formula = formula;
            double[] copyparams = new double[ParametersValue.Length];
            ParametersValue.CopyTo(copyparams, 0);
            copywork.ParametersValue = copyparams;
            List<string> copyparamss = new List<string>();
            foreach (string s in parametrs)
                copyparamss.Add(s);
            copywork.parametrs = copyparamss;
            return copywork;
        }
    }
}
