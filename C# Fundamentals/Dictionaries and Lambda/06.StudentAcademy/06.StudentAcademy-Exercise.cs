Dictionary<string, List<double>> gradesByPerson = new Dictionary<string, List<double>>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    if (!gradesByPerson.ContainsKey(name))
    {
        gradesByPerson.Add(name, new List<double>());
    }
    gradesByPerson[name].Add(grade);
}
foreach (var person in gradesByPerson.Where(person => person.Value.Average() >= 4.5))
{
    Console.WriteLine($"{person.Key} -> {person.Value.Average():F2}");
}