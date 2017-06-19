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
        public static void HelloWorld()
        {
            pdfDocument myDoc = new pdfDocument("HelloWorld", "slon");//создаем документ
            pdfPage myPage = myDoc.addPage();//добавляем страницу
            myPage.addText("HelloWorld!", 100, 100, predefinedFont.csHelvetica, 20);//вписываем в нее текст
            myDoc.createPDF("HelloWorld.pdf");//сохраняем документ
            myPage = null;
            myDoc = null;
        }
    }
}
