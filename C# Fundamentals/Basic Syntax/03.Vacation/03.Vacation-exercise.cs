int countPeople = int.Parse(Console.ReadLine());
string typePeople = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();
double total = 0.0;
switch (typePeople)
{
	case "Students":
		if (dayOfTheWeek == "Friday") total = countPeople * 8.45;
		else if (dayOfTheWeek == "Saturday") total = countPeople * 9.8;
		else total = countPeople * 10.46;
        if (countPeople >= 30) total -= total * 0.15;
		break;
	case "Business":
		if (dayOfTheWeek == "Friday") total = countPeople * 10.9;
        else if (dayOfTheWeek == "Saturday") total = countPeople * 15.6;
        else total = countPeople * 16;
        if (countPeople >= 100) total -= total/10;
        break;
    case "Regular":
        if (dayOfTheWeek == "Friday") total = countPeople * 15;
        else if (dayOfTheWeek == "Saturday") total = countPeople * 20;
        else total = countPeople * 22.5;
        if (countPeople >= 10 && countPeople <= 20) total -= total * 0.05;
        break;
}
Console.WriteLine($"Total price: {total:F2}");