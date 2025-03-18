Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split(" -> ");
    string colour = arguments[0];
    string[] items = arguments[1].Split(",");
    if (!clothes.ContainsKey(colour))
    {
        clothes[colour] = new Dictionary<string, int>();
    }
    for (int j = 0; j < items.Length; j++)
    {
        if (!clothes[colour].ContainsKey(items[j]))
        {
            clothes[colour][items[j]] = 0;
        }
        clothes[colour][items[j]]++;
    }
}
string[] item = Console.ReadLine().Split();
string color = item[0];
string thing = item[1];
foreach ((string colour, Dictionary<string, int> clothing) in clothes)
{
    Console.WriteLine($"{colour} clothes:");
    foreach ((string name, int count) in clothing)
    {
        Console.Write($"* {name} - {count}");
        if (colour == color && name == thing)
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}