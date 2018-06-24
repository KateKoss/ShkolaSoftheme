using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace HW25
{
    class DirectoryArchivateUtil
    {
        public static void ArchivateAllInDir(string startArchPath)
        {
            DirectoryInfo directory = new DirectoryInfo(startArchPath);
            var files = directory.GetFiles();
            foreach (var file in files)
            {
                new Thread(() => ArchiveFile(startArchPath, file)).Start();
                //ArchiveFile(startArchPath, file);
            }
            
            DirectoryInfo[] subdirs = directory.GetDirectories();
            if (subdirs.Length != 0)
            {
                foreach(var subDir in subdirs)
                {
                    if (Directory.Exists(subDir.FullName + "\\"))
                    {
                        ArchivateAllInDir(subDir.FullName + "\\");
                    }                        
                }
            }

            Console.WriteLine($"The directory { startArchPath } was archivated successfully.");
        }
        
        public static void ArchiveFile(string path, FileInfo file)
        {
            Console.WriteLine($"Thread { Thread.CurrentThread.GetHashCode() } started archiving file { file.Name }.");
            string newFolderPath = path + "TEMP_FOR_" + file.Name;
            string sourceFile = Path.Combine(path, file.Name);
            string destFile = Path.Combine(newFolderPath, file.Name);
            DirectoryInfo di = Directory.CreateDirectory(newFolderPath);
            File.Copy(sourceFile, destFile, true);
            File.Delete(sourceFile);
            ZipFile.CreateFromDirectory(newFolderPath, $"{path}{file.Name}.zip");
            Directory.Delete(newFolderPath, true);
        }
    }
}
