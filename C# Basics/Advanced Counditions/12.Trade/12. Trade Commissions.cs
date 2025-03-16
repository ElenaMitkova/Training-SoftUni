string town = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double percent = 0.0;
double total = 0.0;
switch (town)
{
    case "Sofia":
        if (sales < 0)
        {
            Console.WriteLine("error");
            break;
        }
        else if (sales >= 0 && sales <= 500) percent = 5;
        else if (sales > 500 && sales <= 1000) percent = 7;
        else if (sales > 1000 && sales <= 10000) percent = 8;
        else percent = 12;
        total = sales * percent / 100;
        Console.WriteLine($"{total:f2}");
        break;
    case "Varna":
        if (sales < 0)
        {
            Console.WriteLine("error");
            break;
        }
        else if (sales >= 0 && sales <= 500) percent = 4.5;
        else if (sales > 500 && sales <= 1000) percent = 7.5;
        else if (sales > 1000 && sales <= 10000) percent = 10;
        else percent = 13;
        total = sales * percent / 100;
        Console.WriteLine($"{total:f2}");
        break;
    case "Plovdiv":
        if (sales < 0)
        {
            Console.WriteLine("error");
            break;
        }
        else if (sales >= 0 && sales <= 500) percent = 5.5;
        else if (sales > 500 && sales <= 1000) percent = 8;
        else if (sales > 1000 && sales <= 10000) percent = 12;
        else percent = 14.5;
        total = sales * percent / 100;
        Console.WriteLine($"{total:f2}");
        break;
    default:
        Console.WriteLine("error");
        break;
}