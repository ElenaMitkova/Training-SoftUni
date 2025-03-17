int counter = int.Parse(Console.ReadLine());
TopNumbers(counter);
static void TopNumbers(int counter)
{
    for (int i = 1; i <= counter; i++)
    {
        if(DivisibleBy8(i) && OneOddDigit(i))
        {
            Console.WriteLine(i);
        }
    }
}
static bool DivisibleBy8(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum % 8 == 0)
    {
        return true;
    }
    return false;
}
static bool OneOddDigit(int number)
{
    while (number > 0)
    {
        if (number % 10 % 2 == 1)
        {
            return true;
        }
        number /= 10;
    }
    return false;
}