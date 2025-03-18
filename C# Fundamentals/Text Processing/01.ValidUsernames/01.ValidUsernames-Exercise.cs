string[] usernames = Console.ReadLine().Split(", ");
for (int i = 0; i < usernames.Length; i++)
{
    bool all = usernames[i].All(user => char.IsLetterOrDigit(user) || user == '-' || user == '_');
	if (all && usernames[i].Length > 3 && usernames[i].Length < 16)
	{
		Console.WriteLine(usernames[i]);
	}
}