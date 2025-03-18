var contests = new Dictionary<string, string>();
var users = new Dictionary<string, Dictionary<string, int>>();
string input;
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] parts = input.Split(':');
    string contest = parts[0];
    string password = parts[1];
    contests[contest] = password;
}
while ((input = Console.ReadLine()) != "end of submissions")
{
    string[] parts = input.Split("=>");
    string contest = parts[0];
    string password = parts[1];
    string username = parts[2];
    int points = int.Parse(parts[3]);
    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!users.ContainsKey(username))
        {
            users[username] = new Dictionary<string, int>();
        }
        if (!users[username].ContainsKey(contest) || users[username][contest] < points)
        {
            users[username][contest] = points;
        }
    }
}
var bestCandidate = users.Select(user => new { Name = user.Key, TotalPoints = user.Value.Values.Sum() }).OrderByDescending(user => user.TotalPoints).First();
Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.TotalPoints} points.");
Console.WriteLine("Ranking: ");
foreach (var user in users.OrderBy(u => u.Key))
{
    Console.WriteLine(user.Key);
    foreach (var contest in user.Value.OrderByDescending(c => c.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}