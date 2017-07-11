using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace BuildingCalculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainForm = new FormComponents.NewForm();
                Application.Run(mainForm);
            }
            catch (Exception e)
            {
                //logger.Fatal("\n Метод, вызвавший исключение:" + e.TargetSite + "\n Объект, вызвавший исключение:" + e.InnerException + "\n Сообщение:" + e.Message);
                MessageBox.Show("Произошла непредвиденная ошибка");
                Application.Restart();
            }
        }
        public static FormComponents.NewForm mainForm;
    }
}
