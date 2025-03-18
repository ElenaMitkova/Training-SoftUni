Dictionary<string, string> contestsMap = new Dictionary<string, string>();
Dictionary<string, Dictionary<string, int>> usersContests = new Dictionary<string, Dictionary<string, int>>();
string command =string.Empty;
while ((command = Console.ReadLine()) != "end of contests")
{
    string[] arguments = command.Split(':');
    string contest = arguments[0];
    string password = arguments[1];
    if (!contestsMap.ContainsKey(contest))
    {
        contestsMap[contest] = password;
    }
}
while ((command = Console.ReadLine()) != "end of submissions")
{
    string[] arguments = command.Split("=>");
    string contest = arguments[0];
    string password = arguments[1];
    string user = arguments[2];
    int points = int.Parse(arguments[3]);
    if (contestsMap.ContainsKey(contest) && password == contestsMap[contest])
    {
        if (!usersContests.ContainsKey(user))
        {
            usersContests[user] = new Dictionary<string, int>();
        }
        if (!usersContests[user].ContainsKey(contest))
        {
            usersContests[user][contest] = 0;
        }
        if (usersContests[user][contest] < points)
        {
            usersContests[user][contest] = points;
        }
    }
}
string bestUser = string.Empty;
int maxScore = 0;
foreach ((string user, Dictionary<string, int> contests) in usersContests)
{
    int sumPoints = contests.Sum(x => x.Value);
    if (sumPoints > maxScore)
    {
        maxScore = sumPoints;
        bestUser = user;
    }
}
Console.WriteLine($"Best candidate is {bestUser} with total {maxScore} points.");
Console.WriteLine("Ranking:");
foreach ((string user, Dictionary<string, int> contests) in usersContests.OrderBy(x => x.Key))
{
    Console.WriteLine(user);
    foreach ((string contest, int points) in contests.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest} -> {points}");
    }
}