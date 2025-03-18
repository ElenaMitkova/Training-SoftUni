string[] people = Console.ReadLine().Split();
Dictionary<string, Func<string, string, bool>> commandsByCriteria = new Dictionary<string, Func<string, string, bool>>()
{
    ["StartsWith"] = (x, y) => x.StartsWith(y),
    ["EndsWith"] = (x, y) => x.EndsWith(y),
    ["Length"] = (x, y) => x.Length.ToString() == y,
};
string command;
while ((command = Console.ReadLine()) != "Party!" && people.Length > 0)
{
    string[] arguments = command.Split();
    string action = arguments[0];
    string criteria = arguments[1];
    string argument = arguments[2];
    List<string> resulted = new List<string>();
    if (action == "Remove")
    {
        for (int i = 0; i < people.Length; i++)
        {
            if (!commandsByCriteria[criteria](people[i], argument))
            {
                resulted.Add(people[i]);
            }
        }
    }
    else
    {
        for (int i = 0; i < people.Length; i++)
        {
            if (commandsByCriteria[criteria](people[i], argument))
            {
                resulted.Add(people[i]);
            }
            resulted.Add(people[i]);
        }
    }
    people = resulted.ToArray();
}
if (people.Length == 0)
{
    Console.WriteLine("Nobody is going to the party!");
}
else
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}