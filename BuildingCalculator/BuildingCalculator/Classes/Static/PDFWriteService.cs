using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.RtfRendering;

namespace BuildingCalculator
{
    public enum AddType{ newPage,ActivePage};//необходимо для добавления на новую страницу или старую
    public enum AlignType { center, left, right,none};
    public static class PDFWriteService
    {
        static string FilePath = Directory.GetCurrentDirectory();
        static string FileName = "Отчёт";//Имя документа
        static XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

        static PdfDocument doc;//документ
        static PdfPage activePage;//текущая страница
        static int LastY;
        public static void InitializeNewFile(string name,string path,string author = "BuildingCalckulator")//инициализирует создание документа
        {
            //if (doc != null)
            //    endOfFile();
            
            //FileName = name;
            //FilePath = path;
            //doc = new pdfDocument(FileName, author);
        }
        public static void HelloWorld()
        {

            PdfDocument document = new PdfDocument("HelloWorld");
            document.Info.Title = "HelloWorld";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic,options);
            gfx.DrawString("*!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            const string filename = "HelloWorld.pdf";
            document.Save(filename);
            //Process.Start(filename);

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
        //public static void AddTable(string[,] content, double size, string[] headers, AddType addType = AddType.ActivePage, AlignType align = AlignType.left)
        //{
        //    if (content.GetLength(1) != headers.Length)
        //        throw new ArgumentException("Количество заголовков не равно количеству столбцов");
        //    pdfPage page = getPage(addType);
        //    int x = 100;
        //    int y = LastY;

        //    switch (align)
        //    {
        //        case AlignType.center: x = page.width / 2 - (int)(size / 2); break;
        //        case AlignType.left: x = 0; break;
        //        case AlignType.right: x = page.width - (int)size - 20; break;
        //    }


        //    pdfTable table = new pdfTable();//создаем таблицу
        //    table.borderSize = 1;//размер рамки
        //    table.borderColor = new pdfColor(predefinedColor.csBlack);//цвет рамки

        //    for (int i = 0; i < content.GetLength(1); i++)
        //        table.tableHeader.addColumn(new pdfTableColumn(headers[i], predefinedAlignment.csCenter, (int)(size / content.GetLength(1))));

        //    for (int i = 0; i < content.GetLength(0); i++)//заполнение таблицы
        //    {
        //        pdfTableRow row = table.createRow();
        //        for (int j = 0; j < content.GetLength(1); j++)
        //        {
        //            row[j].columnValue = content[i, j];
        //        }
        //        table.addRow(row);
        //    }
        //    table.tableHeaderStyle = new pdfTableRowStyle(predefinedFont.csCourierBoldOblique, 12, new pdfColor(predefinedColor.csBlack), new pdfColor(predefinedColor.csGray));//стиль заголовков
        //    table.rowStyle = new pdfTableRowStyle(predefinedFont.csCourier, 10, new pdfColor(predefinedColor.csGray), new pdfColor(predefinedColor.csLightGray));//стиль ячеек таблицы
        //    table.cellpadding = 20;//отступ ячеек
        //    page.addTable(table, x, y);//добавлени таблицы
        //    LastY = y - (int)(size / 1.5);
        //    if (LastY < 0)
        //        AddPage();
        //    table = null;
            


        //}
        ///// <summary>
        ///// Добавление разрыва страниц
        ///// </summary>
        //public static void AddPage()
        //{
        //    //activePage = doc.addPage();
        //    //LastY = activePage.height - 100;
        //}
        ///// <summary>
        ///// Служебный метод который определяет, на какую страницу писать
        ///// </summary>
        ///// <param name="addType"></param>
        ///// <returns></returns>
        //static pdfPage getPage(AddType addType = AddType.ActivePage)
        //{
        //    pdfPage page;
        //    if (addType == AddType.newPage || activePage == null)
        //    {
        //        page = doc.addPage();//создаем новую страницу
        //        activePage = page;
        //        LastY = activePage.height - 100;
        //    }
        //    else
        //        page = activePage;
        //    return page;
        //}
        ///// <summary>
        ///// Добавление заголовка на страницу
        ///// </summary>
        ///// <param name="text">Текст заголовка</param>
        ///// <param name="addType">Тип добавления</param>
        ///// <param name="content">Содержание таблицы</param>
        ///// <param name="size">Размер таблицы на странице</param>
        ///// <param name="headers">Заголовки столбцов</param>
        ///// <param name="x">Координата Х на странице</param>
        ///// <param name="y">Координата У на странице</param>
        //public static void AddHeader(string text, int size = 20, AddType addType = AddType.ActivePage, AlignType align = AlignType.left)
        //{
        //    pdfPage page = getPage(addType);
        //    int x = 100;
        //    int y = LastY;
        //    switch (align)
        //    {
        //        case AlignType.center: x = page.width / 2; break;
        //        case AlignType.left: x = 0; break;
        //        case AlignType.right: x = page.width - (text.Length * size); break;
        //    }
        //    LastY = y - 50;
        //    if (LastY < 0)
        //        AddPage();
        //    page.addText(text, x, y, predefinedFont.csHelvetivaBoldOblique, size);
        //}
        ///// <summary>
        ///// Добавление текста на страницу
        ///// </summary>
        ///// <param name="text">Текст заголовка</param>
        ///// <param name="addType">Тип добавления</param>
        ///// <param name="content">Содержание таблицы</param>
        ///// <param name="size">Размер таблицы на странице</param>
        ///// <param name="headers">Заголовки столбцов</param>
        ///// <param name="x">Координата Х на странице</param>
        ///// <param name="y">Координата У на странице</param>
        //public static void AddText(string text, int size = 10, AddType addType = AddType.ActivePage, AlignType align = AlignType.left)
        //{
        //    pdfPage page = getPage(addType);
        //    int x = 100;
        //    int y = LastY;
        //    switch (align)
        //    {
        //        case AlignType.center: x = page.width / 2; break;
        //        case AlignType.left: x = 0; break;
        //        case AlignType.right: x = page.width - (text.Length * size); break;
        //    }
        //    LastY = y - 50;
        //    if (LastY < 0)
        //        AddPage();
        //    page.addText(text, x, y, predefinedFont.csHelvetica, size);
        //}
        ///// <summary>
        ///// Добавление Параграфов на страницу
        ///// </summary>
        ///// <param name="text">Текст заголовка</param>
        ///// <param name="addType">Тип добавления</param>
        ///// <param name="content">Содержание таблицы</param>
        ///// <param name="size">Размер таблицы на странице</param>
        ///// <param name="headers">Заголовки столбцов</param>
        ///// <param name="x">Координата Х на странице</param>
        ///// <param name="y">Координата У на странице</param>
        ///// <param name="width">Ширина параграфа</param>

        ///// <summary>
        ///// Завершает документ и записывает его в файл
        ///// </summary>
        //public static void endOfFile(bool rewrite = true)
        //{
        //    try
        //    {
        //        if (rewrite && File.Exists(FilePath + ".pdf"))
        //            File.Delete(FilePath + ".pdf");
        //        doc.createPDF(FilePath + ".pdf");
        //    }
        //    catch
        //    {
        //        int i;
        //        for (i = 1; File.Exists(FilePath + "(" + i + ").pdf"); i++) ;
        //        doc.createPDF(FilePath + "(" + i + ").pdf");

        //    }
        //    doc = null;
        //    activePage = null;
        //}
    }
}
