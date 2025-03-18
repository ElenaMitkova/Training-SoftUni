List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
int counter = numbers.Count / 2;
for (int i = 0; i < counter; i++)
{
    numbers[i] += numbers[numbers.Count - 1];
    numbers.RemoveAt(numbers.Count - 1);
}
Console.WriteLine(string.Join(' ', numbers));