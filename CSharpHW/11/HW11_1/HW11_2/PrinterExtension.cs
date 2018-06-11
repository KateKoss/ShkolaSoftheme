using System;
using HW11_1;

namespace HW11_2
{
    public static class PrinterExtension
    {
        public static void ColorPrinterExtention(this ColorPrinter colorPrinter, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            colorPrinter.Print("Printed from Color printer extention! Extends the ");
            Console.ResetColor();
        }
        public static void PhotoPrinterExtention(this PhotoPrinter photoPrinter, Photo photo)
        { 
            photoPrinter.Print("Printed from Photo printer extention! New Photo: " + photo.GetPhoto());
        }
        public static void PrinterExtention(this Printer printer)
        {
            printer.Print("Printed from printer extention!");
        }
    }
}
