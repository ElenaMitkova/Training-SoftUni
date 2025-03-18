List<Person> people = new List<Person>();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] arguments = input.Split();
    Person newPerson = people.FirstOrDefault(person => person.Id == int.Parse(arguments[1]));
    if (newPerson != null)
    {
        newPerson.Age = int.Parse(arguments[2]);
        newPerson.Name = arguments[0];
    }
    else
    {
        people.Add(new Person(arguments[0], int.Parse(arguments[1]), int.Parse(arguments[2])));
    }
}
people = people.OrderBy(person => person.Age).ToList();
foreach (var person in people)
{
    Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
}
class Person
{
    public Person(string name, int id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }
    public string Name { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }
}