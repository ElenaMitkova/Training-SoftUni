Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
int n = int.Parse(Console.ReadLine());
int tick = 1;
while (kids.Count > 1)
{
    string kid = kids.Dequeue();
    if (tick == n)
    {
        Console.WriteLine($"Removed {kid}");
        tick = 0;
    }
    else
    {
        kids.Enqueue(kid);
    }
    tick++;
}
Console.WriteLine($"Last is {kids.Dequeue()}");