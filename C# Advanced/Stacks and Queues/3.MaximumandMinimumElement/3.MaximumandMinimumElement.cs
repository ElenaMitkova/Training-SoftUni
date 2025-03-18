int n = int.Parse(Console.ReadLine());
Stack<int> numbers = new Stack<int>();
for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	switch (input[0])
	{
		case 1:
			numbers.Push(input[1]);
			break;
		case 2:
            if (numbers.Count > 0)
            {
                numbers.Pop();
            }
			break;
		case 3:
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Max());
            }
            break;
        case 4:
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            break;
    }
}
if (numbers.Count > 0)
{
    Console.WriteLine(string.Join(", ", numbers));
}