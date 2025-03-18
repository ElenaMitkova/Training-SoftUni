using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
namespace FolderSize;
public class FolderSize
{
    static void Main(string[] args)
    {
        string folderPath = @"..\..\..\Files\TestFolder";
        string outputPath = @"..\..\..\Files\output.txt";
        GetFolderSize(folderPath, outputPath);
    }
    public static void GetFolderSize(string folderPath, string outputFilePath)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(folderPath);
        long size = 0;
        while (queue.Count > 0)
        {
            string folder = queue.Dequeue();
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
            {
                size += file.Length;
            }
            string[] subs = Directory.GetDirectories(folder);
            foreach (string folders in subs)
            {
                queue.Enqueue(folders);
            }
        }
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            writer.WriteLine($"{size / 1024m} KB");
        }
    }
}