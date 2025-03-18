Stack<string> text = new Stack<string>();
text.Push(string.Empty);
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
	string previous = text.Peek();
	switch (int.Parse(command[0]))
	{
		case 1:
			string append = command[1];
			text.Push(previous + append);
			break;
		case 2:
			int count = int.Parse(command[1]);
			text.Push(previous.Substring(0, previous.Length - count));
			break;
		case 3:
			int index = int.Parse(command[1]);
			Console.WriteLine(previous[index - 1]);
			break;
		case 4:
			text.Pop();
			break;
	}
}