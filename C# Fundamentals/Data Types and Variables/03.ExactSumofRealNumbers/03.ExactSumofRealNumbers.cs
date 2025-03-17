byte countOfNumbers = byte.Parse(Console.ReadLine());
decimal sum = 0;
while (countOfNumbers > 0)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;
    countOfNumbers--;
}
Console.WriteLine(sum); 