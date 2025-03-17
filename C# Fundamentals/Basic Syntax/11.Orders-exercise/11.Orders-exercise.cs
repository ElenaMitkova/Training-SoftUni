int n = int.Parse(Console.ReadLine());
double total = 0.0;
while (n > 0)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int day = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    double expenses = day * capsulesCount * pricePerCapsule;
    total += expenses;
    Console.WriteLine($"The price for the coffee is: ${expenses:F2}");
    n--;
}
Console.WriteLine($"Total: ${total:F2}");