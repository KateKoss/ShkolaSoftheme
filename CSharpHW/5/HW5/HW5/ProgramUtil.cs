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
                int figureNumber, dimension;
                Console.Write("Input figure number: ");
                if (int.TryParse(Console.ReadLine(), out figureNumber))
                {
                    Console.Write("Input figure dimension: ");
                    if (int.TryParse(Console.ReadLine(), out dimension))
                    {
                        if (dimension > 1)
                        {
                            figureChoise(figureNumber, dimension);
                        }
                        else
                        {
                            Console.WriteLine("Dimension must be greater then 1.");
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Error. Invalid dimension.");
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

        static void figureChoise(int figureNumber, int dimension)
        {
            switch (figureNumber)
            {
                case 1:
                    new Figure(dimension).fillTriangle().printFigure();
                    break;
                case 2:
                    new Figure(dimension).fillSquare().printFigure();
                    break;
                case 3:
                    new Figure(dimension).fillRhombus().printFigure();                 
                    break;
            }
        }
    }
}
