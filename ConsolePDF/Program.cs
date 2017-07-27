using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            //PdfPage.PdfStream();
            PdfDocument doc = new PdfDocument();
            doc.Pages.Add();
        }
    }
}
