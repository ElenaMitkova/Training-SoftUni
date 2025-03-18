﻿int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = array[j];
        if (i == j)
        {
            sum += matrix[i, j];
        }
    }
}
Console.WriteLine(sum);