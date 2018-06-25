using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter directory path (Example path ..\\..\\Files\\ ): ");
            string userDirPath = Console.ReadLine();
            while (!Directory.Exists(userDirPath))
            {
                Console.Write("Enter directory path (Example path ..\\..\\Files\\ ): ");
                userDirPath = Console.ReadLine();
            }
            Console.Write("Enter search string for replace: ");
            string searchString = Console.ReadLine();
            Console.Write("Enter string for replace: ");
            string replaceString = Console.ReadLine();
            FileUtil.ReplaceInFiles(userDirPath, searchString, replaceString, ".txt");

            Console.ReadKey();
        }
    }
}
