﻿using System;
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
            //if (!ConfigWorksService.Contains("login"))//проверка стартовых параметров
            //    ConfigWorksService.Add("login", "slon");
            //if (!ConfigWorksService.Contains("password"))
            //    ConfigWorksService.Add("password","12345");
            //if (!ConfigWorksService.Contains("Remembered"))
            //    ConfigWorksService.Add("Remembered", "False");

            login = ConfigWorksService.getValue(ConfigWorksService.Options.Login);//считываем логин, пароль
            pass = ConfigWorksService.getValue(ConfigWorksService.Options.Password);
            return lf;//возврат формы логина
            
        }
        public static LogInForm lf=new LogInForm();
        public static AdminForm af=new AdminForm();
        public static bool IsLoged;
        public static string login;
        public static string pass;

    }
}
