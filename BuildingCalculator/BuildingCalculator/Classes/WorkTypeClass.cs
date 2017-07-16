using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCalculator.Classes;
using System.Text.RegularExpressions;

namespace BuildingCalculator
{

    public class WorkTypeClass : ICloneable
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
        public enum Category
        {
            none = -1,
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
            other
        };
        public double[] ParametersValue { get; set; }
        public WorkTypeClass()
        {
            parametrs = new List<string>();
            ParametersValue = new double[parametrs.Count];            

        }
        public WorkTypeClass(double price)
        {
            parametrs = new List<string>();
            IsFixedPrice = true;
            fixedPrice = price;
        }
        public void setPriceFunc(string f)
        {
            if (double.TryParse(f, out fixedPrice))
                IsFixedPrice = true;
            else
            {
                Formula = f;
                IsFixedPrice = false;
            }

        }
        public double GetPrice()
        {
            if (IsFixedPrice)
                return fixedPrice;
            double result = DelegateAssemblyService.getPriceforWorkType(this, ParametersValue);
            return result;
        }
        public string Price { get { try { return GetPrice().ToString(); } catch { return "0"; } } }
        public bool IsFixedPrice { get; set; }
        public double fixedPrice;
        public string Article { get ; set; }
        public string Formula { get; set; }
        public string Quantity
        {
            get; set;
        }
        public List<string> parametrs;
        public int id;
        public override string ToString()
        {
            return Article + " " + Formula;
        }
        public string delegateName;
        public Category category;
        public string getQuantity()
        {
            string quantity = "";
            //значения параметров
            for (int k = 0; k < parametrs.Count; k++)
                quantity += ParametersValue[k] + " " + parametrs[k] + "\n";
            return quantity;

        }
        public void setCategory(string catName)
        {
            foreach (KeyValuePair<Category, string> rec in CategoryNames)
                if (catName.ToLower() == rec.Value.ToLower())
                {
                    category = rec.Key;
                    return;
                }
            category = Category.other;
        }
        public bool Equals(WorkTypeClass work)
        {
            bool ret = Article.Equals(work.Article);
            ret &= category.Equals(work.category);
            return ret;
        }
        public bool FullEquals(WorkTypeClass work)
        {
            bool ret = Article == null && work.Article == null ? true:Article.Equals(work.Article);
            ret &= ParametersValue==null&&work.ParametersValue==null ? true: ParametersValue.Length == work.ParametersValue.Length;
            ret &= Formula == null&&work.Formula==null ? true : Formula.Equals(work.Formula);
            ret &= category.Equals(work.category);
            ret &= (parametrs == null && work.parametrs == null) ? true : parametrs.Count == work.parametrs.Count;
            return ret;
        }
        static bool Equals(List<string> s1, List<string> s2)
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
            copywork.Article = Article;
            copywork.category = category;
            copywork.delegateName = delegateName;
            copywork.Formula = Formula;
            copywork.id = id;
            copywork.IsFixedPrice = IsFixedPrice;
            copywork.Quantity = Quantity;            
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
