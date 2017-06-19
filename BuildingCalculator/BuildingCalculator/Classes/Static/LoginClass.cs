using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuildingCalculator
{
    public static class LoginClass
    {
        /// <summary>
        /// метод входа
        /// </summary>
        /// <returns></returns>
        public static Form SignIn()
        {
            if (!ConfigWorksService.Contains("login"))//проверка стартовых параметров
                ConfigWorksService.Add("login", "slon");
            if (!ConfigWorksService.Contains("password"))
                ConfigWorksService.Add("password","12345");
            if (!ConfigWorksService.Contains("Remembered"))
                ConfigWorksService.Add("Remembered", "false");

            login = ConfigWorksService.getValue("login");//считываем логин, пароль
            pass = ConfigWorksService.getValue("password");

            if (lf == null) lf = new LogInForm();//инициализируем формы
            if (af == null) af = new AdminForm();

            if (ConfigWorksService.getValue("Remembered") == "true")//проверяем, нужно ли логинится
                return af;

            if (IsLoged)
            {
                
                return af;
                //вход в админку
            }
            else
            {
                return lf;//возврат формы логина
            }
            
        }
        public static LogInForm lf;
        public static AdminForm af;
        public static bool IsLoged;
        public static string login;
        public static string pass;

    }
}
