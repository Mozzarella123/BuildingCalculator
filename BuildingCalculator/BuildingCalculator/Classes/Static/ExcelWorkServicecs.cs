using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace BuildingCalculator.Classes.Static
{
    public static class ExcelWorkServicecs
    {
        static Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        static Workbook workbook;
        static Range excelrange;
        public static void OpenXlsFile(string path)
        {
            try
            {
                workbook = ExcelApp.Workbooks.Open(path,Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static string[,] ReadWorkTypes()
        {
            Worksheet sheet = (Worksheet)workbook.Sheets[1];
            excelrange = sheet.UsedRange;
            string[,] ret = new string[excelrange.Rows.Count, excelrange.Columns.Count];
            for(int i=0;i<ret.GetLength(0);i++)
                for(int j = 0; j < ret.GetLength(1); j++)
                {
                    ret[i, j] = excelrange[i, j];
                }
            return ret;
        }
    }
}
