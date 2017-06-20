using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharpPDF;
using sharpPDF.Enumerators;

namespace BuildingCalculator
{
    public enum AddType{ newPage,ActivePage};//необходимо для добавления на новую страницу или старую
    public static class PDFWriteService
    {
        static string FileName;//Имя документа
        static string FilePath;//имя файла
        static pdfDocument doc;//документ
        static pdfPage activePage;//текущая страница
        public static void InitializeNewFile(string name,string path,string author = "BuildingCalckulator")//инициализирует создание документа
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
        /// <summary>
        /// Добавление таблицы в документ
        /// </summary>
        /// <param name="addType">Тип добавления</param>
        /// <param name="content">Содержание таблицы</param>
        /// <param name="size">Размер таблицы на странице</param>
        /// <param name="headers">Заголовки столбцов</param>
        /// <param name="x">Координата Х на странице</param>
        /// <param name="y">Координата У на странице</param>
        public static void AddTable(AddType addType,string[,] content, double size, string[] headers, int x = 100, int y = 600)
        {
            if (content.GetLength(1) != headers.Length)
                throw new ArgumentException("Количество заголовков не равно количеству столбцов");
            pdfPage page = getPage(addType);
            
            pdfTable table = new pdfTable();//создаем таблицу
            table.borderSize = 1;//размер рамки
            table.borderColor = new pdfColor(predefinedColor.csBlack);//цвет рамки

            for (int i = 0; i < content.GetLength(1); i++)
                table.tableHeader.addColumn(new pdfTableColumn(headers[i], predefinedAlignment.csCenter, (int)(size / content.GetLength(1))));
            
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
        /// <summary>
        /// Добавление разрыва страниц
        /// </summary>
        public static void AddPage()
        {
            activePage = doc.addPage();
        }
        /// <summary>
        /// Служебный метод который определяет, на какую страницу писать
        /// </summary>
        /// <param name="addType"></param>
        /// <returns></returns>
        static pdfPage getPage(AddType addType)
        {
            pdfPage page;
            if (addType == AddType.newPage || activePage == null)
            {
                page = doc.addPage();//создаем новую страницу
                activePage = page;
            }
            else
                page = activePage;
            return page;
        }
        /// <summary>
        /// Добавление заголовка на страницу
        /// </summary>
        /// <param name="text">Текст заголовка</param>
        /// <param name="addType">Тип добавления</param>
        /// <param name="content">Содержание таблицы</param>
        /// <param name="size">Размер таблицы на странице</param>
        /// <param name="headers">Заголовки столбцов</param>
        /// <param name="x">Координата Х на странице</param>
        /// <param name="y">Координата У на странице</param>
        public static void AddHeader(AddType addType, string text, int size,int x,int y)
        {
            pdfPage page = getPage(addType);
            page.addText(text, x, y, predefinedFont.csHelvetivaBoldOblique, size);
        }
        /// <summary>
        /// Добавление текста на страницу
        /// </summary>
        /// <param name="text">Текст заголовка</param>
        /// <param name="addType">Тип добавления</param>
        /// <param name="content">Содержание таблицы</param>
        /// <param name="size">Размер таблицы на странице</param>
        /// <param name="headers">Заголовки столбцов</param>
        /// <param name="x">Координата Х на странице</param>
        /// <param name="y">Координата У на странице</param>
        public static void AddText(AddType addType, string text, int size, int x, int y)
        {
            pdfPage page = getPage(addType);
            page.addText(text, x, y, predefinedFont.csHelvetica, size);
        }
        /// <summary>
        /// Добавление Параграфов на страницу
        /// </summary>
        /// <param name="text">Текст заголовка</param>
        /// <param name="addType">Тип добавления</param>
        /// <param name="content">Содержание таблицы</param>
        /// <param name="size">Размер таблицы на странице</param>
        /// <param name="headers">Заголовки столбцов</param>
        /// <param name="x">Координата Х на странице</param>
        /// <param name="y">Координата У на странице</param>
        /// <param name="width">Ширина параграфа</param>
        
        /// <summary>
        /// Завершает документ и записывает его в файл
        /// </summary>
        public static void endOfFile()
        {
            doc.createPDF(FilePath + ".pdf");
            doc = null;
            activePage = null;
        }
    }
}
