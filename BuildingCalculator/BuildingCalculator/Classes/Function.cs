using System;
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
            menu.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

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
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
            else
            {
                if ((sender as Control).Text == "0")
                    (sender as Control).Text = "";
                if (e.KeyChar == ',' && (sender as Control).Text.Contains(','))
                    e.Handled = true;
            }
        }
        private static void ValidText(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
        /// <summary>
        /// Функция для связи control'а и параметра, куда будет заносится значение
        /// </summary>
        /// <param name="control">Control для связи</param>
        /// <param name="obj">Объект, к которому хотим привязать</param>
        /// <param name="property">Название свойства</param>
        /// <param name="validatetype">Тип валидации</param>
        /// <param name="userfunc">Собственный обработчик set</param>
        public static void Input(Control control, object obj, string property, ValidateType validatetype=ValidateType.Default, KeyPressEventHandler userfunc = null)
        {
            //Привязываем валидацию
            SetValidator(control, validatetype);
            //Добавляем обработчик
            control.TextChanged += Input_TextChanged;
            //Создаем параметры для передачи в обработчик
            object[] param = { obj,property };
            control.Tag = param;
        }
        /// <summary>
        /// Функция для связи control'а и параметра, куда будет заносится значение
        /// </summary>
        /// <param name="control">Control для связи</param>
        /// <param name="obj">Объект, к которому хотим привязать</param>
        /// <param name="set">Метод задания свойству значения</param>
        /// <param name="validatetype">Тип валидации</param>
        /// <param name="userfunc">Собственный обработчик set</param>
        public static void Input(Control control, object obj,SetMethod set, ValidateType validatetype= ValidateType.Default, KeyPressEventHandler userfunc = null)
        {
            //Привязываем валидацию
            SetValidator(control, validatetype);
            //Создаем параметры для передачи в обработчик с пользовательским метом
            object[] param = { obj, set };
            control.Tag = param;
            control.TextChanged += Input_TextChanged;
        }
        private static void Input_TextChanged(object sender, EventArgs e)
        {     
            Control control = sender as Control;
            //получаем параметры
            object[] obj = (control.Tag as object[]);
            //если свойство простое
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
                //Вызываем пользовательский метод set
                set.Invoke(obj[0], control);
            }

        }
        public static void SetEntityParams(object obj, Control control)
        {
            try
            {
                Entity obj1 = obj as Entity;
                Entity.ParamName param = Entity.ParamName.Width;//костыль
                switch (control.Name)
                {
                    case "Width": param = Entity.ParamName.Width; break;
                    case "Length": param = Entity.ParamName.Length; break;
                    case "Height": param = Entity.ParamName.Height; break;
                }
                obj1.Params[param] = Convert.ToDouble(Convert.ToDouble(control.Text));

            }
            catch (FormatException)
            {

            }
        }
        public static void SetToolTip(string text,Control control)
        {
            ToolTip hint = new ToolTip();
            hint.AutoPopDelay = 3000;
            hint.SetToolTip(control,text);
        }
        

    }
}
