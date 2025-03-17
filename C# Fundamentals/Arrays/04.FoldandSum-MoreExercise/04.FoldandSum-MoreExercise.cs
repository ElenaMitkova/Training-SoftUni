int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int k = numbers.Length / 2;
int[]first = new int[k];
int [] second = new int[k];
int countFirst = 0;
int countSecond = 0;
for (int i = k/2 - 1; i >= 0; i--)
{
    first[countFirst] = numbers[i];
    countFirst++;
}
for (int i = numbers.Length - 1;i >= numbers.Length - k / 2; i--)
{
    first[countFirst] = numbers[i];
    countFirst++;
}
for (int i = k - k/2;i < numbers.Length - k/2; i++)
{
    second[countSecond] = numbers[i];
    countSecond++;
}
for (int i = 0; i < first.Length; i++)
{
    Console.Write($"{first[i] + second[i]} ");
}