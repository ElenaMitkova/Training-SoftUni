Queue<string> customers = new Queue<string>();
int count = 0;
string command;
while ((command = Console.ReadLine()) != "End")
{
    if (command == "Paid")
    {
        while (customers.Count > 0)
        {
            Console.WriteLine(customers.Dequeue());
        }
        count = 0;
    }
    else
    {
        customers.Enqueue(command);
        count++;
    }
}
Console.WriteLine($"{count} people remaining.");