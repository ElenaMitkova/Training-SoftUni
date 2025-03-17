string text = Console.ReadLine();
if (text.Length % 2 == 0)
{
    Console.WriteLine(ReturnTwoStings(text));
    return;
}
Console.WriteLine(ReturnOneSting(text));
static string ReturnTwoStings(string text)
{
    string output = "";
    for (int i = text.Length / 2 - 1; i <= text.Length / 2; i++)
    {
        output += text[i];
    }
    return output;
}
static char ReturnOneSting(string text)
{
    return text[text.Length / 2];
}