int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
{
    int res = Math.Min(firstNumber, secondNumber);
    return Math.Min(res, thirdNumber);
}