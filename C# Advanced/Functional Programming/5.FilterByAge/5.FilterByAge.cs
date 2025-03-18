List<Person> people = new List<Person>(); 
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] person = Console.ReadLine().Split(", ");
    people.Add(new Person(person[0], int.Parse(person[1])));
}
string condition = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
Func<Person, bool> predicate = null;
if (condition == "younger")
{
    predicate = p => p.Age < age;
}
else if (condition == "older")
{
    predicate = p => p.Age >= age;
}
people = people.Where(predicate).ToList();
string format = Console.ReadLine();
Action<Person> action = null;
if (format == "name")
{
    action = p => Console.WriteLine(p.Name);
}
else if (format == "age")
{
    action = p => Console.WriteLine(p.Age);
}
else if (format == "name age")
{
    action = p => Console.WriteLine($"{p.Name} - {p.Age}");
}
people.ForEach(action);
public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}