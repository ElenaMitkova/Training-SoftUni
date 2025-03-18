int n = int.Parse(Console.ReadLine());
long[][] jagged = new long[n][];
jagged[0] = new long[1];
jagged[0][0] = 1;
for (int i = 1; i < n; i++)
{
    jagged[i] = new long[i + 1]; 
    jagged[i][0] = 1;
    jagged[i][jagged[i].Length - 1] = 1;
    for (int j = 1; j < jagged[i].Length - 1; j++)
    {
        jagged[i][j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
    }
}
foreach (long[] row in jagged)
{
    Console.WriteLine(string.Join(' ', row));
}