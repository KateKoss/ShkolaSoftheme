using System;

namespace HW16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue: ");
            var queue = new Queue<int>();
            for (int i = 1; i < 11; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 1; i < 12; i++)
            {
                try
                {
                    Console.WriteLine(queue.Peek());
                    queue.Dequeue();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Stack: ");
            var stack = new Stack<int>();
            for (int i = 1; i < 11; i++)
            {
                stack.Push(i);
            }

            for (int i = 1; i < 12; i++)
            {
                try
                {
                    Console.WriteLine(stack.Peek());
                    stack.Pop();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Dictionary: ");
            var dictionary = new Dictionary<int, string>();
            try
            {
                dictionary.Add(1, "one");
                dictionary.Add(2, "two");
                dictionary.Add(3, "three");
                dictionary.Add(4, "four");
                dictionary.Add(5, "five");
                Console.WriteLine(dictionary.ToString());
                dictionary.Remove(5);
                dictionary.Remove(1);
                Console.WriteLine(dictionary.ToString());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
