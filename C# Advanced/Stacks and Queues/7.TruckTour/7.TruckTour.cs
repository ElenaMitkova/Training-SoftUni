int n = int.Parse(Console.ReadLine());
Queue<(int fuel, int distance)> stations = new Queue<(int fuel, int distance)>();
for (int i = 0; i < n; i++)
{
    int[] station = Console.ReadLine().Split().Select(int.Parse).ToArray();
    stations.Enqueue((station[0], station[1]));
}
for (int i = 0;i < n; i++)
{
    int gas = 0;
    bool found = true;
    foreach ((int fuel, int distance) station in stations)
    {
        gas += station.fuel;
        if (gas < station.distance)
        {
            found = false;
            break;
        }
        gas -= station.distance;
    }
    if (found)
    {
        Console.WriteLine(i);
        return;
    }
    (int fuel, int distance) current = stations.Dequeue();
    stations.Enqueue(current);
}