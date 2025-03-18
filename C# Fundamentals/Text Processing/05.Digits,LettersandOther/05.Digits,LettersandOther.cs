string text = Console.ReadLine();
string digits = "";
string leters = "";
string others = "";
for (int i = 0; i < text.Length; i++)
{
    if (char.IsDigit(text[i]))
    {
        digits += text[i];
    }
    else if (char.IsLetter(text[i]))
    {
        leters += text[i];
    }
    else
    {
        others += text[i];
    }
}
Console.WriteLine(digits);
Console.WriteLine(leters);
Console.WriteLine(others);