using System;
using System.Threading;

namespace HW25
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "..\\..\\Data\\";
            DirectoryArchivateUtil.ArchivateAllInDir(dirPath);
            Console.ReadKey();
        }
    }
}
