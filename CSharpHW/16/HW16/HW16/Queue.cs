using System;

namespace HW16
{
    class Queue<T> 
    {
        private T[] array;
        //private int head;
        private int size;

        public Queue()
        {
            //size = 0;
            //head = -1;
        }

        public void Enqueue(T value)
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

        public T Dequeue()
        {
            if (size != 0)
            {
                T[] tmpArr = array;
                array = new T[size - 1];
                Array.Copy(tmpArr, 0, array, 0, array.Length);
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
                throw new InvalidOperationException("Queue is empty.", null);
            }
            return array[size - 1];
        }
    }
}
