Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
string command;
while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] arguments = command.Split();
    if (arguments[0] == "add")
    {
        numbers.Push(int.Parse(arguments[1]));
        numbers.Push(int.Parse(arguments[2]));
    }
    else
    {
        if (numbers.Count >= int.Parse(arguments[1]))
        {
            for (int i = 0; i < int.Parse(arguments[1]); i++)
            {
                numbers.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {numbers.Sum()}");