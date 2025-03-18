using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
MatchCollection matches = Regex.Matches(text, pattern);
foreach (Match name in matches)
{
    Console.Write(name + " ");
}
Console.WriteLine();