Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
string line;
while ((line = Console.ReadLine().Trim()) != "no more time")
{
    var parts = line.Split(" -> ");
    string username = parts[0];
    string contest = parts[1];
    int points = int.Parse(parts[2]);
    if (!submissions.ContainsKey(contest))
    {
        submissions[contest] = new Dictionary<string, int>();
    }
    if (!submissions[contest].ContainsKey(username))
    {
        submissions[contest][username] = points;
    }
    else
    {
        submissions[contest][username] = Math.Max(submissions[contest][username], points);
    }
    if (!users.ContainsKey(username))
    {
        users[username] = new Dictionary<string, int>();
    }
    if (!users[username].ContainsKey(contest))
    {
        users[username][contest] = points;
    }
    else
    {
        users[username][contest] = Math.Max(users[username][contest], points);
    }
}
foreach (var contest in submissions)
{
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    var sortedParticipants = contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
    int rank = 1;
    foreach (var participant in sortedParticipants)
    {
        Console.WriteLine($"{rank}. {participant.Key} <::> {participant.Value}");
        rank++;
    }
}
Console.WriteLine("Individual standings:");
var sortedUsers = users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key).ToList();
int userRank = 1;
foreach (var user in sortedUsers)
{
    int totalPoints = user.Value.Values.Sum();
    Console.WriteLine($"{userRank}. {user.Key} -> {totalPoints}");
    userRank++;
}