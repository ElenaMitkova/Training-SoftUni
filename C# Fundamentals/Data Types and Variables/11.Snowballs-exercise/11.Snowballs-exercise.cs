using System.Numerics;
int numberOfBalls = int.Parse(Console.ReadLine());
int maxSnowballSnow = 0;
int maxSnowballTime = 0;
int maxSnowballQuality = 0;
BigInteger maxSnowballValue = 0;
while (numberOfBalls > 0)
{
    int snowballShow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
    BigInteger snowballValue = BigInteger.Pow(snowballShow / snowballTime, snowballQuality);
    if (snowballValue > maxSnowballValue)
    {
        maxSnowballSnow = snowballShow;
        maxSnowballTime = snowballTime;
        maxSnowballQuality = snowballQuality;
        maxSnowballValue = snowballValue;
    }
    numberOfBalls--;
}
Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");