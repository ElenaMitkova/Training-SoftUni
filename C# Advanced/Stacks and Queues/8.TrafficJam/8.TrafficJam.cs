Queue<string> cars = new Queue<string>();
int passing = int.Parse(Console.ReadLine());
int count = 0;
string command;
while ((command = Console.ReadLine()) != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < passing; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            count++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}
Console.WriteLine($"{count} cars passed the crossroads.");