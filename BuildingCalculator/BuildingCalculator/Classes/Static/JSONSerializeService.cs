using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

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
        public static void ReadInput(string path)
        {
            InputFilePath = OutputFilePath = path;
            if (File.Exists(InputFilePath)||File.Exists("lastCompleteBuild.json"))
            {
                InputJsonString = File.ReadAllText(InputFilePath);
                isHaveInput = true;
                InputItems = OutputItems = JsonConvert.DeserializeObject<List<WorkTypeClass>>(InputJsonString);
                if (InputItems == null && OutputItems == null)
                {
                    InputItems = new List<WorkTypeClass>();
                    OutputItems = new List<WorkTypeClass>();
                }
                DelegateAssemblyService.WriteCompileStringToFile();
                try
                {
                    DelegateAssemblyService.AssemblyDelegate();
                    if (isLoadingCorrect)
                        File.Copy("works.json", "lastCompleteBuild.json", true);
                }
                catch
                {
                    if (File.Exists("lastCompleteBuild.json"))
                    {
                        isLoadingCorrect = false;
                        ReadInput("lastCompleteBuild.json");
                        MessageBox.Show("Cборка не была загружена из-за ошибки, поэтому была загружена последняя рабочая версия.");
                        return;
                    }
                    
                }
                
                
            }
            else
            {
                File.Create(InputFilePath);
                InputJsonString = "";
                isHaveInput = true;
                OutputItems = new List<WorkTypeClass>();
            }
            
        }
        public static List<WorkTypeClass> InputItems;
        public static List<WorkTypeClass> OutputItems = new List<WorkTypeClass>();
        public static void AddToOutput(WorkTypeClass item)
        {
            OutputItems.Add(item);
        }
        public static void WriteOutput()
        {
            if (OutputItems!=null)
                File.WriteAllText(OutputFilePath, JsonConvert.SerializeObject(OutputItems));
        }
        public static void Save()
        {
            WriteOutput();
            ReadInput(OutputFilePath);
            LoginClass.af.RefreshList();
        }
        
    }
}
