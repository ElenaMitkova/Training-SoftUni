List<Student> students = new List<Student>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] currentStudents = Console.ReadLine().Split();
    Student student = new Student(currentStudents[0], currentStudents[1], double.Parse(currentStudents[2]));
    students.Add(student);
}
students = students.OrderByDescending(grade => grade.Grade).ToList();
foreach (Student student in students)
{
    Console.WriteLine(student);
}
class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}