using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    static class ProgramUtil
    {
        public static void start()
        {
            while (true)
            {
                printMenu();
                int figureNumber, dimention;
                Console.Write("Input figure number: ");
                if (int.TryParse(Console.ReadLine(), out figureNumber))
                {
                    Console.Write("Input figure dimention: ");
                    if (int.TryParse(Console.ReadLine(), out dimention))
                    {
                        figureChoise(figureNumber, dimention);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        static void printMenu()
        {
            Console.WriteLine("Choose figure:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Romb");
        }

        static void figureChoise(int figureNumber, int dimention)
        {
            switch (figureNumber)
            {
                case 1:
                    new Figure(dimention).fillTriangle().printFigure();
                    break;
                case 2:
                    new Figure(dimention).fillSquare().printFigure();
                    break;
                case 3:
                    if (dimention % 2 == 0)
                    {
                        Console.WriteLine("Dimention must be odd.");
                    }
                    else
                    {
                        new Figure(dimention).fillRhombus().printFigure();
                    }                    
                    break;
            }
        }
    }
}
