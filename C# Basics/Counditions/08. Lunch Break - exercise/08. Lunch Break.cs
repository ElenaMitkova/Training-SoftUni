string series = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchBreak = breakDuration * 0.125;
double restBreak = breakDuration * 0.25;

double totalTime = Math.Floor(breakDuration - (lunchBreak + restBreak));

if (totalTime >= episodeDuration) Console.WriteLine($"You have enough time to watch {series} and left with {totalTime - episodeDuration} minutes free time.");
else Console.WriteLine($"You don't have enough time to watch {series}, you need {episodeDuration-totalTime} more minutes.");