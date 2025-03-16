double age = double.Parse(Console.ReadLine());
char femaleOrMale = char.Parse(Console.ReadLine());
switch (femaleOrMale)
{
	case 'm':
		if (age >= 16) Console.WriteLine("Mr.");
		else Console.WriteLine("Master");
		break;
	case 'f':
		if (age >= 16) Console.WriteLine("Ms.");
		else Console.WriteLine("Miss");
		break;
}