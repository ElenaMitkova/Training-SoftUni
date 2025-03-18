using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace DirectoryTraversal;
public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";
        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);
        WriteReportToDesktop(reportContent, reportFileName);
    }
    public static string TraverseDirectory(string inputFolderPath)
    {
        Dictionary<string, List<FileInfo>> filesByEx = new Dictionary<string, List<FileInfo>>();
        StringBuilder builder = new StringBuilder();
        foreach (string file in Directory.GetFiles(inputFolderPath))
        {
            FileInfo info = new FileInfo(file);
            if (!filesByEx.ContainsKey(info.Extension))
            {
                filesByEx[info.Extension] = new List<FileInfo>();
            }
            filesByEx[info.Extension].Add(info);
        }
        foreach ((string extension, List<FileInfo> files) in filesByEx)
        {
            builder.AppendLine(extension);
            foreach (FileInfo file in files)
            {
                builder.AppendLine($"--{file.Name} - {file.Length / 1024m}kb");
            }
        }
        return builder.ToString();
    }
    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fullPath = pathToDesktop + reportFileName;
        File.WriteAllText(fullPath, textContent);
    }
}