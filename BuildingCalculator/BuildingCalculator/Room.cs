using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    class Params
    {
    }
    interface IParams
    {
        Dictionary<string, double> Params { get; set; }
    }
    public class Room: IParams
    {
        public Dictionary<string,double> Params { get; set; }
        public Room()
        {
        }
        public static void AddParam(string key)
        {
            
        }
    }
    public class Element: IParams
    {
        public Dictionary<string, double> Params { get; set; }

    }
}
