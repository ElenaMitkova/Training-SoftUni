Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int count = numbers.Count();
while (count > 0)
{
    int number = numbers.Dequeue();
    if (number % 2 == 0)
    {
        numbers.Enqueue(number);
    }
    count--;
}
Console.WriteLine(string.Join(", ", numbers));