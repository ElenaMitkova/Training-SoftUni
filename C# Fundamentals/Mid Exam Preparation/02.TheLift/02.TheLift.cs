int waitingPeople = int.Parse(Console.ReadLine());
List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int sumOfWagons = wagons.Count * 4;
for (int i = 0; i < wagons.Count && waitingPeople > 0; i++)
{
	if (wagons[i] < 4)
	{
		for (int j = wagons[i]; j < 4 && waitingPeople > 0; j++)
		{
			wagons[i]++;
			waitingPeople--;
		}
	}
}
if (waitingPeople > 0)
{
    Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
}
else if (wagons.Sum() < sumOfWagons)
{
    Console.WriteLine("The lift has empty spots!");
}
Console.WriteLine(string.Join(' ', wagons));