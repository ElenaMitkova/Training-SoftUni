Dictionary<string,List<string>> courses = new Dictionary<string,List<string>>();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split(" : ");
    if (!courses.ContainsKey(arguments[0]))
    {
        courses.Add(arguments[0], new List<string>());
    }
    courses[arguments[0]].Add(arguments[1]);
}
foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    foreach (var list in course.Value)
    {
        Console.WriteLine($"-- {list}");
    }
}