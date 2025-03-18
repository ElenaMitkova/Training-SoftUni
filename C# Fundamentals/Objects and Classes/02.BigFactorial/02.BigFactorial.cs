using System.Numerics;
int number = int.Parse(Console.ReadLine());
BigInteger bigInteger = 1;
for (int i = 1; i <= number; i++)
{
    bigInteger *= i;
}
Console.WriteLine(bigInteger);