string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int dayOfTheWeek = int.Parse(Console.ReadLine());
if (dayOfTheWeek > 0 && dayOfTheWeek < 8) Console.WriteLine(daysOfTheWeek[dayOfTheWeek - 1]);
else Console.WriteLine("Invalid day!");