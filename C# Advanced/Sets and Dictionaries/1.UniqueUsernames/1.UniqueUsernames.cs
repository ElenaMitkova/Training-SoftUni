HashSet<string> usernames = new HashSet<string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string username = Console.ReadLine();
    usernames.Add(username);
}
foreach (string username in usernames)
{
    Console.WriteLine(username);
}