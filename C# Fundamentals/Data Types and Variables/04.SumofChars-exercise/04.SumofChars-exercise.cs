byte numberOfLines = byte.Parse(Console.ReadLine());
int sum = 0;
while (numberOfLines > 0)
{
    char symbol = char.Parse(Console.ReadLine());
    sum += symbol;
    numberOfLines--;
}
Console.WriteLine($"The sum equals: {sum}");