double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
Dictionary<double, int> numbersCount = new Dictionary<double, int>();
for (int i = 0; i < numbers.Length; i++)
{
	if (!numbersCount.ContainsKey(numbers[i]))
	{
		numbersCount[numbers[i]] = 0;
	}
	numbersCount[numbers[i]]++;
}
foreach (KeyValuePair<double, int> number in numbersCount)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}