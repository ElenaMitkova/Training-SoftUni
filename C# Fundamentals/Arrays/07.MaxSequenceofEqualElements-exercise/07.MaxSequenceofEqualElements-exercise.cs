int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int max = 1;
int integer = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] == numbers[i])
        {
            count++;
        }
        else
        {
            break;
        }
    }
    if (count > max)
    {
        max = count;
        integer = numbers[i];
    }
}
for (int i = 0; i < max - 1; i++)
{
    Console.Write($"{integer} ");
}
Console.WriteLine(integer);