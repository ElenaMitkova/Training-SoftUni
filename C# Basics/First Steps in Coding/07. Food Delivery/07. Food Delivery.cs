int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());
double chickenPrice = chickenMenu * 10.35;
double fishPrice = fishMenu * 12.4;
double vegetarianPrice = vegetarianMenu * 8.15;
double sum = chickenPrice + fishPrice + vegetarianPrice;
double desert = sum * 0.2;
Console.WriteLine(sum + desert + 2.5);