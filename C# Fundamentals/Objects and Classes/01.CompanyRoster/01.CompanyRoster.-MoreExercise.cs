List<Employee> employees = new List<Employee>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] arguments = Console.ReadLine().Split();
    Employee employee = new Employee(arguments[0], double.Parse(arguments[1]), arguments[2]);
    employees.Add(employee);
}
var bestDepartment = employees.OrderByDescending(e => e.Salary).FirstOrDefault().Department;
Console.WriteLine($"Highest Average Salary: {bestDepartment}");
var departmentPeople = employees.Where(department => department.Department == bestDepartment).OrderByDescending(salary => salary.Salary);
foreach (var employee in departmentPeople)
{
    Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
}
class Employee
{
    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
}