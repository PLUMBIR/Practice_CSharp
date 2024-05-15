using System;
using System.IO;

namespace Task16
{
    /// <summary>
    /// A class for managing files and directories.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        static void Main()
        {
            // Get information about all drives
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);

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

            // Create a new directory
            string directoryPath = @"E:\Example_36tr";
            Directory.CreateDirectory(directoryPath);

            // Copy files from a source directory
            string sourceDirectory = @"C:\source";
            string[] filesToCopy = Directory.GetFiles(sourceDirectory);
            for (int i = 0; i < 3; i++)
            {
                string fileName = Path.GetFileName(filesToCopy[i]);
                string destFile = Path.Combine(directoryPath, fileName);
                File.Copy(filesToCopy[i], destFile);
            }

            // Hide copied files
            FileInfo[] copiedFiles = new DirectoryInfo(directoryPath).GetFiles();
            foreach (FileInfo file in copiedFiles)
            {
                file.Attributes |= FileAttributes.Hidden;
            }

            // Create shortcut files for each copied file
            foreach (FileInfo file in copiedFiles)
            {
                string linkFilePath = Path.Combine(directoryPath, file.Name + ".lnk");
                using (StreamWriter sw = File.CreateText(linkFilePath))
                {
                    sw.WriteLine("Link to hidden file: " + file.FullName);
                }
            }

            Console.ReadLine();
        }
    }
}
