int price = int.Parse(Console.ReadLine());
int size = int.Parse(Console.ReadLine());
Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int intelligence = int.Parse(Console.ReadLine());
int count = 0;
int bulletsFired = 0;
while (bullets.Count > 0 && locks.Count > 0)
{
    int bullet = bullets.Pop();
    bulletsFired++;
    count++;
    if (bullet <= locks.Peek())
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }
    if (count == size && bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
        count = 0;
    }
}
if (locks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
    int earnings = intelligence - (bulletsFired * price);
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${Math.Max(0, earnings)}");
}