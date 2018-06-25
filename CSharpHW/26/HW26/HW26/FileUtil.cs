using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW26
{
    class FileUtil
    {
        private static string logFile = "replace.log";
        public static void ReplaceInFiles(string dirPath, string searchString, string stringForReplace, string fileExtension)
        {
            string logInfo = string.Empty;
            var files = Directory.GetFiles(Path.GetFullPath(dirPath), "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(fileExtension));
            foreach (var file in files)
            {
                Task<string> task = Task.Factory.StartNew(() => ReplaceInFile(file, searchString, stringForReplace));
                //task.Wait();
                Console.WriteLine("hi! " + task.Id);
                logInfo += task.Result;
            }
            if (logInfo.Length == 0)
            {
                Console.WriteLine("Nothing have found.");
            }
            else
            {
                File.WriteAllText(logFile, logInfo);
                Console.WriteLine("Replaced successfully. See \"replace.log\" file.");
            }
        }

        private static string ReplaceInFile(string filename, string searchString, string stringForReplace)
        {
            string logInfo = string.Empty;
            StreamReader sr = new StreamReader(filename);
            string[] rows = Regex.Split(sr.ReadToEnd(), "\r\n");
            sr.Close();

            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    if (rows[i].Contains(searchString))
                    {
                        logInfo += "Found in: " + rows[i] + "\n";
                        rows[i] = rows[i].Replace(searchString, stringForReplace);
                        logInfo += "Replaced : " + rows[i] + "\n";
                    }
                    sw.WriteLine(rows[i]);
                }
            }
            if (logInfo.Length != 0)
            {
                logInfo = string.Concat("File name: " + filename + "\n", logInfo, "\n");
            }
            Console.WriteLine("Done " + Task.CurrentId);
            return logInfo;
        }        
    }
}
