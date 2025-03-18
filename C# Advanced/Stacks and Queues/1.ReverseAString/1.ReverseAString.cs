string input = Console.ReadLine();
Stack<char> reversed = new Stack<char>();
for (int i = 0; i < input.Length; i++)
{
    reversed.Push(input[i]);
}
Console.WriteLine(string.Join("", reversed));