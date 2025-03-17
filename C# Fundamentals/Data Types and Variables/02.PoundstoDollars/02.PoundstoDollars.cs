decimal pounds = decimal.Parse(Console.ReadLine());
double poundsToDollars = 1.31;
decimal dollars = pounds * (decimal)poundsToDollars;
Console.WriteLine($"{dollars:F3}");