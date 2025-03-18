int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string student = arguments[0];
    decimal grade = decimal.Parse(arguments[1]);
    if (!grades.ContainsKey(student))
    {
        grades.Add(student, new List<decimal>());
    }
    grades[student].Add(grade);
}
foreach ((string student, List<decimal> grade) in grades)
{
    Console.Write($"{student} -> ");
    foreach (decimal grading in grade)
    {
        Console.Write($"{grading:f2} ");
    }
    Console.WriteLine($"(avg: {grade.Average():f2})");
}