using System;

namespace HW11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Printer printer = new Printer();
            printer.Print("From Printer class");
            ColorPrinter colorPrinter = new ColorPrinter();
            
            colorPrinter.Print("From class(color): ", ConsoleColor.Yellow);
            colorPrinter.Print("From class: ");

            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print("From class: ");
            photoPrinter.Print(new Photo("Emogi"));
            Console.ReadKey();
        }
    }
}
