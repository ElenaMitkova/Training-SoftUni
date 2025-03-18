using System.Text;
using System.Text.RegularExpressions;

int key = int.Parse(Console.ReadLine());
var data = new List<string>();
string input;
while ((input = Console.ReadLine()) != "end")
{
    data.Add(input);
}
var decryptList = new List<string>();
var template = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[G|N])!");
foreach (var line in data)
{
    var decrypted = new StringBuilder();
    foreach (var character in line)
    {
        char decryptedChar = (char)(character - key);
        decrypted.Append(decryptedChar);
    }
    decryptList.Add(decrypted.ToString());
}
var result = new List<string>();
foreach (var element in decryptList)
{
    var match = template.Match(element);
    if (!match.Success) continue;
    var name = match.Groups["name"].Value;
    var behavior = match.Groups["behavior"].Value;
    if (behavior == "G")
    {
        result.Add(name);
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result));