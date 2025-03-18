HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();
int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = lengths[0];
int m = lengths[1];
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    firstSet.Add(number);
}
for (int i = 0; i < m; i++)
{
    int number = int.Parse(Console.ReadLine());
    secondSet.Add(number);
}
foreach (int number in firstSet)
{
    if (!secondSet.Contains(number))
    {
        firstSet.Remove(number);
    }
}
Console.WriteLine(string.Join(' ', firstSet));