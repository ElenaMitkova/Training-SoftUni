string flower = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double total = 0;
switch (flower)
{
	case "Roses":
		total = flowerCount * 5;
        if (flowerCount > 80)
        {
            total = total - (total * 0.1);
        }
		break;
	case "Dahlias":
        total = flowerCount * 3.8;
        if (flowerCount > 90)
        {
            total = total - (total * 0.15);
        }
        break;
    case "Tulips":
        total = flowerCount * 2.8;
        if (flowerCount > 80)
        {
            total = total - (total * 0.15);
        }
        break;
    case "Narcissus":
        total = flowerCount * 3;
        if (flowerCount < 120)
        {
            total = total + (total * 0.15);
        }
        break;
    case "Gladiolus":
        total = flowerCount * 2.5;
        if (flowerCount < 80)
        {
            total = total + (total * 0.2);
        }
        break;
}
if (budget >= total) Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - total:f2} leva left.");
else Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
