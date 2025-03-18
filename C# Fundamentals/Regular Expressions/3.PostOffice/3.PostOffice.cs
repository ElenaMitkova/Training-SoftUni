using System.Text.RegularExpressions;

string regex1 = @"([#$%*&])(?<code>[A-Z]+)\1";
string regex2 = @"(?<letter>[0-9]{2}):(?<length>[0-9]{2})";
string[] inputArr = Console.ReadLine().Split('|');
string firstPart = inputArr[0];
string secondPart = inputArr[1];
string thirdPart = inputArr[2];
var pattern1 = new Regex(regex1);
var matcher1 = pattern1.Match(firstPart);
List<string> matcher2List = new List<string>();
if (matcher1.Success)
{
    string code = matcher1.Groups["code"].Value;
    var pattern2 = new Regex(regex2);
    var matcher2 = pattern2.Matches(secondPart);
    foreach (Match match in matcher2)
    {
        matcher2List.Add(match.Value);
    }
    foreach (char symbol in code)
    {
        bool isFound = false;
        foreach (string matcher in matcher2List)
        {
            int codeOfLetter = int.Parse(matcher.Split(':')[0]);
            int length = int.Parse(matcher.Split(':')[1]) + 1;
            foreach (string word in thirdPart.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                string firstLetter = word.Substring(0, 1);
                if (firstLetter == symbol.ToString())
                {
                    if (symbol == codeOfLetter && word.Length == length)
                    {
                        Console.WriteLine(word);
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                break;
            }
        }
    }
}