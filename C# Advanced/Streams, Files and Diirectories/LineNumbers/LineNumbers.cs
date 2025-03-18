using System;
using System.IO;
namespace LineNumbers;
public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";
        ProcessLines(inputFilePath, outputFilePath);
    }
    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                int countLines = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    int lettersCount = 0;
                    int punctuationCount = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsLetter(line[i]))
                        {
                            lettersCount++;
                        }
                        else if (char.IsPunctuation(line[i]))
                        {
                            punctuationCount++;
                        }
                    }
                    writer.WriteLine($"Line {countLines++}. {line} ({lettersCount})({punctuationCount})");
                }
            }
        }
    }
}