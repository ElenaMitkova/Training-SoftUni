Dictionary<char, (int, int)> playerMoves = new()
{
    ['U'] = (-1, 0),
    ['R'] = (0, 1),
    ['D'] = (1, 0),
    ['L'] = (0, -1)
};
int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];
(int row, int col) playerPos = (-1, -1);
Queue<(int, int)> bunnies = new();
for (int i = 0; i < rows; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = line[j];
        if (line[j] == 'P')
        {
            playerPos = (i, j);
        }
        else if (line[j] == 'B')
        {
            bunnies.Enqueue((i, j));
        }
    }
}
string commands = Console.ReadLine();
bool isDead = false;
bool isOutside = false;
foreach (char command in commands)
{
    matrix[playerPos.row, playerPos.col] = '.';
    (int nextRow, int nextCol) = (playerPos.row + playerMoves[command].Item1, playerPos.col + playerMoves[command].Item2);
    if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
    {
        isOutside = true;
    }
    else
    {
        playerPos = (nextRow, nextCol);
        if (matrix[nextRow, nextCol] == 'B')
        {
            isDead = true;
        }
        else
        {
            matrix[nextRow, nextCol] = 'P';
        }
    }
    int bunniesCount = bunnies.Count;
    for (int i = 0; i < bunniesCount; i++)
    {
        (int bunnyRow, int bunnyCol) = bunnies.Dequeue();
        int[] directions = { 0, 1, 0, -1, 0 };
        for (int j = 0; j < 4; j++)
        {
            int newRow = bunnyRow + directions[j];
            int newCol = bunnyCol + directions[j + 1];
            if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
            {
                if (matrix[newRow, newCol] == 'P')
                {
                    isDead = true;
                }
                if (matrix[newRow, newCol] != 'B')
                {
                    matrix[newRow, newCol] = 'B';
                    bunnies.Enqueue((newRow, newCol));
                }
            }
        }
    }
    if (isDead || isOutside)
    {
        break;
    }
}
for (int i = 0; i < rows; i++)
{
    Console.WriteLine(new string(matrix.Cast<char>().Skip(i * cols).Take(cols).ToArray()));
}
Console.WriteLine(isOutside ? $"won: {playerPos.row} {playerPos.col}" : $"dead: {playerPos.row} {playerPos.col}");