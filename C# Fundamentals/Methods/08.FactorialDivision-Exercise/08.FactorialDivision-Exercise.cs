long firstNumber = long.Parse(Console.ReadLine());
long secondNumber = long.Parse(Console.ReadLine());
Console.WriteLine($"{Factorial(firstNumber)/ Factorial(secondNumber):F2}");
static double Factorial(long number)
{
    double result = 1;
    for (long i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}