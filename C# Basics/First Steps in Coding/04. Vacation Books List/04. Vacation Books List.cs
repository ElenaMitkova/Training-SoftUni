int numberOfPages = int.Parse(Console.ReadLine());
int pagesFor1Hour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int neededHours = numberOfPages / pagesFor1Hour;
int hours = neededHours / days;
Console.WriteLine(hours);