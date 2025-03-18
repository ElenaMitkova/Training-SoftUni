string text = Console.ReadLine();
string result = text[0].ToString();
for (int i = 1; i < text.Length; i++)
{
    if (text[i] != text[i - 1])
    {
        result += text[i];
    }
}
Console.WriteLine(result);