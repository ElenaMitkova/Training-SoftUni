int length = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();
Predicate<string> predicate = x => x.Length <= length;
foreach (string name in names)
{
    if (predicate(name))
    {
        Console.WriteLine(name);
    }
}