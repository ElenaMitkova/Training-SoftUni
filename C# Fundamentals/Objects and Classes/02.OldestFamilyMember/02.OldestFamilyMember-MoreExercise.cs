Family family = new Family();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] arguments = Console.ReadLine().Split();
    Person person = new Person(arguments[0], int.Parse(arguments[1]));
    family.AddMember(person);
}
Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Family
{
    public Family()
    {
        Persons = new List<Person>();
    }
    public List<Person> Persons { get; set; }
    public void AddMember(Person member)
    {
        Persons.Add(member);
    }
    public Person GetOldestMember()
    {
        return Persons.OrderByDescending(person => person.Age).First();
    }
}