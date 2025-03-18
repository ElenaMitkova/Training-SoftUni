Dictionary<string, int> countWords = new Dictionary<string, int>();
string[] array = Console.ReadLine().Split();
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i].ToLower();
    if (countWords.ContainsKey(array[i]))
    {
        countWords[array[i]]++;
    }
    else
    {
        countWords.Add(array[i], 1);
    }
}
Dictionary<string, int> words = new Dictionary<string, int>();
foreach (var word in countWords)
{
    if (word.Value % 2 == 1)
    {
        words.Add(word.Key, word.Value);
    }
}
Console.WriteLine(string.Join(' ', words.Keys));