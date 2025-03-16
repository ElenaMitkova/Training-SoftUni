int firstSeconds = int.Parse(Console.ReadLine());
int secondSeconds = int.Parse(Console.ReadLine());
int thirdSeconds = int.Parse(Console.ReadLine());
int summary = firstSeconds + secondSeconds + thirdSeconds;
int minutes = summary / 60;
int seconds = summary % 60;
if (seconds < 10) Console.WriteLine($"{minutes}:0{seconds}");
else Console.WriteLine($"{minutes}:{seconds}");