SortedSet<string> chemicals = new SortedSet<string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split();
    for (int j = 0; j < arguments.Length; j++)
    {
        chemicals.Add(arguments[j]);
    }
}
Console.WriteLine(string.Join(' ', chemicals));