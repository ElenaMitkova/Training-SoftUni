Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
while (songs.Count > 0)
{
    string[] command = Console.ReadLine().Split();
	switch (command[0])
	{
		case "Play":
			songs.Dequeue();
			break;
		case "Add":
			string newsong = "";
			for (int i = 1; i < command.Length; i++)
			{
				newsong += command[i];
			}
			if (songs.Contains(newsong))
			{
				Console.WriteLine($"{newsong} is already contained!");
			}
			else
			{
				songs.Enqueue(newsong);
			}
			break;
		case "Show":
            Console.WriteLine(string.Join(", ", songs));
			break;
    }
}
Console.WriteLine("No more songs!");