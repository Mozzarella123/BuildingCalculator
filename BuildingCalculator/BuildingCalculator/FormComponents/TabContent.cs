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
            Functions.Input(Width, Room, SetMethod,Functions.ValidateType.OnlyNumbers);
            Functions.Input(Length, Room, SetMethod, Functions.ValidateType.OnlyNumbers);
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
        private void SetMethod(object obj,Control control)
        {
            try
            {
                Entity obj1 = obj as Entity;
                obj1.Params[control.Name] = Convert.ToDouble(Convert.ToDouble(control.Text));

            }
            catch (FormatException)
            {

            }
        }
        private void Input_Room(object sender, EventArgs e)
        {
            Functions.Input(sender as TextBox, Room, SetMethod);
            Input(sender as TextBox, Room);
        }
        private void TabContent_Load(object sender, EventArgs e)
        {

        }
    }
}
