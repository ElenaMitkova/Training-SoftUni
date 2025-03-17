int number = int.Parse(Console.ReadLine());
PrintTriangleTop(number);
PrintTriangleBottom(number);
static void PrintTriangleTop(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(1);
        for (int j = 2; j <= i; j++)
        {
            Console.Write(" " + j);
        }
        Console.WriteLine();
    }
}
static void PrintTriangleBottom(int number)
{
    for (int i = number - 1; i >= 1; i--)
    {
        Console.Write(1);
        for (int j = 2; j <= i; j++)
        {
            Console.Write(" " + j);
        }
        Console.WriteLine();
    }
}