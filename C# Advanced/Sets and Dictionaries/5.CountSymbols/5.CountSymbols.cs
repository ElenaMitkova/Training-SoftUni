SortedDictionary<char, int> charactersCount = new SortedDictionary<char, int>();
string text = Console.ReadLine();
for (int i = 0; i < text.Length; i++)
{
    char element = text[i];
    if (!charactersCount.ContainsKey(element))
    {
        charactersCount[element] = 0;
    }
    charactersCount[element]++;
}
foreach ((char character, int count) in charactersCount)
{
    Console.WriteLine($"{character}: {count} time/s");
}