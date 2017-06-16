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
        public virtual double Area
        {
            get { return Params["Length"] * Params["Width"]; }
        }
    }
    public class Room:Entity
    {              
        public List<Element> Elements { get; set; } 
        public Room():base()
        {
            Elements = new List<Element>();
        }

    }
    public class Element:Entity
    {
        public Element():base()
        {
        }
    }
}
