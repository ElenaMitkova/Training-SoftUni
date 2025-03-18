int n = int.Parse(Console.ReadLine());
int[][] jagged = new int[n][];
for (int row = 0; row < jagged.Length; row++)
{
    jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}
for (int row = 0; row < jagged.Length - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        for (int i = row; i <= row + 1; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] *= 2;
            }
        }
    }
    else
    {
        for (int i = row; i <= row + 1; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] /= 2;
            }
        }
    }
}
string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);
    if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length) ;
    else
    {
        if (arguments[0] == "Add")
        {
            jagged[row][col] += value;
        }
        else if (arguments[0] == "Subtract")
        {
            jagged[row][col] -= value;
        }
    }
}
foreach (int[] array in jagged)
{
    Console.WriteLine(string.Join(' ', array));
}