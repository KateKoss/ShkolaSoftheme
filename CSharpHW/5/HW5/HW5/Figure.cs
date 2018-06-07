using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Figure
    {
        string[,] figureArray;
        int dimention;
        string symbolOfEmptiness = " ";
        string symbolOfFullness = "*";
        public Figure(int dimention)
        {
            this.dimention = dimention;
        }
        public Figure fillRhombus()
        {
            dimention = (dimention * 2) - 1;
            figureArray = new string[dimention,dimention];
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    if (i <= (dimention - 1) / 2)
                    {
                        if (j < (dimention - 1) / 2 - i || j > (dimention - 1) / 2 + i)
                        {
                            figureArray[i, j] = symbolOfEmptiness;
                        }
                        else
                        {
                            figureArray[i, j] = symbolOfFullness;
                        }
                    }
                    else
                    {
                        if (j < (dimention - 1) / 2 + 1 - (dimention - i) || j > (dimention - 1) / 2 - 1 + (dimention - i))
                        {
                            figureArray[i, j] = symbolOfEmptiness;
                        }
                        else
                        {
                            figureArray[i, j] = symbolOfFullness;
                        }
                    }
                }
            }
            return this;
        }

        public Figure fillSquare()
        {
            figureArray = new string[dimention, dimention];
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    figureArray[i, j] = symbolOfFullness;
                }                
            }
            return this;
        }

        public Figure fillTriangle()
        {
            figureArray = new string[dimention, dimention];
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    if (i >= j)
                    {
                        figureArray[i, j] = symbolOfFullness;
                    }
                    else
                    {
                        figureArray[i, j] = symbolOfEmptiness;
                    }
                }                
            }
            return this;
        }

        public void printFigure()
        {
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    Console.Write(" " + figureArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
