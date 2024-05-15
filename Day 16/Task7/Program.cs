using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Program
    {
        static void Main()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  File type: {0}", d.DriveType);

                if (d.IsReady == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(d.Name);
                    FileInfo[] files = dirInfo.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        Console.WriteLine("  File: {0}", file.Name);
                    }
                }
            }

            string directoryPath = @"E:\Example_36tr";
            Directory.CreateDirectory(directoryPath);

            string sourceDirectory = @"C:\source"; 
            string[] filesToCopy = Directory.GetFiles(sourceDirectory);
            for (int i = 0; i < 3; i++)
            {
                string fileName = Path.GetFileName(filesToCopy[i]);
                string destFile = Path.Combine(directoryPath, fileName);
                File.Copy(filesToCopy[i], destFile);
            }

            FileInfo[] copiedFiles = new DirectoryInfo(directoryPath).GetFiles();
            foreach (FileInfo file in copiedFiles)
            {
                file.Attributes |= FileAttributes.Hidden;
            }

            foreach (FileInfo file in copiedFiles)
            {
                string linkFilePath = Path.Combine(directoryPath, file.Name + ".lnk");
                using (StreamWriter sw = File.CreateText(linkFilePath))
                {
                    sw.WriteLine("Ссылка на скрытый файл: " + file.FullName);
                }
            }

            Console.ReadLine();
        }
    }
}
