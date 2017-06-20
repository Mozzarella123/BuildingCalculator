﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BuildingCalculator.Classes
{
    public static class Functions
    {
        public delegate void SetMethod(object obj,Control control);
        public enum ValidateType { Default,OnlyText,OnlyNumbers, UserValidate }
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
        public static void SetValidator(Control control,ValidateType type, KeyPressEventHandler userfunc = null)
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
        public static void Input(Control control, object obj, string property, ValidateType validatetype=ValidateType.Default, KeyPressEventHandler userfunc = null)
        {
            SetValidator(control, validatetype);
            control.TextChanged += Input_TextChanged;
            object[] param = { obj,property };
            control.Tag = param;
        }
        public static void Input(Control control, object obj,SetMethod set, ValidateType validatetype= ValidateType.Default, KeyPressEventHandler userfunc = null)
        {
            SetValidator(control, validatetype);
            object[] param = { obj, set };
            control.Tag = param;
            control.TextChanged += Input_TextChanged;
        }
        private static void Input_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            object[] obj = (control.Tag as object[]);
            if (obj[1] is string)
            {
                string property = obj[1] as string;
                obj[0] = Convert.ChangeType(obj[0], obj[0].GetType());
                PropertyInfo prop = obj[0].GetType().GetProperty(property);
                prop.SetValue(obj[0], Convert.ChangeType(control.Text, prop.GetType()));
            }
            else
            {
                SetMethod set = obj[1] as SetMethod;
                set.Invoke(obj[0], control);
            }

        }

    }
}
