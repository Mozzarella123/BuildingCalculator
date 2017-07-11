using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingCalculator.FormComponents;

namespace BuildingCalculator.Classes.Static
{
    public static class TipsService
    {
        public class Tip
        {
            public Control _Object;
            public string _Text;
            public Tip(Control obj,string text)
            {
                
                _Object = obj;
                _Text = text;
                tf = new TipForm(this);
                _Object.MouseEnter += Show;
                _Object.MouseLeave += Hide;
                
            }
            TipForm tf ;
            public void Show(object sender,EventArgs e)
            {
                tf.Show();
                
            }
            public void Hide(object sender,EventArgs e)
            {
                //tf.Hide();
            }
        }
        static List<Tip> _Tips = new List<Tip>();
        static bool tutorial = bool.Parse(ConfigWorksService.getValue("tutorial"));
        public static void AddTip(Control control,string text)
        {
            if (tutorial)
                _Tips.Add(new Tip(control, text));
        }
    }
     
}
