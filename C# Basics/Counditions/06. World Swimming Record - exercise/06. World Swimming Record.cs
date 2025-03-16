double recordInSeconds = double.Parse(Console.ReadLine());
double meters =  double.Parse(Console.ReadLine());
double secondsForOneMeter = double.Parse(Console.ReadLine());
double hisSends = meters * secondsForOneMeter;
double plusSeconds = Math.Floor(meters / 15) * 12.5;
double totalSeconds = plusSeconds + hisSends;
if (totalSeconds >= recordInSeconds) Console.WriteLine($"No, he failed! He was {totalSeconds-recordInSeconds:f2} seconds slower.");
else Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");