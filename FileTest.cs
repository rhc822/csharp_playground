using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace c_sharp_playground
{
    class FileTest
    {
        public static void FileFun()
        {
            string createFilePath = @"C:\Users\ryan.cunningham\source\repos\playground\c-sharp_playground\FileCreateTest.txt";
            string copyFilePath = @"C:\Users\ryan.cunningham\source\repos\playground\c-sharp_playground\FileCopyTest.txt";
            string backupFilePath = @"C:\Users\ryan.cunningham\source\repos\playground\c-sharp_playground\FileBackUpTest.txt";
            
            string writeText = "Hello World!";
            File.WriteAllText(createFilePath, writeText);
            string readText = File.ReadAllText(createFilePath);
            Console.WriteLine($"Original content: {readText}");

            string appendText = "AND Hello there!";
            File.AppendAllText(createFilePath, appendText);
            readText = File.ReadAllText(createFilePath);
            Console.WriteLine($"Original AND appended content: { readText}");

            Console.WriteLine($"Does FileCopyTest.txt exist? {(File.Exists(copyFilePath) ? "Yes" : "No")}");
            bool fileExists = File.Exists(copyFilePath);
            if (fileExists == true)
            {
                Console.WriteLine("Deleting file...");
                File.Delete(copyFilePath);
                Console.WriteLine("Now creating FileCopyTest.txt file from FileCreateTest.txt...");
                File.Copy(createFilePath, copyFilePath);
            }
            else
            {
                Console.WriteLine("Copying file...");
                File.Copy(createFilePath, copyFilePath);
            }

            readText = File.ReadAllText(copyFilePath);
            Console.WriteLine($"Reading copied content from new file: {readText}");
            File.AppendAllText(copyFilePath, "And I've added more to the this copied file!");
            readText = File.ReadAllText(copyFilePath);
            Console.WriteLine($"Reading copied content from new file: {readText}");

            File.Replace(createFilePath, copyFilePath, backupFilePath);
            

        }
        
    }
}
