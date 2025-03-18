using System;
using System.IO;
using System.Linq;
using System.Text;
namespace EvenLines;
public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        Console.WriteLine(ProcessLines(inputFilePath));
    }
    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder builder = new StringBuilder();
        char[] elements = { '-', ',', '.', '!', '?' };
        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            int countLines = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (countLines % 2 == 0)
                {
                    foreach (char symbol in elements)
                    {
                        line = line.Replace(symbol, '@');
                    }
                    string[] words = line.Split().Reverse().ToArray();
                    builder.AppendLine(string.Join(' ', words));
                }
                countLines++;
            }
        }
        return builder.ToString();
    }
}