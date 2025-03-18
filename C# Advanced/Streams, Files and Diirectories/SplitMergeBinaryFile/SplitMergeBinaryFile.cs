using System;
using System.IO;
using System.Linq;
namespace SplitMergeBinaryFile;
public class SplitMergeBinaryFile
{
    static void Main()
    {
        string sourceFilePath = @"..\..\..\Files\example.png";
        string joinedFilePath = @"..\..\..\Files\example-joined.png";
        string partOnePath = @"..\..\..\Files\part-1.bin";
        string partTwoPath = @"..\..\..\Files\part-2.bin";
        SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
        MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
    }
    public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
    {
        using (FileStream source = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        {
            int first = (int)(source.Length / 2 + source.Length % 2);
            int second = (int)(source.Length / 2);
            using (FileStream partOne = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int total = 0;
                while (total < first)
                {
                    int currentBytes = source.Read(buffer, 0, Math.Min(buffer.Length, first - total));
                    partOne.Write(buffer, 0, currentBytes);
                    total += currentBytes;
                }
            }
            using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int total = 0;
                while (total < second)
                {
                    int currentBytes = source.Read(buffer, 0, Math.Min(buffer.Length, second - total));
                    partTwo.Write(buffer, 0, currentBytes);
                    total += currentBytes;
                }
            }
        }
    }
    public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
    {
        using (FileStream output = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
        {
            using (FileStream partOne = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
            {
                partOne.CopyTo(output);
            }
            using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
            {
                partTwo.CopyTo(output);
            }
        }
    }
}