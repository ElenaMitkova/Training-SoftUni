List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int capacityOfEachWagon = int.Parse(Console.ReadLine());
string commands;
while ((commands = Console.ReadLine()) != "end")
{
	string[] command = commands.Split();
	switch (command[0])
	{
		case "Add":
			int newWagon = int.Parse(command[1]);
			wagons.Add(newWagon);
			break;
		default:
			int passengers = int.Parse(command[0]);
			for (int i = 0; i < wagons.Count; i++)
			{
				if (passengers + wagons[i] <= capacityOfEachWagon)
				{
					wagons[i] += passengers;
					break;
				}
			}
			break;
	}
}
Console.WriteLine(string.Join(' ', wagons));