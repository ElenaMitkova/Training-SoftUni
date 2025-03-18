using System.Text.RegularExpressions;

List<string> names = Console.ReadLine().Split(", ").ToList();
string input;
Dictionary<string, int> output = new Dictionary<string, int>();
while ((input = Console.ReadLine()) != "end of race")
{
    string name = string.Concat(Regex.Matches(input, @"[A-Za-z]").Select(x => x.Value));
    int distance = Regex.Matches(input, @"\d").Sum(x => int.Parse(x.Value));
    if (output.ContainsKey(name) && names.Contains(name))
    {
        output[name] += distance;
    }
    else if (!output.ContainsKey(name) && names.Contains(name))
    {
        output[name] = distance;
    }
}
var namesPlaces = output.OrderByDescending(x => x.Value).Take(3).ToList();
for (int i = 0; i < namesPlaces.Count; i++)
{
    string place = i switch
    {
        0 => "1st",
        1 => "2nd",
        2 => "3rd"
    };
    Console.WriteLine($"{place} place: {namesPlaces[i].Key}");
}