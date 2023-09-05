using System;

namespace ConsolePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please seletc which option you want to proceed with ...");
            Console.WriteLine("[R]otate a pdf");
            Console.WriteLine("[M]erge pdfs");
            Console.WriteLine("[C]ompress pdfs");
            char option = char.ToLower(Console.ReadKey().KeyChar);

            switch (option)
            {
                case 'r':
                    PDFMethods.RotatePdf();
                    break;
                case 'm':
                    PDFMethods.MergePdfs();
                    break;
                case 'c':
                    PDFMethods.CompressPdf();
                    break;
                default:
                    Console.WriteLine("Next time select a valid option ...");
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}
