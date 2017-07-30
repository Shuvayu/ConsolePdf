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
            Console.WriteLine("Please seletc which option you want to proceed with ...");
            Console.WriteLine("[R]otate a pdf");
            Console.WriteLine("[M]erge pdfs");
            char option = char.ToLower(Console.ReadKey().KeyChar);

            switch (option)
            {
                case 'r':
                    PDFMethods.RotatePdf();
                    break;
                case 'm':
                    PDFMethods.MergePdfs();
                    break;
                default:
                    Console.WriteLine("Next time select a valid option ...");
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}
