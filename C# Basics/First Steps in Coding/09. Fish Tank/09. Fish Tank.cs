int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;
double litres = (length * width * height) / 1000.0;
double result = litres * (1 - percent);
Console.WriteLine(result);