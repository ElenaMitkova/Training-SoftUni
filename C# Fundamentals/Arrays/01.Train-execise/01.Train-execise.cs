int numberCounter = int.Parse(Console.ReadLine());
int[] train = new int[numberCounter];
int sum = 0;
for (int i = 0; i < numberCounter; i++)
{
    train[i] = int.Parse(Console.ReadLine());
    sum += train[i];
}
Console.WriteLine(string.Join(" ", train));
Console.WriteLine(sum);