using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BuildingCalculator
{
    public static class JSONSerializeService
    {
        public static string InputJsonString = "";
        public static string OutputJsonString = "";
        public static string InputFilePath = "";
        public static string OutputFilePath;
        public static bool isHaveInput;
        public static void ReadInput(string path)
        {
            InputFilePath = path;
            if (File.Exists(InputFilePath))
            {
                InputJsonString = File.ReadAllText(InputFilePath);
                isHaveInput = true;
                InputItems = JsonConvert.DeserializeObject<List<object>>(InputJsonString);
            }
            else
            {
                File.Create(InputFilePath);
                InputJsonString = "";
                isHaveInput = true;
            }
            OutputFilePath = InputFilePath;
        }
        public static List<object> InputItems;
        public static List<object> OutputItems = new List<object>();
        public static void AddToOutput(object item)
        {
            OutputItems.Add(item);
        }
        public static void WriteOutput()
        {
            if (OutputItems.Count != 0)
                File.WriteAllText(OutputFilePath, JsonConvert.SerializeObject(OutputItems));
        }
        
    }
}
