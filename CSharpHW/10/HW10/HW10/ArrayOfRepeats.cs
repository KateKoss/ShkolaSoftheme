using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class ArrayOfRepeats
    {
        int[] repeatsArray;
        public ArrayOfRepeats(int dimension)
        {
            repeatsArray = new int[dimension];
        }

        public void FillArray()
        {
            Random random = new Random();
            int repeatCounter = 0;
            for (int i = 0; i < repeatsArray.Length; i++)
            {
                repeatsArray[i] = random.Next(1, repeatsArray.Length / 2 + 2);
                for (int j = 0; j < i; j++)
                {
                    if (repeatsArray[i] == repeatsArray[j])
                    {
                        repeatCounter++;
                        if (repeatCounter == 2)
                        {
                            i--;
                            repeatCounter = 0;
                        }
                    }
                }
            }
        }

        public int FindUniqueElement()
        {
            int i = 0;
            for (; i < repeatsArray.Length-1; i+=2)
            {
                if (repeatsArray[i] != repeatsArray[i + 1])
                {
                    Console.WriteLine(repeatsArray[i]);
                    break;
                }
            }
            return repeatsArray[i];
        }

        public void InsertionSort()
        {
            for (int i = 1; i < repeatsArray.Length; i++)
            {
                int cur = repeatsArray[i];
                int j = i;
                for (; j > 0 && cur < repeatsArray[j - 1]; j--)
                {
                    repeatsArray[j] = repeatsArray[j - 1];
                }
                repeatsArray[j] = cur;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < repeatsArray.Length; i++)
            {
                Console.Write(repeatsArray[i] + " ");
            }
        }
    }
}
