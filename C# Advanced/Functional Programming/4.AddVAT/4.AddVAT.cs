Func<double, double> addingVAT = x => x * 1.20;
double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).Select(addingVAT).ToArray();
foreach (double number in numbers)
{
    Console.WriteLine($"{number:f2}");
}