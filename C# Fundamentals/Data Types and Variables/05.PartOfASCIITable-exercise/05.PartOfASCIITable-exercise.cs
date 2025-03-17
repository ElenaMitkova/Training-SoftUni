byte start = byte.Parse(Console.ReadLine());
byte end = byte.Parse(Console.ReadLine());
for (int i = start; i <= end; i++)
{
    Console.Write($"{(char)i} ");
}