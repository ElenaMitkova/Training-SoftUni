List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
bool isChanged = false;
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
            isChanged = true;
            break;
        case "Remove":
            int removeNumber = int.Parse(commands[1]);
            if (numbers.Contains(removeNumber))
            {
                numbers.Remove(removeNumber);
            }
            isChanged = true;
            break;
        case "RemoveAt":
            int removeIndex = int.Parse(commands[1]);
            numbers.RemoveAt(removeIndex);
            isChanged = true;
            break;
        case "Insert":
            int insertNumber = int.Parse(commands[1]);
            int insertIndex = int.Parse(commands[2]);
            numbers.Insert(insertIndex, insertNumber);
            isChanged = true;
            break;
        case "Contains":
            int containsNumber = int.Parse(commands[1]);
            if (numbers.Contains(containsNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;
        case "PrintEven":
            int numEven = 0;
            Console.WriteLine(OutputPrint(numbers, numEven));
            break;
        case "PrintOdd":
            int numOdd = 1;
            Console.WriteLine(OutputPrint(numbers, numOdd));
            break;
        case "GetSum":
            Console.WriteLine(numbers.Sum());
            break;
        case "Filter":
            string condition = commands[1];
            int filterNumber = int.Parse(commands[2]);
            string output = "";
            if (condition.Length == 1 && condition[0] == '>')
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > filterNumber)
                    {
                        output += numbers[i] + " ";
                    }
                }
            }
            else if(condition.Length == 1 && condition[0] == '<')
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < filterNumber)
                    {
                        output += numbers[i] + " ";
                    }
                }
            }
            else if (condition.Length == 2 && condition[0] == '>')
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= filterNumber)
                    {
                        output += numbers[i] + " ";
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= filterNumber)
                    {
                        output += numbers[i] + " ";
                    }
                }
            }
            Console.WriteLine(output.Trim());
            break;
    }
}
if (isChanged)
{
    Console.WriteLine(string.Join(' ', numbers));
}
static string OutputPrint(List<int> numbers, int deli)
{
    string output = "";
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 == deli)
        {
            output += numbers[i] + " ";
        }
    }
    return output.Trim();
}