List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
for (int i = 0;i < numbers.Count;i++)
{
    for (int j = 0; j < numbers.Count - 1; j++)
    {
        if (numbers[j] == numbers[j + 1])
        {
            numbers[j] *= 2;
            numbers.RemoveAt(j + 1);
        }
    }
}
Console.WriteLine(string.Join(' ', numbers));