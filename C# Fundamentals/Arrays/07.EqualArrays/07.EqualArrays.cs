int[] numbersLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numbersSecondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;
if (numbersLine.Length < numbersSecondLine.Length)
{
    for (int i = 0; i < numbersLine.Length; i++)
    {
        if (numbersLine[i] == numbersSecondLine[i]) sum += numbersLine[i];
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            return;
        }
    }
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
else
{
    for (int i = 0; i < numbersSecondLine.Length; i++)
    {
        if (numbersSecondLine[i] == numbersLine[i]) sum += numbersSecondLine[i];
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            return;
        }
    }
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}