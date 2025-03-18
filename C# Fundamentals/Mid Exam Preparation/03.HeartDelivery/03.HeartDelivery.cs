List<int> neighbourhood = Console.ReadLine().Split('@').Select(int.Parse).ToList();
string command;
int position = 0;
int count = 0;
while ((command = Console.ReadLine()) != "Love!")
{
    string[] commands = command.Split();
	if (commands[0] == "Jump")
	{
        for (int i = position; i < neighbourhood.Count; i++)
        {
            int jumps = int.Parse(commands[1]);
            if (jumps + i > neighbourhood.Count - 1)
            {
                i = 0;
                neighbourhood[i] -= 2;
                if (neighbourhood[i] <= -2)
                {
                    Console.WriteLine($"Place {i} already had Valentine's day.");
                    neighbourhood[i] = 0;
                    position = i;
                    i = neighbourhood.Count;
                    continue;
                }
                Console.WriteLine($"Place {i} has Valentine's day.");
                count++;
                neighbourhood[i] = 0;
                position = i;
                i = neighbourhood.Count;
                continue;
            }
            if (neighbourhood[i + jumps] <= 0)
            {
                Console.WriteLine($"Place {i + jumps} already had Valentine's day.");
                neighbourhood[i] = 0;
                position = i;
                i = neighbourhood.Count;
                continue;
            }
            else
            {
                neighbourhood[i + jumps] -= 2;
                position = i + jumps;
                if (neighbourhood[i + jumps] <= 0)
                {
                    Console.WriteLine($"Place {i + jumps} has Valentine's day.");
                    neighbourhood[i + jumps] = 0;
                    count++;
                    i = neighbourhood.Count;
                    continue;
                }
            }
            i = neighbourhood.Count;
        }
    }
}
Console.WriteLine($"Cupid's last position was {position}.");
if (neighbourhood.Sum() == 0)
{
    Console.WriteLine("Mission was successful.");
    return;
}
Console.WriteLine($"Cupid has failed {neighbourhood.Count - count} places.");