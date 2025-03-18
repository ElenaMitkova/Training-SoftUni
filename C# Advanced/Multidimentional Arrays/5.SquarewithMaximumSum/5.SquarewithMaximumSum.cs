int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = array[j];
    }
}
int sum = int.MinValue;
(int, int) index = (0, 0);
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int current = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
        if (current > sum)
        {
            sum = current;
            index = (i, j);
        }
    }
}
Console.WriteLine($"{matrix[index.Item1, index.Item2]} {matrix[index.Item1, index.Item2 + 1]}");
Console.WriteLine($"{matrix[index.Item1 + 1, index.Item2]} {matrix[index.Item1 + 1, index.Item2 + 1]}");
Console.WriteLine(sum);