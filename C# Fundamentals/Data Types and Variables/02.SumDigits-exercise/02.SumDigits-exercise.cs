int number = int.Parse(Console.ReadLine());
byte sum = 0;
while (number > 0)
{
    int divide = number % 10;
    sum += (byte)divide;
    number /= 10;
}
Console.WriteLine(sum);