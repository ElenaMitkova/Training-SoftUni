using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace WordCount;
public class WordCount
{
    static void Main()
    {
        string wordPath = @"..\..\..\Files\words.txt";
        string textPath = @"..\..\..\Files\text.txt";
        string outputPath = @"..\..\..\Files\output.txt";
        CalculateWordCounts(wordPath, textPath, outputPath);
    }
    public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
    {
        string[] words;
        using (StreamReader wordReader = new StreamReader(wordsFilePath))
        {
            words = wordReader.ReadLine().Split();
        }
        Dictionary<string, int> countByWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            countByWords[words[i]] = 0;
        }
        using (StreamReader textReader = new StreamReader(textFilePath))
        {
            while (!textReader.EndOfStream)
            {
                string[] line = textReader.ReadLine().ToLower().Split(new char[] { ' ', ',', '.', '-', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < line.Length;i++)
                {
                    if (countByWords.ContainsKey(line[i]))
                    {
                        countByWords[line[i]]++;
                    }
                }
            }
        }
        countByWords = countByWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach ((string word, int count) in countByWords)
            {
                writer.WriteLine($"{word} - {count}");
            }
        }
    }
}