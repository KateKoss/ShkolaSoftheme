using System;

namespace HW11_1
{
    public class ColorPrinter : Printer
    {
        override
        public void Print(string message)
        {
            Console.WriteLine(message + " (ColorPrinter class)");
        }
        
        public void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("ColorPrinter " + message);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
