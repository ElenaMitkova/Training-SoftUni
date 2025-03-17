double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
Console.WriteLine(GetArea(width,height));
static double GetArea(double width, double height)
{
    return width * height;
}