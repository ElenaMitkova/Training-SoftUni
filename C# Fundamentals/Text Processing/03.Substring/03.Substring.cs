string searchedString = Console.ReadLine();
string text = Console.ReadLine();
while (text.Contains(searchedString))
{
    text = text.Remove(text.IndexOf(searchedString), searchedString.Length);
}
Console.WriteLine(text);