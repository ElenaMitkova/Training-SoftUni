Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
int rackCappasity = int.Parse(Console.ReadLine());
int remaining = 0;
int racks = 1;
while (clothes.Count > 0)
{
	int cloth = clothes.Peek();
	if (remaining + cloth <= rackCappasity)
	{
		remaining += cloth;
		clothes.Pop();
	}
	else
	{
		remaining = cloth;
		racks++;
		clothes.Pop();
	}
}
Console.WriteLine(racks);