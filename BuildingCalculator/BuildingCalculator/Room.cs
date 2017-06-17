using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{

    public class Entity
    {
        public Dictionary<string, double> Params { get; set; }
        public void AddParam(string key)
        {
            Params.Add(key, 0);
        }
        public Entity()
        {
            Params = new Dictionary<string, double>();
            AddParam("Length");
            AddParam("Width");
        }
        public virtual double Area()
        {
             return Params["Length"] * Params["Width"];
        }
    }
    public class Room:Entity
    {              
        public Dictionary<string, List<Element>> Elements { get; set; } 
        public Room():base()
        {
            Elements = new Dictionary<string, List<Element>>();
        }
        public override double Area()
        {
            double sum = 0;
            //foreach (Element x in Elements)
            //    sum += x.Area();
            return base.Area()-sum;
        }
    }
    public class Element:Entity
    {
        public Element():base()
        {
        }
    }
}
