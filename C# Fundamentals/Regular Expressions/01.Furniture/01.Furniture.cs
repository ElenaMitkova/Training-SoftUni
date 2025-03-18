using System.Text.RegularExpressions;

string broughts = "";
decimal total = 0.0m;
string pattern = @">>(?<Name>[A-Z]+[a-z]*)<<(?<Price>\d+[.\d]+)!(?<Quantity>\d*)";
string input;
while ((input = Console.ReadLine()) != "Purchase")
{
        broughts += input + " ";
}
MatchCollection matches = Regex.Matches(broughts, pattern);
Console.WriteLine($"Bought furniture:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Groups["Name"]);
    total += decimal.Parse(match.Groups["Price"].ToString()) * decimal.Parse(match.Groups["Quantity"].ToString());
}
Console.WriteLine($"Total money spend: {total:F2}");