int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int i = 0; i < size[0]; i++)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = array[j];
    }
}
for (int i = 0; i < size[1]; i++)
{
    int sum = 0;
    for (int j = 0; j < size[0]; j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine(sum);
}