int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];
for (int i = 0; i < rows; i++)
{
    jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}
string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split();
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);
    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        switch (arguments[0])
        {
            case "Add":
                jaggedArray[row][col] += value;
                break;
            case "Subtract":
                jaggedArray[row][col] -= value;
                break;
        }
    }
}
foreach (int[] array in jaggedArray)
{
    Console.WriteLine(string.Join(' ', array));
}