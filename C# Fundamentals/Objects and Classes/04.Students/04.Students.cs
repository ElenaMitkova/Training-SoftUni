List<Student> listOfStudents = new List<Student>();
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] person = command.Split();
    Student student = new Student();
    student.FirstName = person[0];
    student.SecondName = person[1];
    student.Age = int.Parse(person[2]);
    student.HomeTown = person[3];
    listOfStudents.Add(student);
}
string homeTown = Console.ReadLine();
foreach (Student student in listOfStudents)
{
    if (student.HomeTown == homeTown)
    {
        Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
    }
}
class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}