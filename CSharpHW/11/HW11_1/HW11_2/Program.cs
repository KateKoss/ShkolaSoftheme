using System;
using HW11_1;
namespace HW11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer myPrinter = new Printer();
            myPrinter.PrinterExtention();
            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.ColorPrinterExtention(ConsoleColor.Cyan);
            Photo myPhoto = new Photo("^-^");
            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.PhotoPrinterExtention(myPhoto);
            Console.ReadKey();
        }
    }
    
}
