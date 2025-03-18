Dictionary<char, int> pairs = new Dictionary<char, int>();
string text = Console.ReadLine();
foreach (char item in text)
{
    if (item != ' ')
    {
        if (!pairs.ContainsKey(item))
        {
            pairs.Add(item, 1);
        }
        else
        {
            pairs[item]++;
        }
    }
}
foreach (var pair in pairs)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}