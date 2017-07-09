using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Xml;

namespace BuildingCalculator
{
    public static class ConfigWorksService
    {
        public static System.Configuration.Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public enum Options { Login,Password,Remebered,Hints,Units,ReportDirectory,ReportRooms }
        static Dictionary<Options, string> OptionKeys = new Dictionary<Options, string>()
        {
            {Options.Login, "login" },
            {Options.Password, "password" },
            {Options.Remebered, "Remembered" },
            {Options.Hints, "tutorial" },
            {Options.Units, "units" },
            {Options.ReportDirectory, "endDir" },
            {Options.ReportRooms, "reportrooms" }
        };
        /// <summary>
        /// Проверяет все ли настройки на месте
        /// </summary>
        public static void CheckSettings()
        {
            foreach (var opt in OptionKeys)
                if (!Contains(opt.Value))
                    switch(opt.Key)
                    {
                        case Options.Login:Add(opt.Value, "slon");break;
                        case Options.Password: Add(opt.Value, "12345"); break;
                        case Options.Remebered: Add(opt.Value, "false"); break;
                        case Options.Hints: Add(opt.Value, "false"); break;
                        case Options.Units: Add(opt.Value, "m"); break;
                        case Options.ReportDirectory: Add(opt.Value, Directory.GetCurrentDirectory()); break;
                        case Options.ReportRooms: Add(opt.Value, "false"); break;

                    }
        }
        /// <summary>
        /// проверка наличия поля в конфигах
        /// </summary>
        /// <param name="sectionName">имя поля</param>
        /// <returns></returns>
        public static bool Contains(string sectionName)
        {
            return ConfigurationManager.AppSettings.AllKeys.Contains(sectionName);
        }
        /// <summary>
        /// добавление поля-значения в конфиг
        /// </summary>
        /// <param name="key">имя поля</param>
        /// <param name="value">значение поля</param>
        public static void Add(string key, string value)
        {           
            // добавляем позицию в раздел AppSettings
            currentConfig.AppSettings.Settings.Add(key, value);
            //сохраняем
            currentConfig.Save(ConfigurationSaveMode.Modified);
            //принудительно перезагружаем соотвествующую секцию
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static string getKey(Options key)
        {
            return OptionKeys[key];
        }
        public static string getValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        /// <summary>
        /// получение значения из указанного поля
        /// </summary>
        /// <param name="key">имя поля</param>
        /// <returns></returns>
        public static string getValue(Options key)
        {
            return ConfigurationManager.AppSettings[OptionKeys[key]];
        }
        /// <summary>
        /// Изменение значения в указанном поле
        /// </summary>
        /// <param name="key">Имя поля</param>
        /// <param name="newValue">Новое значение поля</param>
        public static void ChangeValue(string key,string newValue)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)//идем по xml-документу в поисках элемента конфигураций
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)//идем по конфигурациям в поисках нужного поля
                    {
                        if (node.Attributes[0].Value.Equals(key))//если имя поля соответствует искомому
                        {
                            
                            node.Attributes[1].Value = newValue;//заменяем значение
                            break;
                        }
                    }
                    break;
                }
            }
            
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);//сохраняем документ

            ConfigurationManager.RefreshSection("appSettings");//Перезагружаем конфигурации
        }
        /// <summary>
        /// Удаление указанного поля
        /// </summary>
        /// <param name="key">Имя поля</param>
        public static void Remove(string key)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)//идем по xml-документу в поисках элемента конфигураций
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)//идем по конфигурациям в поисках нужного поля
                    {
                        if (node.Attributes[0].Value.Equals(key))
                        {

                            element.RemoveChild(node);//удаляем поле
                            break;
                        }
                    }
                    break;
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);//сохраняем документ

            ConfigurationManager.RefreshSection("appSettings");//Перезагружаем конфигурации
        } 
    }
}
