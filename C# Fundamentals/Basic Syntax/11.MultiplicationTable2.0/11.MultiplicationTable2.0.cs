int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number2 > 10)
{
    Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
}
else
{
    for (int i = number2; i <= 10; i++)
    {
        Console.WriteLine($"{number1} X {i} = {number1 * i}");
    }
}