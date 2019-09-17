using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using System.Diagnostics;

namespace lab_29_expoert_to_office
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"RabbitReport.docx";
            //string fileNameDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName;
            //save it to a directory
            
            string fileNameDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName;

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("Rabbit Report");
            doc.InsertParagraph("Number of Rabbits created: 1005");

            doc.InsertParagraph("Time taken: 7.234 seconds with one loop");
            doc.InsertParagraph("Time taken: 19.123 seconds with 1000 loops");

            doc.Save();

            //reun word and view report
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
