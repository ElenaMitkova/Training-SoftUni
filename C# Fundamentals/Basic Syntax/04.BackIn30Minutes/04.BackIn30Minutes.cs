int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
minutes += 30;
if (minutes > 59)
{
    minutes -= 60;
    hour++;
}
if (hour > 23) hour -= 24;
if (minutes < 10) Console.WriteLine($"{hour}:0{minutes}");
else Console.WriteLine($"{hour}:{minutes}");