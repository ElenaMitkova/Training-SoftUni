int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
minutes += 15;
if (minutes > 59)
{
    hours += 1;
    minutes -= 60;
}
if (hours > 23) hours -= 24;
if (minutes < 10) Console.WriteLine($"{hours}:0{minutes}");
else Console.WriteLine($"{hours}:{minutes}");