Dictionary<string, List<string>> companyIds = new Dictionary<string, List<string>>();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] arguments = input.Split(" -> ");
    if (!companyIds.ContainsKey(arguments[0]))
    {
        companyIds.Add(arguments[0], new List<string>() { arguments[1] });
    }
    if (!companyIds[arguments[0]].Contains(arguments[1]))
    {
        companyIds[arguments[0]].Add(arguments[1]);
    }
}
foreach (var company in companyIds)
{
    Console.WriteLine(company.Key);
    foreach (var list in company.Value)
    {
        Console.WriteLine($"-- {list}");
    }
}