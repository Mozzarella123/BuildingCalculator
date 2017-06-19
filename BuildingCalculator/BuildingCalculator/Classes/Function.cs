using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.Classes
{
    public static class Functions
    {
        public enum ValidateType { OnlyText,OnlyNumbers, UserValidate }
        /// <summary>
        /// Создает контекстное меню для любого элемента
        /// </summary>
        /// <param name="control">Control к которому нужно привязать меню</param>
        /// <param name="names">Названия элементов</param>
        /// <param name="funcs">Функции элементов</param>
        /// <returns>Возвращает созданное контекстное меню</returns>
        public static ContextMenuStrip ContextMenu(Control control,List<string> names,List<EventHandler> funcs)
        {           
            ContextMenuStrip menu = new ContextMenuStrip();
            for (int i=0;i<names.Count;i++)
            {
                menu.Items.Add(names[i]);
                menu.Items[i].Click += funcs[i];
            }
            control.ContextMenuStrip = menu;
            return menu;         
        }
        /// <summary>
        /// Создать валидатор для Control
        /// </summary>
        /// <param name="type">Тип валидации</param>
        /// <param name="control">Control, к которому привязать</param>
        /// <param name="userfunc">Собственный обработчик</param>
        public static void Validate(ValidateType type, Control control, KeyPressEventHandler userfunc = null)
        {
            switch (type)
            {
                case ValidateType.OnlyNumbers:
                    {
                        control.KeyPress += ValidNumbers;
                        break;
                    }
                case ValidateType.OnlyText:
                    {
                        control.KeyPress += ValidText;
                        break;
                    }
                case ValidateType.UserValidate:
                    {
                        if (userfunc != null)
                            control.KeyPress += userfunc;
                        break;
                    }                    
            }
        }
        private static void ValidNumbers (object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else
                if ((sender as Control).Text == "0")
                (sender as Control).Text = "";
        }
        private static void ValidText(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
