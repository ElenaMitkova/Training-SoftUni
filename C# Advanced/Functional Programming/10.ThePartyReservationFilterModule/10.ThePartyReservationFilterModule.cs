Dictionary<string, Func<string, Func<string, bool>>> filterBuilders = new Dictionary<string, Func<string, Func<string, bool>>>
{
    ["Starts with"] = arg => el => el.StartsWith(arg),
    ["Ends with"] = arg => el => el.EndsWith(arg),
    ["Length"] = arg => el => el.Length == int.Parse(arg),
    ["Contains"] = arg => el => el.Contains(arg)
};
string[] invitations = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
List<Func<string, bool>> activeFilters = new List<Func<string, bool>>();
string command;
while ((command = Console.ReadLine()) != "Print")
{
    string[] data = command.Split(';');
    string operation = data[0];
    string conditionKey = data[1];
    string arg = data[2];
    if (operation == "Add filter")
    {
        Func<string, bool> filter = filterBuilders[conditionKey](arg);
        activeFilters.Add(filter);
    }
    else if (operation == "Remove filter")
    {
        Func<string, bool> filter = filterBuilders[conditionKey](arg);
        activeFilters.Remove(filter);
    }
}
List<string> result = invitations.Where(name => !activeFilters.Any(f => f(name))).ToList();
Console.WriteLine(result.Any() ? string.Join(' ', result) : "Nobody is going to the party!");