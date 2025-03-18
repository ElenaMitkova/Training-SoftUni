int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Func<int, int, int> minimal = (number, min) => (number < min) ? number : min;
int min = int.MaxValue;
for (int i = 0; i < numbers.Length; i++)
{
    min = minimal(numbers[i], min);
}
Console.WriteLine(min);