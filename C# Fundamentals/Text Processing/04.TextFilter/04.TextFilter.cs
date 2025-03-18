string[] filter = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
for (int i = 0; i < filter.Length; i++)
{
	while (text.Contains(filter[i]))
	{
		text = text.Replace(filter[i], new string('*', filter[i].Length));
	}
}
Console.WriteLine(text);