int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int firstDiagonalSum = 0;
int secondDiagonalSum = 0;
for (int row = 0; row < n; row++)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = array[col];
        if (row == col)
        {
            firstDiagonalSum += matrix[row, col];
        }
        if (col == n - 1 - row)
        {
            secondDiagonalSum += matrix[row, col];
        }
    }
}
Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));