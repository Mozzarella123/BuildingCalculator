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
        public static bool Contains(string sectionName)
        {
            return ConfigurationManager.AppSettings.AllKeys.Contains(sectionName);
        }
        public static void Add(string key, string value)
        {
            
            // добавляем позицию в раздел AppSettings
            currentConfig.AppSettings.Settings.Add(key, value);
            //сохраняем
            currentConfig.Save(ConfigurationSaveMode.Modified);
            //принудительно перезагружаем соотвествующую секцию
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static string getValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static void ChangeValue(string key,string newValue)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value.Equals(key))
                        {
                            
                            node.Attributes[1].Value = newValue;
                            break;
                        }
                    }
                    break;
                }
            }
            
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            ConfigurationManager.RefreshSection("appSettings");
        }
        
        public static void Remove(string key)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value.Equals(key))
                        {

                            element.RemoveChild(node);
                            break;
                        }
                    }
                    break;
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            ConfigurationManager.RefreshSection("appSettings");
        } 
    }
}
