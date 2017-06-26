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
            Functions.Input(Height, Room, SetMethod, Functions.ValidateType.OnlyNumbers);
            Room.Elements = (Controls["multiSliders1"] as MultiSliders).Elements;
            Functions.SetToolTip("Введите значение параметра", Width);
            Functions.SetToolTip("Введите значение параметра", Length);
            Functions.SetToolTip("Введите значение параметра", Height);

        }
        public Room Room = new Room();
        private void SetMethod(object obj,Control control)
        {
            try
            {
                Entity obj1 = obj as Entity;
                Entity.ParamName param = Entity.ParamName.Width;//костыль
                switch (control.Name)
                {
                    case "Width":param = Entity.ParamName.Width;break;
                    case "Length": param = Entity.ParamName.Length; break;
                    case "Height": param = Entity.ParamName.Height; break;

                }
                obj1.Params[param] = Convert.ToDouble(Convert.ToDouble(control.Text));

            }
            catch (FormatException)
            {

            }
        }
        private void TabContent_Load(object sender, EventArgs e)
        {

        }

        private void Length_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
