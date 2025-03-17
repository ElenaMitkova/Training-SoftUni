double grade = double.Parse(Console.ReadLine());
GetGradeWord(grade);
static void GetGradeWord(double grade)
{
    if (grade is >= 2.00 and <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if (grade is >= 3.00 and <= 3.49)
    {
        Console.WriteLine("Poor");
    }
    else if (grade is >= 3.50 and <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (grade is >= 4.50 and <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}