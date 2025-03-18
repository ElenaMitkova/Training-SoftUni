using System;
using System.IO;
namespace CopyBinaryFile;
public class CopyBinaryFile
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\copyMe.png";
        string outputFilePath = @"..\..\..\copyMe-copy.png";
        CopyFile(inputFilePath, outputFilePath);
    }
    public static void CopyFile(string inputFilePath, string outputFilePath)
    {
        using (FileStream input = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int readBytes = 0;
                while ((readBytes = input.Read(buffer)) != 0)
                {
                    output.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}