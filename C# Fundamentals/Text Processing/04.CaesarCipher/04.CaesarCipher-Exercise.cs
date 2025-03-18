string text = Console.ReadLine();
string enc = string.Empty;
for (int i = 0; i < text.Length; i++)
{
    enc += (char)(text[i] + 3);
}
Console.WriteLine(enc);