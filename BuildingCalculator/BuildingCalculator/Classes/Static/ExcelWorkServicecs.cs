using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using System.IO;

using System.Windows.Forms;

namespace BuildingCalculator.Classes.Static
{
    public static class ExcelWorkServicecs
    {
        static IExcelDataReader excelReader;
        static List<string[]> ar=new List<string[]>();
        static List<int> counts = new List<int>();
        public static void OpenFile(string path)
        {
            FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Read);
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            while (excelReader.Read())
            {
                string[] record = new string[excelReader.FieldCount];
                int count = 0;
                for(int i = 0; i < record.Length; i++)
                {
                    record[i] = excelReader.GetString(i);
                    if (record[i] != null)
                        count++;
                }
                ar.Add(record);
                counts.Add(count);
            }
            ReadWorkTypes();
        }
        static void ReadWorkTypes()
        {
            string CatName = "";
            for(int i = 0; i < ar.Count; i++)
            {
                if (counts[i] == 1)
                    CatName = ar[i][0];
                else
                {
                    WorkTypeClass work = new WorkTypeClass();
                    work.Article = ar[i][0];
                    if (ar[i][1] != null)
                        work.parametrs = ar[i][1].Split(',').ToList();
                    work.setPriceFunc(ar[i][2]);
                    work.setCategory(CatName);
                    if (DelegateAssemblyService.isCreatedCorrect(work)&&!JSONSerializeService.Contains(work))
                        JSONSerializeService.AddToOutput(work);
                }
            }
            JSONSerializeService.Save();
        }
    }
}
