List<Student> listOfStudents = new List<Student>();
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] person = command.Split();
    Student student = new Student();
    if (IsExisting(listOfStudents, person))
    {
        student = GetStudent(listOfStudents, person);
        student.Age = int.Parse(person[2]);
        student.HomeTown = person[3];
    }
    else
    {
        student.FirstName = person[0];
        student.SecondName = person[1];
        student.Age = int.Parse(person[2]);
        student.HomeTown = person[3];
        listOfStudents.Add(student);
    }
}
string homeTown = Console.ReadLine();
foreach (Student student in listOfStudents)
{
    if (student.HomeTown == homeTown)
    {
        Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
    }
}
static bool IsExisting(List<Student> students, string[] input)
{
    foreach (Student student in students)
    {
        if (student.FirstName == input[0] && student.SecondName == input[1])
        {
            return true;
        }
    }
    return false;
}
static Student GetStudent (List<Student> students, string[] input)
{
    Student thisStudent = null;
    foreach (Student student in students)
    {
        if (student.FirstName == input[0] && student.SecondName == input[1])
        {
            thisStudent = student;
        }
    }
    return thisStudent;
}
class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}