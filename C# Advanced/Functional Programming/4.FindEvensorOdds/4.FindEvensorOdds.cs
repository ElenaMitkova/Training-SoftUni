Dictionary<string, Predicate<int>> numberByRange = new Dictionary<string, Predicate<int>>()
{
    ["odd"] = x => x % 2 != 0,
    ["even"] = x => x % 2 == 0
};
List<int> result = new List<int>();
int[] ranges = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string range = Console.ReadLine();
for (int i = ranges[0]; i <= ranges[1]; i++)
{
    if (numberByRange[range](i))
    {
        result.Add(i);
    }
}
Console.WriteLine(string.Join(' ', result));