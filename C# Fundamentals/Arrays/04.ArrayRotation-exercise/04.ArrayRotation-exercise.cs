﻿int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());
for (int i = 0; i < rotations; i++)
{
    int temp = numbers[0];
    for (int j = 0; j < numbers.Length - 1; j++)
    {
        numbers[j] = numbers[j + 1];
    }
    numbers[numbers.Length - 1] = temp;
}
Console.WriteLine(string.Join(" ",numbers));