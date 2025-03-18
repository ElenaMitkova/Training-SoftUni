int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int row = 0; row < n; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        matrix[row,col] = input[col];
    }
}
int[,] directions = { { 2, -1 }, { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 }, { -1, -2 }, { 1, -2 } };
int counter = 0;
bool tryRemove = true;
while (tryRemove)
{
    int maxThreats = 0;
    int maxRow = -1;
    int maxCol = -1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] != 'K')
            {
                continue;
            }
            int currentThreats = 0;
            for (int k = 0; k < directions.GetLength(0); k++)
            {
                int row = i + directions[k, 0];
                if (row < 0 || row >= n)
                { 
                    continue; 
                }
                int col = j + directions[k, 1];
                if (col < 0 || col >= n)
                {
                    continue;
                }
                if (matrix[row, col] == 'K')
                {
                    currentThreats++;
                }
            }
            if (currentThreats > maxThreats)
            {
                maxThreats = currentThreats;
                maxRow = i;
                maxCol = j;
            }
        }
    }
    if (maxThreats > 0)
    {
        counter++;
        matrix[maxRow, maxCol] = '0';
    }
    else
    {
        tryRemove = false;
    }
}
Console.WriteLine(counter);