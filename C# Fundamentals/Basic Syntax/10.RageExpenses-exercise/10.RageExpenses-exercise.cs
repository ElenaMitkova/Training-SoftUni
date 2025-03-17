int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());
int keyboard = 0;
double expenses = 0.0;
int games = 1;
while(games <= lostGamesCount)
{
	if (games % 2 == 0) expenses += headsetPrice;
	if (games % 3 == 0) expenses += mousePrice;
	if (games % 2 == 0 && games % 3 == 0)
	{
		expenses += keyboardPrice;
		keyboard++;
        if (keyboard % 2 == 0) expenses += displayPrice;
    }
	games++;
}
Console.WriteLine($"Rage expenses: {expenses:F2} lv.");