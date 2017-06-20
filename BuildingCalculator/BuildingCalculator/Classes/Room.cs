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
            AddParam("Height");
            AddParam("Width");
        }
        public virtual double Area
        {
            get
            {
                return Params["Height"] * Params["Width"];
            }
        }
        public virtual double Perimeter
        {
            get
            {
                return (Params["Height"] + Params["Width"]) * 2;
            }
        }
    }
    public class Room:Entity
    {              
        public Dictionary<string, List<Element>> Elements { get; set; } 
        public Room():base()
        {
            Elements = new Dictionary<string, List<Element>>();
            AddParam("Length");
        }
        public double CommonArea
        {
            get
            {
                double sum = 0;
                foreach (var pair in Elements)
                    foreach (Element elem in pair.Value)
                        sum += elem.Area;
                return (base.Area + Params["Height"] * Params["Height"]) * 2-sum;
            }
        }
        public override double Area
        {
            get
            {
                return Params["Width"] * Params["Length"];
            }
        }
        public double BottomPerimeter
        {
            get
            {
                double sum = 0;              
                    foreach (Element elem in Elements["Двери"])
                        sum += elem.Params["Width"];
                return (Params["Width"] + Params["Length"]) * 2 - sum;
            }
        }
    }
    public class Element:Entity
    {
        public Element():base()
        {
        }
    }
}
