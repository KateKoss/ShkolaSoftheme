using System;
using System.IO;
using System.Threading;

namespace HW25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter directory path (Example path ..\\..\\Data\\ ): ");
            string userDirPath = Console.ReadLine();
            while (!Directory.Exists(userDirPath))
            {
                Console.Write("Enter directory path (Example path ..\\..\\Data\\ ): ");
                userDirPath = Console.ReadLine();
            }
            DirectoryArchivateUtil.ArchivateAllInDir(userDirPath);
            Console.ReadKey();
        }
    }
}
