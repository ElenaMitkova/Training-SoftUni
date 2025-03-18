string commands;
double sum = 0.0;
double total = 0.0;
while ((commands = Console.ReadLine()) is not "special" and not "regular")
{
    if (double.Parse(commands) <= 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }
    sum += double.Parse(commands);
    total += double.Parse(commands);
}
double taxes = total * 0.2;
total += taxes;
if (commands == "special")
{
    total -= total * 0.1;
}
if (total <= 0.0)
{
    Console.WriteLine("Invalid order!");
    return;
}
Console.WriteLine("Congratulations you've just bought a new computer!");
Console.WriteLine($"Price without taxes: {sum:F2}$");
Console.WriteLine($"Taxes: {taxes:F2}$");
Console.WriteLine("-----------");
Console.WriteLine($"Total price: {total:F2}$");