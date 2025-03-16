string fruit = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double total = 0.0;
switch (dayOfTheWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                total = quantity * 2.5;
                Console.WriteLine($"{total:f2}");
                break;
            case "apple":
                total = quantity * 1.2;
                Console.WriteLine($"{total:f2}");
                break;
            case "orange":
                total = quantity * 0.85;
                Console.WriteLine($"{total:f2}");
                break;
            case "grapefruit":
                total = quantity * 1.45;
                Console.WriteLine($"{total:f2}");
                break;
            case "kiwi":
                total = quantity * 2.7;
                Console.WriteLine($"{total:f2}");
                break;
            case "pineapple":
                total = quantity * 5.5;
                Console.WriteLine($"{total:f2}");
                break;
            case "grapes":
                total = quantity * 3.85;
                Console.WriteLine($"{total:f2}");
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                total = quantity * 2.7;
                Console.WriteLine($"{total:f2}");
                break;
            case "apple":
                total = quantity * 1.25;
                Console.WriteLine($"{total:f2}");
                break;
            case "orange":
                total = quantity * 0.9;
                Console.WriteLine($"{total:f2}");
                break;
            case "grapefruit":
                total = quantity * 1.6;
                Console.WriteLine($"{total:f2}");
                break;
            case "kiwi":
                total = quantity * 3;
                Console.WriteLine($"{total:f2}");
                break;
            case "pineapple":
                total = quantity * 5.6;
                Console.WriteLine($"{total:f2}");
                break;
            case "grapes":
                total = quantity * 4.2;
                Console.WriteLine($"{total:f2}");
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}