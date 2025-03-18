int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string[,] matrix = new string[size[0], size[1]];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = input[col];
	}
}
string command;
while ((command = Console.ReadLine()) != "END")
{
	string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (arguments.Length != 5 || arguments[0] != "swap")
	{
        Console.WriteLine("Invalid input!");
		continue;
    }
    int r1 = int.Parse(arguments[1]), c1 = int.Parse(arguments[2]);
    int r2 = int.Parse(arguments[3]), c2 = int.Parse(arguments[4]);
    bool isValid = 0 <= r1 && r1 < matrix.GetLength(0) && 0 <= c1 && c1 < matrix.GetLength(1)
        && 0 <= r2 && r2 < matrix.GetLength(0) && 0 <= c2 && c2 < matrix.GetLength(1);
	if (!isValid)
	{
        Console.WriteLine("Invalid input!");
        continue;
    }
	string element = matrix[r1, c1];
	matrix[r1, c1] = matrix[r2, c2];
	matrix[r2, c2] = element;
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			if (col > 0)
			{
				Console.Write(' ');
			}
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
	}
}