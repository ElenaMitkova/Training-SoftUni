int powerN = int.Parse(Console.ReadLine());
int distanceM = int.Parse(Console.ReadLine());
int factorY = int.Parse(Console.ReadLine());
int count = 0;
double division = powerN / 2.0;
while (powerN >= distanceM)
{
    powerN -= distanceM;
    count++;
    if (powerN == division && factorY != 0) powerN /= factorY;
}
Console.WriteLine(powerN);
Console.WriteLine(count);