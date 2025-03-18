List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] commands = input.Split();
    string command = commands[0];
    switch (command)
    {
        case "Add":
            int addNumber = int.Parse(commands[1]);
            numbers.Add(addNumber);
            break;
        case "Remove":
            int removeNumber = int.Parse(commands[1]);
            if (numbers.Contains(removeNumber))
            {
                numbers.Remove(removeNumber);
            }
            break;
        case "RemoveAt":
            int removeIndex = int.Parse(commands[1]);
            numbers.RemoveAt(removeIndex);
            break;
        case "Insert":
            int insertNumber = int.Parse(commands[1]);
            int insertIndex = int.Parse(commands[2]);
            numbers.Insert(insertIndex, insertNumber);
            break;
    }
}
Console.WriteLine(string.Join(' ', numbers));