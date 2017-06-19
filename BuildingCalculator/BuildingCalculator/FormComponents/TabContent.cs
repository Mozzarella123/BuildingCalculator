using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.Classes;

namespace BuildingCalculator
{
    public partial class TabContent : UserControl
    {
        public TabContent()
        {
            InitializeComponent();
            Functions.Validate(Functions.ValidateType.OnlyNumbers, Width);
            Functions.Validate(Functions.ValidateType.OnlyNumbers, Length);
            Room.Elements = (Controls["multiSliders1"] as MultiSliders).Elements;
        }
        public Room Room = new Room();
        public static void Input(TextBox input, Entity obj)
        {
            try
            {
                double value = Convert.ToDouble(input.Text);
                switch (input.Name)
                {
                    case "Width":
                        obj.Params["Width"] = value;
                        break;
                    case "Length":
                        obj.Params["Length"] = value;
                        break;
                }
            }
            catch (FormatException)
            {

            }
        }
        private void Input_Room(object sender, EventArgs e)
        {
            Input(sender as TextBox, Room);
        }
        private void TabContent_Load(object sender, EventArgs e)
        {

        }
    }
}
