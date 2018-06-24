using System;

namespace HW17
{
    class Program
    {
        static void Main(string[] args)
        {
            var agregate = new ConcreteAggregate<int>();
            agregate[0] = 1;
            agregate[1] = 2;
            agregate[2] = 3;
            agregate[3] = 4;

            var iterator = new ConcreteIterator<int>(agregate);
            
            for (var item = iterator.First(); item != null; item = iterator.Next())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
