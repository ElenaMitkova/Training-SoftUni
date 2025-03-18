int n = int.Parse(Console.ReadLine());
int[] predicates = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<int> result = new List<int>();
for (int i = 1; i <= n; i++)
{
    bool isPredicated = true;
    for (int j = 0; j < predicates.Length; j++)
    {
        Predicate<int> predicate = x => x % predicates[j] == 0;
        if (!predicate(i))
        {
            isPredicated = false;
            break;
        }
    }
    if (isPredicated)
    {
        result.Add(i);
    }
}
Console.WriteLine(string.Join(' ', result));