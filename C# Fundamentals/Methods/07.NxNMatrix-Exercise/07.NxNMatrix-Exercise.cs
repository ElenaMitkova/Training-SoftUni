int number = int.Parse(Console.ReadLine());
PrintMatrix(number);
static void PrintMatrix(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(number);
        for (int j = 0; j < number - 1; j++)
        {
            Console.Write(" " + number);
        }
        Console.WriteLine();
    }
}