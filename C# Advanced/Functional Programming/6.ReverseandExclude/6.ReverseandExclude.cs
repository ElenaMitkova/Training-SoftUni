int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(' ', SearchingNumbers(numbers, x => x % n != 0)));
List<int> SearchingNumbers(int[] numbers, Predicate<int> condition)
{
    List<int> result = new List<int>();
	for (int i = numbers.Length - 1; i >= 0; i--)
	{
		if (condition(numbers[i]))
		{
			result.Add(numbers[i]);
		}
	}
	return result;
}