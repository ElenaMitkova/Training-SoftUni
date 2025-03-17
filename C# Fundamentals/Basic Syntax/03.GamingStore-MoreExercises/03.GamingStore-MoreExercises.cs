double balance = double.Parse(Console.ReadLine());
double balanceCopy = balance;
string game = Console.ReadLine();
while (game != "Game Time")
{
    if (balance == 0)
    {
        Console.WriteLine("Out of money!");
        return;
    }
    switch (game)
	{
		case "OutFall 4":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 39.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 39.99;
            }
            else Console.WriteLine("Too Expensive");
			break;
		case "CS: OG":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 15.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 15.99;
            }
            else Console.WriteLine("Too Expensive");
            break;
		case "Zplinter Zell":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 19.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 19.99;
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "Honored 2":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 59.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 59.99;
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "RoverWatch":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 29.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 29.99;
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "RoverWatch Origins Edition":
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (balance >= 39.99)
            {
                Console.WriteLine($"Bought {game}");
                balance -= 39.99;
            }
            else Console.WriteLine("Too Expensive");
            break;
        default:
            Console.WriteLine("Not Found");
			break;
	}
    game = Console.ReadLine();
}
if (balance == 0)
{
    Console.WriteLine("Out of money!");
    return;
}
Console.WriteLine($"Total spent: ${balanceCopy - balance:F2}. Remaining: ${balance:F2}");