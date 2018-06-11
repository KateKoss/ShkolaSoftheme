using System;
using System.Windows;
namespace HW11_1
{
    public class PhotoPrinter : Printer
    {
        override
        public void Print(string message)
        {
            Console.WriteLine(message + " (PhotoPrinter class)");
        }

        public void Print(Photo photo)
        {
            Console.WriteLine(photo.GetPhoto() + " (PhotoPrinter class)");
        }
    }
}
