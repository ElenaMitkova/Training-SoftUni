﻿string beverage = Console.ReadLine();
string city = Console.ReadLine();
double packs = double.Parse(Console.ReadLine());
switch (beverage)
{
	case "coffee":
		switch (city)
		{
			case "Sofia":
                Console.WriteLine(packs * 0.5);
                break;
			case "Plovdiv":
                Console.WriteLine(packs * 0.4);
                break;
			case "Varna":
                Console.WriteLine(packs * 0.45);
                break;
		}
        break;
	case "water":
        switch (city)
        {
            case "Sofia":
                Console.WriteLine(packs * 0.8);
                break;
            case "Plovdiv":
                Console.WriteLine(packs * 0.7);
                break;
            case "Varna":
                Console.WriteLine(packs * 0.7);
                break;
        }
        break;
    case "beer":
        switch (city)
        {
            case "Sofia":
                Console.WriteLine(packs * 1.2);
                break;
            case "Plovdiv":
                Console.WriteLine(packs * 1.15);
                break;
            case "Varna":
                Console.WriteLine(packs * 1.1);
                break;
        }
        break;
    case "sweets":
        switch (city)
        {
            case "Sofia":
                Console.WriteLine(packs * 1.45);
                break;
            case "Plovdiv":
                Console.WriteLine(packs * 1.3);
                break;
            case "Varna":
                Console.WriteLine(packs * 1.35);
                break;
        }
        break;
    case "peanuts":
        switch (city)
        {
            case "Sofia":
                Console.WriteLine(packs * 1.6);
                break;
            case "Plovdiv":
                Console.WriteLine(packs * 1.5);
                break;
            case "Varna":
                Console.WriteLine(packs * 1.55);
                break;
        }
        break;
}