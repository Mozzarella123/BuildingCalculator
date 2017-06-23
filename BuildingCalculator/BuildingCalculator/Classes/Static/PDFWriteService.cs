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
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.RtfRendering;

namespace BuildingCalculator
{
    public enum AddType{ newPage,ActivePage};//необходимо для добавления на новую страницу или старую
    public enum AlignType { center, left, right,none};
    public static class PDFWriteService
    {
        static Unit ColumnWidth = new Unit(200, UnitType.Point);
        static string FilePath = Directory.GetCurrentDirectory();
        static string FileName = "Отчёт";//Имя документа
        static XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
        static PdfDocument doc;//документ
        static PdfPage activePage;//текущая страница
        static int LastY;
        public static void InitializeNewFile(Document document,string filename)//инициализирует создание документа
        { 

                // Get the predefined style Normal.
                Style style = document.Styles["Normal"];
                // Because all styles are derived from Normal, the next line changes the 
                // font of the whole document. Or, more exactly, it changes the font of
                // all styles and paragraphs that do not redefine the font.
                style.Font.Name = "Times New Roman";
                // Heading1 to Heading9 are predefined styles with an outline level. An outline level
                // other than OutlineLevel.BodyText automatically creates the outline (or bookmarks) 
                // in PDF.

                style = document.Styles["Heading1"];
                style.Font.Name = "Tahoma";
                style.Font.Size = 14;
                style.Font.Bold = true;
                style.Font.Color = Colors.DarkBlue;
                style.ParagraphFormat.PageBreakBefore = true;
                style.ParagraphFormat.SpaceAfter = 6;

                style = document.Styles["Heading2"];
                style.Font.Size = 12;
                style.Font.Bold = true;
                style.ParagraphFormat.PageBreakBefore = false;
                style.ParagraphFormat.SpaceBefore = 6;
                style.ParagraphFormat.SpaceAfter = 6;

                style = document.Styles["Heading3"];
                style.Font.Size = 10;
                style.Font.Bold = true;
                style.Font.Italic = true;
                style.ParagraphFormat.SpaceBefore = 6;
                style.ParagraphFormat.SpaceAfter = 3;

                style = document.Styles[StyleNames.Header];
                style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

                style = document.Styles[StyleNames.Footer];
                style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            
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
        public static void AddTable(Document document,string[,] content, string[] headers=null)
        {
            
            if (headers != null&&content.GetLength(0) != headers.Length)
                throw new IndexOutOfRangeException("Количество заголовков не совпадает с количеством столбцов в таблице контента");
            int columncounts = 0;
            Table table = new Table();
            table.Borders.Width = 0.75;
            table.TopPadding = 5;
            table.BottomPadding = 5;
            if (headers==null)
                columncounts = content.GetLength(1);
            else
                columncounts = headers.Length;        
            for (int i = 0; i < columncounts; i++)
            {
                if (headers != null)
                {
                    Column column = table.AddColumn(Unit.FromPoint(headers[i].Length+10));
                    column.Format.Alignment = ParagraphAlignment.Center;
                    Row row = table.AddRow();
                    row.VerticalAlignment = VerticalAlignment.Center;
                    Cell cell = row.Cells[i];
                    Paragraph paragraph = cell.AddParagraph(headers[i]);
                    paragraph.Format.Font.Bold = true;
                }
                else table.AddColumn(ColumnWidth);

            }
            for (int i=0;i<content.GetLength(0);i++)
            {
                Row row = table.AddRow();
                for (int j=0;j<content.GetLength(1);j++)
                {
                    Cell cell = row.Cells[j];
                    cell.AddParagraph(content[i, j]);
                }
            }
            document.LastSection.Add(table);
            
        }
        public static void SaveDocument(Document document)
        {
            MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, "MigraDoc.mdddl");
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();
            // Save the document...
            string filename = FileName+".pdf";
            renderer.PdfDocument.Save(filename);
        }
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
