string input = Console.ReadLine();
Stack<int> brackets = new Stack<int>();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        brackets.Push(i);
    }
    else if (input[i]== ')')
    {
        int opened = brackets.Pop();
        Console.WriteLine(input.Substring(opened, i - opened + 1));
    }
}