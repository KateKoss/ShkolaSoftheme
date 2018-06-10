using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_3
{
    class IntArrayWrapper
    {
        private int[] integerArray;

        public IntArrayWrapper(int[] integerArray)
        {
            this.integerArray = integerArray;
        }

        public void Add(params int [] integers)
        {
            int[] copyArr = integerArray;
            integerArray = new int[integerArray.Length + integers.Length];
            for (int i = 0; i < copyArr.Length; i++)
            {
                integerArray[i] = copyArr[i];
            }
            for (int i = 0; i < integers.Length; i++)
            {
                integerArray[copyArr.Length + i] = integers[i];
            }
        }

        public bool Contains(int valueToCheck)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] == valueToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetByIndex(int index)
        {
            return integerArray[index];
        }

        public void PrintArray()
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.Write(integerArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
