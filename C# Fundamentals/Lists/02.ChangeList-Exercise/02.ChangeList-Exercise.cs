List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] command = commands.Split();
	if (command[0] == "Delete")
	{
		int searchedNumber = int.Parse(command[1]);
		for (int i = 0; i < numbers.Count; i++)
		{
			if (numbers[i] == searchedNumber)
			{
				numbers.RemoveAt(i);
				i--;
			}
		}
	}
	else if (command[0] == "Insert")
	{
		int insertedNumber = int.Parse(command[1]);
		int position = int.Parse(command[2]);
		numbers.Insert(position, insertedNumber);
	}
}
Console.WriteLine(string.Join(" ", numbers));