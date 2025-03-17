﻿string typeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int price = 0;
if (age < 0 || age > 122) Console.WriteLine("Error!");
else
{
	switch (typeOfDay)
	{
		case "Weekday":
			if (age >= 0 && age <= 18) price = 12;
			else if (age > 18 && age <= 64) price = 18;
			else price = 12;
			break;
        case "Weekend":
            if (age >= 0 && age <= 18) price = 15;
            else if (age > 18 && age <= 64) price = 20;
            else price = 15;
            break;
        case "Holiday":
            if (age >= 0 && age <= 18) price = 5;
            else if (age > 18 && age <= 64) price = 12;
            else price = 10;
            break;
    }
    Console.WriteLine($"{price}$");
}