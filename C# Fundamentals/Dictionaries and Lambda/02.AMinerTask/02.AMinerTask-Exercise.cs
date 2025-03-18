Dictionary<string, int> resources = new Dictionary<string, int>();
string input;
while ((input = Console.ReadLine()) != "stop")
{
    string resource = input;
    int quantity = int.Parse(Console.ReadLine());
    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, 0);
    }
    resources[resource] += quantity;
}
foreach (var pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}