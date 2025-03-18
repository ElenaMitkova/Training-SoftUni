int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}
int maxSum = int.MinValue;
(int row, int col) index = (-1, -1);
for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            index = (row, col);
        }
    }
}
Console.WriteLine($"Sum = {maxSum}");
Console.WriteLine($"{matrix[index.row, index.col]} {matrix[index.row, index.col + 1]} {matrix[index.row, index.col + 2]}");
Console.WriteLine($"{matrix[index.row + 1, index.col]} {matrix[index.row + 1, index.col + 1]} {matrix[index.row + 1, index.col + 2]}");
Console.WriteLine($"{matrix[index.row + 2, index.col]} {matrix[index.row + 2, index.col + 1]} {matrix[index.row + 2, index.col + 2]}");