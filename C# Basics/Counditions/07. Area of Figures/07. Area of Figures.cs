string figure = Console.ReadLine();
double area = 0;
switch (figure)
{
	case "square":
		double side = double.Parse(Console.ReadLine());
		area = side * side;
		Console.WriteLine($"{area:f3}");
        break;
	case "rectangle":
		double firstSide = double.Parse(Console.ReadLine());
		double secondSide = double.Parse(Console.ReadLine());
		area = firstSide * secondSide;
        Console.WriteLine($"{area:f3}");
        break;
	case "circle":
		double radius = double.Parse(Console.ReadLine());
		area = Math.PI*radius*radius;
        Console.WriteLine($"{area:f3}");
        break;
	case "triangle":
		double triangleSide = double.Parse(Console.ReadLine());
		double height = double.Parse(Console.ReadLine());
		area = (triangleSide * height) / 2;
		Console.WriteLine($"{area:f3}");
        break;
}