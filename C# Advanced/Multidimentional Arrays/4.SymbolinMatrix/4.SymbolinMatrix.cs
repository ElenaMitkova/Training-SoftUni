int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    string text = Console.ReadLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = text[j];
    }
}
char searched = char.Parse(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == searched)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{searched} does not occur in the matrix");