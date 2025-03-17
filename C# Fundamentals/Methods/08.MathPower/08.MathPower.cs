double baseNumber = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
Console.WriteLine(GetPower(baseNumber,power));
static double GetPower(double baseNumber, int power)
{
    double output = 1;
    for (int i = 0; i < power; i++)
    {
        output *= baseNumber;
    }
    return output;
}