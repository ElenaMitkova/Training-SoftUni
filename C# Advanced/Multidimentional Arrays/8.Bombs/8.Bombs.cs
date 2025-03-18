int n = int.Parse(Console.ReadLine());
int[,] map = new int[n, n];
for (int row = 0; row < n; row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        map[row, col] = numbers[col];
    }
}
string[] bombs = Console.ReadLine().Split();
for (int index = 0; index < bombs.Length; index++)
{
    int[] indexes = bombs[index].Split(',').Select(int.Parse).ToArray();
    int row = indexes[0];
    int col = indexes[1];
    int damage = map[row, col];
    if (damage <= 0)
    {
        continue;
    }
    int rowIterStart = Math.Max(0, row - 1);
    int rowIterEnd = Math.Min(n - 1, row + 1);
    int colIterStart = Math.Max(0, col - 1);
    int colIterEnd = Math.Min(n - 1, col + 1);
    for (int i = rowIterStart; i <= rowIterEnd; i++)
    {
        for (int j = colIterStart; j <= colIterEnd; j++)
        {
            if (map[i, j] > 0)
            {
                map[i, j] -= damage;
            }
        }
    }
}
int cells = 0;
int sum = 0;
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (map[row, col] > 0)
        {
            cells++;
            sum += map[row, col];
        }
    }
}
Console.WriteLine($"Alive cells: {cells}");
Console.WriteLine($"Sum: {sum}");
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (col > 0)
        {
            Console.Write(' ');
        }
        Console.Write(map[row, col]);
    }
    Console.WriteLine();
}