long filedSize = long.Parse(Console.ReadLine());
long[] filed = new long[filedSize];
int[] ladyBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
for (int i = 0; i < ladyBugs.Length; i++)
{
	if (ladyBugs[i] >= 0 && ladyBugs[i] < filed.Length)
	{
        int p = ladyBugs[i];
		filed[p] = 1;
	}
}
string command;
while ((command = Console.ReadLine())!="end")
{
	string[] bugsCommands = command.Split(' ');
	int indexBug = int.Parse(bugsCommands[0]);
	string direction = bugsCommands[1];
	int steps = int.Parse(bugsCommands[2]);
	if (indexBug<0||indexBug>=filed.Length)
	{
		continue;
	}
	if (filed[indexBug] == 1)
	{
        int landIndex = 0;
		filed[indexBug] = 0;
        if (direction == "left")
        {
		    landIndex = indexBug - steps;
            if (landIndex < 0)
            {
                continue;
            }
            while (filed[landIndex] == 1)
			{
				landIndex -= steps;
                if (landIndex < 0)
                {
                    break;
                }
            }
            if (landIndex < 0)
            {
                continue;
            }
            filed[landIndex] = 1;
        }
        if (direction == "right")
        {
            landIndex = indexBug + steps;
            if (landIndex >= filed.Length)
            {
                continue;
            }
            while (filed[landIndex] == 1)
            {
                landIndex += steps;
                if (landIndex > filed.Length - 1)
                {
                    break;
                }
            }
            if (landIndex >= filed.Length)
            {
                continue;
            }
            filed[landIndex] = 1;
        }
    }
}
Console.WriteLine(string.Join(" ",filed));