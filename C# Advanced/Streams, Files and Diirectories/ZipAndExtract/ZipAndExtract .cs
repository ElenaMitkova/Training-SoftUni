using System;
using System.IO;
using System.IO.Compression;
namespace ZipAndExtract;
public class ZipAndExtract
{
    static void Main()
    {
        string inputFile = @"..\..\..\copyMe.png";
        string zipArchiveFile = @"..\..\..\archive.zip";
        string extractedFile = @"..\..\..\extracted.png";
        ZipFileToArchive(inputFile, zipArchiveFile);
        string fileNameOnly = Path.GetFileName(inputFile);
        ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
    }
    public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
    {
        using (ZipArchive zipFile = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
        {
            string inputName = Path.GetFileName(inputFilePath);
            zipFile.GetEntry(inputName);
        }
    }
    public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
    {
        using (ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath))
        {
            if (archive.GetEntry(fileName) is not null)
            {
                archive.GetEntry(fileName).ExtractToFile(outputFilePath);
            }
        }
    }
}