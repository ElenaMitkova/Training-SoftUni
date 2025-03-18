int food = int.Parse(Console.ReadLine());
Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
Console.WriteLine(orders.Max());
while (orders.Count > 0)
{
    int order = orders.Peek();
    if (order <= food)
    {
        orders.Dequeue();
        food -= order;
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
        return;
    }
}
Console.WriteLine("Orders complete");