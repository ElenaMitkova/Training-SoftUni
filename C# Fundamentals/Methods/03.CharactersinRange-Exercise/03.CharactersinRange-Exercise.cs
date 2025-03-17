char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
Characters(startChar, endChar);
static void Characters(char startChar, char endChar)
{
    string output = "";
    if (startChar > endChar)
    {
        for (int i = endChar + 1; i < startChar; i++)
        {
            output += (char)i + " ";
        }
        Console.WriteLine(output.Trim(' '));
        return;
    }
    for (int i = startChar + 1; i < endChar; i++)
    {
        output += (char)i + " ";
    }
    Console.WriteLine(output.Trim(' '));
}