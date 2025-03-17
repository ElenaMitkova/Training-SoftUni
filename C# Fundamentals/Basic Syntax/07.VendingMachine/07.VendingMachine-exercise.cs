string inputMoney = Console.ReadLine();
double wallet = 0.0;
while(inputMoney != "Start")
{
    if (inputMoney != "0.1" && inputMoney != "0.2" && inputMoney != "0.5" && inputMoney != "1" && inputMoney != "2")
        Console.WriteLine($"Cannot accept {inputMoney}");
    else wallet += double.Parse(inputMoney);
    inputMoney = Console.ReadLine();
}
string inputProduct = Console.ReadLine();
while (inputProduct != "End")
{
    switch (inputProduct)
    {
        case "Nuts":
            if (wallet >= 2.0)
            {
                Console.WriteLine("Purchased nuts");
                wallet -= 2.0;
            }
            else Console.WriteLine("Sorry, not enough money");
            break;
        case "Water":
            if (wallet >= 0.7)
            {
                Console.WriteLine("Purchased water");
                wallet -= 0.7;
            }
            else Console.WriteLine("Sorry, not enough money");
            break;
        case "Crisps":
            if (wallet >= 1.5)
            {
                Console.WriteLine("Purchased crisps");
                wallet -= 1.5;
            }
            else Console.WriteLine("Sorry, not enough money");
            break;
        case "Soda":
            if (wallet >= 0.8)
            {
                Console.WriteLine("Purchased soda");
                wallet -= 0.8;
            }
            else Console.WriteLine("Sorry, not enough money");
            break;
        case "Coke":
            if (wallet >= 1.0)
            {
                Console.WriteLine("Purchased coke");
                wallet -= 1.0;
            }
            else Console.WriteLine("Sorry, not enough money");
            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }
    inputProduct = Console.ReadLine();
}
Console.WriteLine($"Change: {wallet:F2}");