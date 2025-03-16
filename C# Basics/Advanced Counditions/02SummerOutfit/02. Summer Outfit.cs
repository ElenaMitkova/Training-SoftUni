int degrees = int.Parse(Console.ReadLine());
string partOfTheDay = Console.ReadLine();
string outfit, shoes;
if (degrees >= 10 && degrees <= 18)
{
	switch (partOfTheDay)
	{
		case "Morning":
			outfit = "Sweatshirt";
			shoes = "Sneakers";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
			break;
		case "Afternoon":
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
    }
}
else if (degrees > 18 && degrees <= 24)
{
    switch (partOfTheDay)
    {
        case "Morning":
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
    }
}
else
{
    switch (partOfTheDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
    }
}