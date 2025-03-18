string input = Console.ReadLine();
Dictionary<char, char> balanced = new Dictionary<char, char>
{
    ['('] = ')',
    ['['] = ']',
    ['{'] = '}'
};
Stack<char> brackets = new Stack<char>();
bool valid = true;
for (int i = 0; i < input.Length; i++)
{
    if (balanced.ContainsKey(input[i]))
    {
        brackets.Push(balanced[input[i]]);
    }
    else
    {
        if (brackets.Count > 0 && input[i] == brackets.Peek())
        {
            brackets.Pop();
        }
        else
        {
            valid = false;
        }
    }
}
if (valid && brackets.Count == 0)
{
    Console.WriteLine("YES");
    return;
}
Console.WriteLine("NO");