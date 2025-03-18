using System.Text.RegularExpressions;

string pattern = @"\b(?<Day>\d{2})([-.\/])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
string dates = Console.ReadLine();
MatchCollection matches = Regex.Matches(dates, pattern);
foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
}