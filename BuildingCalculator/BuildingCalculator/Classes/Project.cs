using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCalculator.FormComponents;

namespace BuildingCalculator
{
    public class Project
    {
        public List<Room> Rooms;
        public bool compatibility;
        public static Project getProjectForSave()
        {
            Project ret = new Project();
            //ret.Rooms = Form1.Rooms;
            return ret;
        }
    }
}
