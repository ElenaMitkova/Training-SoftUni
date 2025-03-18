using System.Text.RegularExpressions;

string pattern = @"\+359[- ]2[ -]\d{3}[ -]\d{4}";
string numbers = Console.ReadLine();
MatchCollection matches = Regex.Matches(numbers, pattern);
var phones = matches.Cast<Match>().Select(phone => phone.Value.Trim()).ToArray();
Console.WriteLine(string.Join(", ", phones));