int n = int.Parse(Console.ReadLine());
string[] directions = Console.ReadLine().Split();
char[,] map = new char[n, n];
(int row, int col) position = (-1, -1);
int allCoal = 0;
(int row, int col) end = (-1, -1);
for (int row = 0; row < n; row++)
{
    char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        map[row, col] = input[col];
        if (map[row, col] == 's')
        {
            position = (row, col);
        }
        else if (map[row, col] == 'c')
        {
            allCoal++;
        }
        else if (map[row, col] == 'e')
        {
            end = (row, col);
        }
    }
}
int coal = 0;
for (int i = 0; i < directions.Length; i++)
{
    (int r, int c) newIndex = position;
    if (directions[i] == "left" && position.col > 0)
    {
        newIndex = (position.row, position.col - 1);
    }
    else if (directions[i] == "right" && position.col < n - 1)
    {
        newIndex = (position.row, position.col + 1);
    }
    else if (directions[i] == "up" && position.row > 0)
    {
        newIndex = (position.row - 1, position.col);
    }
    else if (directions[i] == "down" && position.row < n - 1)
    {
        newIndex = (position.row + 1, position.col);
    }
    position = newIndex;
    if (map[position.row, position.col] == 'c')
    {
        coal++;
        map[position.row, position.col] = '*';
        if (coal == allCoal)
        {
            Console.WriteLine($"You collected all coals! ({position.row}, {position.col})");
            return;
        }
    }
    else if (position.row == end.row && position.col == end.col)
    {
        Console.WriteLine($"Game over! ({end.row}, {end.col})");
        return;
    }
}
Console.WriteLine($"{allCoal - coal} coals left. ({position.row}, {position.col})");