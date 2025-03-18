Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string continent = arguments[0];
    string country = arguments[1];
    string town = arguments[2];
    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();
    }
    continents[continent][country].Add(town);
}
foreach ((string continent, Dictionary<string, List<string>> countries) in continents)
{
    Console.WriteLine($"{continent}:");
    foreach ((string country, List<string> towns) in countries)
    {
        Console.WriteLine($"  {country} -> {string.Join(", ", towns)}");
    }
}