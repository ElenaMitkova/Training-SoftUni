string type = Console.ReadLine();
if (type == "int")
{
    Console.WriteLine(GetInt());
}
else if (type == "real")
{
    Console.WriteLine($"{GetReal():F2}");
}
else if (type == "string")
{
    Console.WriteLine($"${GetString()}$");
}
static int GetInt()
{
    int number = int.Parse(Console.ReadLine());
    return number * 2;
}
static double GetReal()
{
    double number = double.Parse(Console.ReadLine());
    return number * 1.5;
}
static string GetString()
{
    string input = Console.ReadLine();
    return input;
}