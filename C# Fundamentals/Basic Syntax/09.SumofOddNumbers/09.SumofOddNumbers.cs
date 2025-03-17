int n = int.Parse(Console.ReadLine());
int sum = 0;
int number = 1;
for (int i = 1; i <= n; )
{
    if (number % 2 == 1)
    {
        Console.WriteLine(number);
        sum += number;
        number++;   
        i++;
    }
    else number++;
}
Console.WriteLine($"Sum: {sum}");