using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW25_2
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
            DirectoryUnrchivateUtil.UnarchivateAllInDir(userDirPath);
            Console.ReadKey();
        }
    }
}
