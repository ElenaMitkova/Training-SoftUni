long x1 = long.Parse(Console.ReadLine());
long y1 = long.Parse(Console.ReadLine());
long x2 = long.Parse(Console.ReadLine());
long y2 = long.Parse(Console.ReadLine());
if (GetBigger(x1, y1) <= GetBigger(x2, y2))
{ 
    Console.WriteLine($"({x1}, {y1})");
    return;
}
Console.WriteLine($"({x2}, {y2})");
static long GetBigger(long x, long y)
{
    return Math.Max(x, y);
}