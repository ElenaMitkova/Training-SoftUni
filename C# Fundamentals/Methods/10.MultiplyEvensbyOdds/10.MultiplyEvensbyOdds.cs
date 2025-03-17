int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(GetMultipleOfEvenAndOdds(number));
static int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        if(number % 10 % 2 == 0)
        {
            sum += number % 10;
        }
        number /= 10;
    }
    return sum;
}
static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        if (number % 10 % 2 == 1)
        {
            sum += number % 10;
        }
        number /= 10;
    }
    return sum;
}
static int GetMultipleOfEvenAndOdds(int number)
{ 
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}