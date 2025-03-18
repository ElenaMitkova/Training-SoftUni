Dictionary<string, string> sidesByUsers = new Dictionary<string, string>();
string command = string.Empty;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    if (command.Contains('|'))
    {
        string[] arguments = command.Split(" | ");
        string side = arguments[0];
        string user = arguments[1];
        if (!sidesByUsers.ContainsKey(user))
        {
            sidesByUsers[user] = side;
        }
    }
    else
    {
        string[] arguments = command.Split(" -> ");
        string user = arguments[0];
        string side = arguments[1];
        sidesByUsers[user] = side;
        Console.WriteLine($"{user} joins the {side} side!");
    }
}
Dictionary<string, List<string>> usersBySide = sidesByUsers.GroupBy(x => x.Value).ToDictionary(x => x.Key, x => x.Select(x => x.Key).ToList());
foreach ((string side, List<string> members) in usersBySide.Where(s => s.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    Console.WriteLine($"Side: {side}, Members: {members.Count}");
    foreach (string member in members.OrderBy(x => x))
    {
        Console.WriteLine($"! {member}");
    }
}