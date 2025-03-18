string[] input = Console.ReadLine().Split();
Stack<string> operations = new Stack<string>(input.Reverse());
int sum = int.Parse(operations.Pop());
while (operations.Count > 0)
{
    string operation = operations.Pop();
    int number = int.Parse(operations.Pop());
    if (operation == "+")
    {
        sum += number;
    }
    else
    {
        sum -= number;
    }
}
Console.WriteLine(sum);