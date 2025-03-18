Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
string input;
while ((input = Console.ReadLine()) != "Season end")
{
    string[] arguments = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    if (arguments.Length == 3)
    {
        string player = arguments[0];
        string position = arguments[1];
        int skill = int.Parse(arguments[2]);
        if (!players.ContainsKey(player))
        {
            players[player] = new Dictionary<string, int>();
        }
        if (!players[player].ContainsKey(position) || players[player][position] < skill)
        {
            players[player][position] = skill;
        }
    }
    else
    {
        arguments = input.Split(" vs ");
        string firstPlayer = arguments[0];
        string secondPlayer = arguments[1];
        if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
        {
            bool hasCommonPosition = players[firstPlayer].Keys.Intersect(players[secondPlayer].Keys).Any();
            if (hasCommonPosition)
            {
                int firstPlayerSkill = players[firstPlayer].Values.Sum();
                int secondPlayerSkill = players[secondPlayer].Values.Sum();
                if (firstPlayerSkill > secondPlayerSkill)
                {
                    players.Remove(secondPlayer);
                }
                else if (secondPlayerSkill > firstPlayerSkill)
                {
                    players.Remove(firstPlayer);
                }
            }
        }
    }
}
foreach (var person in players.OrderByDescending(skill => skill.Value.Values.Sum()).ThenBy(name => name.Key))
{
    Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()} skill");
    foreach (var positions in person.Value.OrderByDescending(skill => skill.Value).ThenBy(name => name.Key))
    {
        Console.WriteLine($"- {positions.Key} <::> {positions.Value}");
    }
}