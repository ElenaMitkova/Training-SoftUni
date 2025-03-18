SortedDictionary<int, int> countNumbers = new SortedDictionary<int, int>();
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < array.Length; i++)
{
	if (countNumbers.ContainsKey(array[i]))
	{
		countNumbers[array[i]]++;
	}
	else
	{
		countNumbers.Add(array[i], 1);
	}
}
foreach (var number in countNumbers)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}