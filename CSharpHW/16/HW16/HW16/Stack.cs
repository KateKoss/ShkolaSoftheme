using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class Stack<T>
    {
        private T[] array;
        private int size;

        public Stack()
        {

        }

        public void Push(T value)
        {
            if (size != 0)
            {
                T[] tmpArr = array;
                array = new T[size + 1];
                Array.Copy(tmpArr, 0, array, 1, tmpArr.Length);
            }
            else
            {
                array = new T[1];
            }
            array[0] = value;
            size++;
        }

        public T Pop()
        {
            if (size != 0)
            {
                T[] tmpArr = array;
                array = new T[size - 1];
                Array.Copy(tmpArr, 1, array, 0, array.Length);
                size--;
                if (size == 0)
                {
                    return default(T);
                }
                return array[size - 1];
            }
            else
            {
                throw new InvalidOperationException("Could not delete non-existing item.", null);
            }
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty.", null);
            }
            return array[0];
        }
    }
}
