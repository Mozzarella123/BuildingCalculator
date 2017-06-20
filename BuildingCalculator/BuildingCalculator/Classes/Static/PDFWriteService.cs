using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharpPDF;
using sharpPDF.Enumerators;

namespace BuildingCalculator
{
    public static class PDFWriteService
    {
        static string FileName;
        static string FilePath;
        static pdfDocument doc;
        public static void InitializeNewFile(string name,string path,string author = "BuildingCalckulator")
        {
            if (doc != null)
                endOfFile();
            FileName = name;
            FilePath = path;
            doc = new pdfDocument(FileName, author);
        }
        public static void HelloWorld()
        {
            pdfDocument myDoc = new pdfDocument("HelloWorld", "slon");//создаем документ
            pdfPage myPage = myDoc.addPage();//добавляем страницу
            myPage.addText("HelloWorld!", 100, 100, predefinedFont.csHelvetica, 20);//вписываем в нее текст
            myDoc.createPDF("HelloWorld.pdf");//сохраняем документ
            myPage = null;
            myDoc = null;
        }
        public static void AddTable(string[,] content, double size, string[] headers = null, int x = 100, int y = 600)
        {
            if (content.GetLength(1) != headers.Length)
                throw new ArgumentException("Количество заголовков не равно количеству столбцов");
            pdfPage page = doc.addPage();//создаем новую страницу
            pdfTable table = new pdfTable();//создаем таблицу
            table.borderSize = 1;//размер рамки
            table.borderColor = new pdfColor(predefinedColor.csBlack);//цвет рамки
            if (headers != null)//добавление заголовков
            {
                for (int i = 0; i < content.GetLength(1); i++)
                    table.tableHeader.addColumn(new pdfTableColumn(headers[i], predefinedAlignment.csCenter, (int)(size / content.GetLength(1))));
            }
            for (int i = 0; i < content.GetLength(0); i++)//заполнение таблицы
            {
                pdfTableRow row = table.createRow();
                for (int j = 0; j < content.GetLength(1); j++)
                {
                    row[j].columnValue = content[i, j];
                }
                table.addRow(row);
            }
            table.tableHeaderStyle = new pdfTableRowStyle(predefinedFont.csCourierBoldOblique, 12, new pdfColor(predefinedColor.csBlack), new pdfColor(predefinedColor.csGray));//стиль заголовков
            table.rowStyle = new pdfTableRowStyle(predefinedFont.csCourier, 10, new pdfColor(predefinedColor.csGray), new pdfColor(predefinedColor.csLightGray));//стиль ячеек таблицы
            table.cellpadding = 20;//отступ ячеек
            page.addTable(table, x, y);//добавлени таблицы
            table = null;

        }
        public static void endOfFile()
        {
            doc.createPDF(FilePath + ".pdf");
        }
    }
}
