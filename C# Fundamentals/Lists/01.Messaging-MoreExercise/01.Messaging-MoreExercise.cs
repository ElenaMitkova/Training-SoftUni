List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string text = Console.ReadLine();
for (int i = 0; i < numbers.Count; i++)
{
	int sum = 0;
	while (numbers[i] > 0)
	{
		sum += numbers[i] % 10;
		numbers[i] /= 10;
	}
	numbers[i] = sum;
}
string outputText = "";
for (int i = 0, j = 0;i < numbers.Count; i++, j++)
{
	if (numbers[j] >= text.Length)
	{
		numbers[j] = numbers[j] - text.Length;
		outputText += text[numbers[j]];
		text = text.Remove(numbers[j], 1);
	}
	else
	{
        outputText += text[numbers[j]];
        text = text.Remove(numbers[j], 1);
    }
}
Console.WriteLine(outputText);