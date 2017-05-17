using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCalculator
{
    public class Room
    {
        public class Element
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public Element()
            {

            }
            public Element(double length,double width)
            {
                Length = length;
                Width = width;
            }
        }
    }
}
