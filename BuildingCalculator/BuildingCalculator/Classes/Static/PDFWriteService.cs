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
    public enum HeaderType { first,second,third};
    public static class PDFWriteService
    {
        static Unit ColumnWidth = new Unit(200, UnitType.Point);
        static string FilePath = Directory.GetCurrentDirectory();
        static XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode);
        public static int CurrentDocumentsCount { get { return documents.Count; } }
        public static void HelloWorld()
        {
            CreateNewDocument("HelloWorld");
            Section sect=documents["HelloWorld"].getSection(AddType.ActivePage);

            Paragraph par = sect.AddParagraph();
            par.AddFormattedText("Привет Мир!", TextFormat.Underline);
            RenderDocToPdf("HelloWorld");           

        }
        public static void CreateNewDocument(string DocName,bool rewrite=false)
        {
            if (documents.ContainsKey(DocName))
            {
                if (rewrite)
                    documents.Remove(DocName);
                else
                    throw new ArgumentException("Такой документ уже существует.");
            }
            PDFDocument doc = new PDFDocument();
            documents.Add(DocName, doc);
        }
        public static void RenderDocToPdf(string ident)
        {
            PdfDocumentRenderer render = new PdfDocumentRenderer(true);
            render.Document = documents[ident].doc;
            render.RenderDocument();
            try
            {
                render.Save(ident + ".pdf");
            }
            catch
            {
                int i ;
                for (i = 1; File.Exists(ident + "(" + i + ").pdf"); i++) ;
                render.Save(ident + "(" + i + ").pdf");
            }
        }
        static Dictionary<string, PDFDocument> documents = new Dictionary<string, PDFDocument>();       
        /// <summary>
        /// Добавление таблицы в документ
        /// </summary>
        /// <param name="addType">Тип добавления</param>
        /// <param name="content">Содержание таблицы</param>
        /// <param name="size">Размер таблицы на странице</param>
        /// <param name="headers">Заголовки столбцов</param>
        /// <param name="wrap">Флаги для переноса строки в столбце false: ширина столбца равна максимальной ширине true: ширина столбцы равна средней ширине, все что больше переносится. </param>
        /// <param name="x">Координата Х на странице</param>
        /// <param name="y">Координата У на странице</param>
        public static void AddTable(string ident,string[,] content, string[] headers=null,bool[] wrap=null,AddType type=AddType.ActivePage)
        {
            
            if (headers != null&&content.GetLength(1) != headers.Length)
                throw new IndexOutOfRangeException("Количество заголовков не совпадает с количеством столбцов в таблице контента");
            int[] width = new int[content.GetLength(1)];
            if (wrap == null)
            {
                wrap = new bool[content.GetLength(1)];
                for (int i = 0; i < wrap.Length; i++)
                    wrap[i] = false;
            }
            if(wrap.Length<content.GetLength(1))
            {
                int l = wrap.Length;
                Array.Resize(ref wrap, content.GetLength(1));
                for (int i = l; i < wrap.Length; i++)
                    wrap[i] = false;
            }
            for (int i = 0; i < content.GetLength(1); i++)
            {
                double sum = 0;
                if (wrap[i])
                {
                    for (int j = 0; j < content.GetLength(0); j++)
                    {
                        if (content[j, i] != null)
                            sum += content[j, i].Length;
                    }
                    width[i] = (int)(sum / content.GetLength(0));
                    width[i] = (int)(width[i] * 0.65);
                }
                else
                {
                    int maxL;
                    if (headers != null)
                        maxL = headers[i].Length;
                    else
                        maxL = content[i, 0].Length;
                    for (int j = 0; j < content.GetLength(0); j++)
                        if (content[j, i] != null && content[j, i].Length > maxL) 
                            maxL = content[j, i].Length;
                    width[i] = maxL;
                    width[i] = width[i];

                }

            }
            PDFDocument doc = documents[ident];
            Document document = doc.doc;
            int columncounts = 0;
            Table table = new Table();
            table.Borders.Width = 0.1;
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
                    Column column = table.AddColumn(Unit.FromPoint(width[i]*10));
                    column.Format.Alignment = ParagraphAlignment.Center;                    
                }
                else table.AddColumn(ColumnWidth);
            }
            if (headers!=null)
            {
                Row row = table.AddRow();
                row.VerticalAlignment = VerticalAlignment.Center;                
                for (int i = 0; i < columncounts; i++)
                {
                    Cell cell = row.Cells[i];
                    Paragraph paragraph = cell.AddParagraph(headers[i]);
                    paragraph.Format.Font.Bold = true;
                }
            }
            for (int i=0;i<content.GetLength(0);i++)
            {
                Row row = table.AddRow();
                for (int j=0;j<content.GetLength(1);j++)
                {
                    Cell cell = row.Cells[j];
                    if (content[i, j] == null)
                        content[i, j] = "";
                    AddTextToCell(content[i, j], cell, width[j]);
                    
                }
            }
            doc.getSection(type).Add(table);
            
            
        }

        static private Paragraph AddTextToCell(string instring, Cell cell, int width)
        {

            if (instring.Length > width)
            {
                double FinalWidth = instring.Length;
                while (FinalWidth > width)
                {
                    int center = (int)(instring.Length / 2);
                    instring = instring.Substring(0, center) + "\n" + instring.Substring(center, instring.Length - center);
                    FinalWidth /= 2;
                }
            }
            Paragraph par = cell.AddParagraph(instring);
            return par;
        }

        public static void AddHeader(string ident,string text,HeaderType htype,AddType type = AddType.ActivePage)
        {
            PDFDocument document = documents[ident];
            Section sect = document.getSection(type);
            string style = "";
            switch (htype)
            {
                case HeaderType.first:style = "Heading1";break;
                case HeaderType.second: style = "Heading2"; break;
                case HeaderType.third: style = "Heading3"; break;
            }
            Paragraph par = sect.AddParagraph(text,style);
            
            
            
        }
        public static void AddParagraph(string ident, string text, AddType type = AddType.ActivePage)
        {
            PDFDocument document = documents[ident];
            Section sect = document.getSection(type);
            sect.AddParagraph(text);
        }
    }
}
