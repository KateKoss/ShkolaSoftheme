using System;
using System.Collections.Generic;
using System.Linq;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(1);
            list.InsertTail(2);
            list.InsertTail(3);
            list.InsertHead(3000);
            list.InsertTail(4);

            list.DeleteTail();
            list.DeleteHead();
            var arr = list.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Contains(3000));
            Console.ReadKey();
        }
    }
}
