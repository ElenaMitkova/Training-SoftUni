HashSet<string> usernames = new HashSet<string>();
Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();
Dictionary<string, HashSet<string>> following = new Dictionary<string, HashSet<string>>();
string command;
while ((command = Console.ReadLine()) != "Statistics")
{
    string[] arguments = command.Split();
    string user = arguments[0];
    if (arguments[1] == "joined" && !usernames.Contains(user))
    {
        usernames.Add(user);
        followers[user] = new HashSet<string>();
        following[user] = new HashSet<string>();
    }
    else
    {
        string followed = arguments[2];
        if (usernames.Contains(followed) && usernames.Contains(user) && followed != user && !followers[followed].Contains(user))
        {
            followers[followed].Add(user);
            following[user].Add(followed);
        }
    }
}
Console.WriteLine($"The V-Logger has a total of {usernames.Count} vloggers in its logs.");
int possition = 0;
foreach (string user in usernames.OrderByDescending(x => followers[x].Count).ThenBy(x => following[x].Count))
{
    Console.WriteLine($"{++possition}. {user} : {followers[user].Count} followers, {following[user].Count} following");
    if (possition == 1)
    {
        foreach (string follower in followers[user].OrderBy(x => x))
        {
            Console.WriteLine($"*  {follower}");
        }
    }
}