using System;

namespace HW11_1
{
    class ColourPrinter : Printer
    {
        override
        public void Print(string message)
        {
            Console.WriteLine(message + " ColourPrinter");
        }
        
        public void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("ColourPrinter " + message);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
