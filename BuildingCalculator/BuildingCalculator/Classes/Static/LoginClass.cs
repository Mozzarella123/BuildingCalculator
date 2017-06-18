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
        
        public static Form SignIn()
        {
            if (!ConfigWorksService.Contains("login"))
                ConfigWorksService.Add("login", "slon");
            if (!ConfigWorksService.Contains("password"))
                ConfigWorksService.Add("password","12345");

            login = ConfigWorksService.getValue("login");
            pass = ConfigWorksService.getValue("password");

            if (lf == null) lf = new LogInForm();
            if (af == null) af = new AdminForm();

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
