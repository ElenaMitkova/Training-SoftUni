int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int i = 0; i < size[0]; i++)
{
    int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = array[j];
    }
}
int sum = 0;
foreach (int number in matrix)
{
    sum += number;
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);