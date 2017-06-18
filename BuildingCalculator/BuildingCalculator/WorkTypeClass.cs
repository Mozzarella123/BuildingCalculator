using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    public class WorkTypeClass
    {
        public WorkTypeClass()
        {
            parametrs = new List<string>();
        }
        public string article;
        public string formula;
        public List<string> parametrs;
        public string description;
        public override string ToString()
        {
            return article + " " + formula;
        }
        //public delegate double getPrice(params double[] parametr);
        public getPrice price;
        public string delegateName;
    }
}
