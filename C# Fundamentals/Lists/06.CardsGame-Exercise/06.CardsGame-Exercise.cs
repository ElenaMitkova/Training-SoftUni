List<int> firstCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> secondCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
while (firstCards.Count > 0 && secondCards.Count > 0)
{
    int firstCard = firstCards[0];
    int secondCard = secondCards[0];
	if (firstCard > secondCard)
	{
		firstCards.RemoveAt(0);
		secondCards.RemoveAt(0);
		firstCards.Add(secondCard);
        firstCards.Add(firstCard);
    }
    else if (secondCard > firstCard) 
    {
        firstCards.RemoveAt(0);
        secondCards.RemoveAt(0);
        secondCards.Add(firstCard);
        secondCards.Add(secondCard);
    }
    else
    {
        firstCards.RemoveAt(0);
        secondCards.RemoveAt(0);
    }
}
if (firstCards.Count == 0)
{
    Console.WriteLine($"Second player wins! Sum: {secondCards.Sum()}");
    return;
}
Console.WriteLine($"First player wins! Sum: {firstCards.Sum()}");