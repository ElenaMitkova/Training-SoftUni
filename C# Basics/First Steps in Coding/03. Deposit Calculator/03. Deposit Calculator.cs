double depositSum = double.Parse(Console.ReadLine());
int deadLine = int.Parse(Console.ReadLine());
double yearDepositPercentage = double.Parse(Console.ReadLine());
double sum = depositSum + deadLine * ((depositSum * (yearDepositPercentage / 100)) / 12);
Console.WriteLine(sum);