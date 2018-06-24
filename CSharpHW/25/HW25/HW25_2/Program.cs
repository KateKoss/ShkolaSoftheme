using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW25_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "..\\..\\Data\\";
            DirectoryUnrchivateUtil.UnarchivateAllInDir(dirPath);
            Console.ReadKey();
        }
    }
}
