using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using BuildingCalculator;

namespace BuildingCalculator
{
    public static class JSONSerializeService
    {
        public static string InputJsonString = "";
        public static string OutputJsonString = "";
        public static string InputFilePath = "";
        public static string OutputFilePath;
        public static bool isHaveInput;
        static bool isLoadingCorrect=true;
        /// <summary>
        /// считываем входные данные
        /// </summary>
        /// <param name="path">имя файла с входными данными</param>
        public static void ReadInput(string path)
        {
            InputFilePath = OutputFilePath = path;
            if (File.Exists(InputFilePath))//если данные есть
            {
                try
                {
                InputJsonString = File.ReadAllText(InputFilePath);//чтение файла
                isHaveInput = true;
                InputItems = OutputItems = JsonConvert.DeserializeObject<List<WorkTypeClass>>(InputJsonString);//чтение входных данных
                if (InputItems == null && OutputItems == null)//если файл с входными данными пуст или не читается
                {
                    InputItems = new List<WorkTypeClass>();//инициализация обЪектов
                    OutputItems = new List<WorkTypeClass>();
                }
                DelegateAssemblyService.WriteCompileStringToFile();
                
                    DelegateAssemblyService.AssemblyDelegate();//сборка делегатов(проверка корректности входных данных)
                    if (isLoadingCorrect)
                        File.Copy("works.json", "lastCompleteBuild.json", true);//если начальные данные не поврежденны, то сохраняем их как последний рабочий билд
                }
                catch//если начальные данные повреждены
                {
                    if (File.Exists("lastCompleteBuild.json"))
                    {
                        isLoadingCorrect = false;
                        ReadInput("lastCompleteBuild.json");//загрузка последнего рабочего билда
                        MessageBox.Show("Cборка не была загружена из-за ошибки, поэтому была загружена последняя рабочая версия.");
                        return;
                    }
                    
                }
                
                
            }
            else//если их нет
            {
                
                File.Create(InputFilePath);//создаем пустой входной файл
                InputJsonString = "";
                isHaveInput = true;
                OutputItems = new List<WorkTypeClass>();
            }
            
        }
        public static List<WorkTypeClass> InputItems;
        public static List<WorkTypeClass> OutputItems = new List<WorkTypeClass>();
        /// <summary>
        /// добавляем элемент в выходные данные, что бы в будущем их сохранить
        /// </summary>
        /// <param name="item"> добавляемый объект</param>
        public static void AddToOutput(WorkTypeClass item)
        {
            OutputItems.Add(item);
        }
        /// <summary>
        /// записываем выходные данные в файл
        /// </summary>
        public static void WriteOutput()
        {
            if (OutputItems!=null)
                File.WriteAllText(OutputFilePath, JsonConvert.SerializeObject(OutputItems));
        }
        /// <summary>
        /// метод сохранения данных
        /// </summary>
        public static void Save()
        {
            WriteOutput();
            ReadInput(OutputFilePath);
            LoginClass.af.RefreshList();
        }
        public static bool Contains(WorkTypeClass work)
        {
            
            for(int i = 0; i < OutputItems.Count; i++)
            {
                if (OutputItems[i].Equals(work))
                    return true;
            }
            return false;
        }        
        public static WorkTypeClass GetWork(string name,WorkTypeClass.Category cat)
        {
            foreach (WorkTypeClass work in OutputItems)
                if (work.article == name&&work.category ==cat)
                    return work;
            return null;
        }

        public static bool getAlternate(WorkTypeClass work)
        {
            WorkTypeClass ret = work;
            foreach (WorkTypeClass w in JSONSerializeService.OutputItems)
            {
                if (work.Equals(w))
                {
                    ret = w;
                    return true;
                }

            }
            return false;
        }

        public static void SaveProject(Project pr,string Path)
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(pr));
        }
        public static Project LoadProject(string Path)
        {
            string text = File.ReadAllText(Path);
            Project ret = JsonConvert.DeserializeObject<Project>(text);
            foreach(Room r in ret.Rooms)
            {
                WorkTypeClass[] ar = r.CheckedWorks.ToArray();
                for(int i = 0; i < ar.Length; i++)
                {
                    if (!JSONSerializeService.getAlternate(ar[i]))
                    {
                        r.CheckedWorks.Remove(ar[i]);
                        ret.compatibility = false;
                    }

                }
                
            }
            ret.compatibility = true;
            return ret;
        }

    }
}
