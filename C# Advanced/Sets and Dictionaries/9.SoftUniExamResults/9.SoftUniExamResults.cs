Dictionary<string, Dictionary<string, int>> systemMap = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, int> submissions = new Dictionary<string, int>();
string command =string.Empty;
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] arguments = command.Split('-');
    string username = arguments[0];
    if (arguments.Length == 3)
    {
        string language = arguments[1];
        int points = int.Parse(arguments[2]);
        if (!systemMap.ContainsKey(username))
        {
            systemMap[username] = new Dictionary<string, int>();
        }
        if (!systemMap[username].ContainsKey(language) || systemMap[username][language] < points)
        {
            systemMap[username][language] = points;
        }
        if (!submissions.ContainsKey(language))
        {
            submissions[language] = 0;
        }
        submissions[language]++;
    }
    else
    {
        systemMap.Remove(username);
    }
}
Console.WriteLine("Results:");
foreach (var user in systemMap.Select(x => new { Username = x.Key, Points = x.Value.Values.Max()}).OrderByDescending(x => x.Points).ThenBy(x => x.Username))
{
    Console.WriteLine($"{user.Username} | {user.Points}");
}
Console.WriteLine("Submissions:");
foreach ((string language, int count) in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{language} - {count}");
}