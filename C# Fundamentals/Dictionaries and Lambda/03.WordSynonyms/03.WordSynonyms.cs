Dictionary<string, List<string>> wordsWithSynonyms = new Dictionary<string, List<string>>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string key = Console.ReadLine();
    string value = Console.ReadLine();
    if (wordsWithSynonyms.ContainsKey(key))
    {
        wordsWithSynonyms[key].Add(value);
    }
    else
    {
        wordsWithSynonyms.Add(key, new List<string>() { value });
    }
}
foreach (var word in wordsWithSynonyms)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
}