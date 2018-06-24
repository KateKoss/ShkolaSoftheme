using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace HW25_2
{
    class DirectoryUnrchivateUtil
    {
        public static void UnarchivateAllInDir(string startUnarchPath)
        {
            DirectoryInfo directory = new DirectoryInfo(startUnarchPath);
            var files = directory.GetFiles();
            foreach (var file in files)
            {
                new Thread(() => UnarchiveFile(startUnarchPath, file)).Start();
                //UnarchiveFile(startUnarchPath, file);
            }
            Thread.Sleep(1000);
            DirectoryInfo[] subdirs = directory.GetDirectories();
            if (subdirs.Length != 0)
            {
                foreach (var subDir in subdirs)
                {
                    if (Directory.Exists(subDir.FullName + "\\"))
                    {
                        UnarchivateAllInDir(subDir.FullName + "\\");
                    }
                }
            }
            Console.WriteLine($"The directory { startUnarchPath } was unarchivated successfully.");
        }

        public static void UnarchiveFile(string path, FileInfo archiveFile)
        {
            Console.WriteLine($"Thread { Thread.CurrentThread.GetHashCode() } started unarchiving file { archiveFile.Name }.");
            string archPath = path + archiveFile.Name;
            ZipFile.ExtractToDirectory(archPath, path);
            File.Delete(archPath);
        }
    }
}
