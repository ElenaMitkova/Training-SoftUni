byte numberOfLines = byte.Parse(Console.ReadLine());
string maxModel = "";
double maxVolume = 0;
while (numberOfLines > 0)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (volume > maxVolume)
    {
        maxVolume = volume;
        maxModel = model;
    }
    numberOfLines--;
}
Console.WriteLine(maxModel);