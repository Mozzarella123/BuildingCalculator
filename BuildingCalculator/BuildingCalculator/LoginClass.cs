using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace BuildingCalculator
{
    public static class LoginClass
    {
        
        public static Form SignIn()
        {
            
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("login"))
            {
                // открываем текущий конфиг специальным обьектом
                System.Configuration.Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // добавляем позицию в раздел AppSettings
                currentConfig.AppSettings.Settings.Add("login", "slon");
                if (!ConfigurationManager.AppSettings.AllKeys.Contains("password"))
                    currentConfig.AppSettings.Settings.Add("password", "12345");
                //сохраняем
                currentConfig.Save(ConfigurationSaveMode.Modified);
                //принудительно перезагружаем соотвествующую секцию
                ConfigurationManager.RefreshSection("appSettings");

            }

            login = ConfigurationManager.AppSettings["login"];
            pass = ConfigurationManager.AppSettings["password"];

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
