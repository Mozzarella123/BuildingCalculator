using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace BuildingCalculator
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            
            
            InitializeComponent();
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
            if (_isLoged)
                MessageBox.Show("Ты вошел, а еще ты пидор");
        }
        static bool _isLoged;
        string login;
        string pass;
        private void LogInForm_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == login && textBox2.Text == pass)
            {
                MessageBox.Show("Ты вошел, а еще ты пидор");
                _isLoged = true;
            }
        }
    }
}
