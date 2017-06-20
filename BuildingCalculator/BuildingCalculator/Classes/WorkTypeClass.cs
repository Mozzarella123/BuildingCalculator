using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    public class WorkTypeClass
    {
        public enum Category { none=-1,walls=0, floor, ceiling, other};
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
        public string delegateName;
        public Category category;
    }
}
