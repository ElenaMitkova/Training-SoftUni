int firstNumber = int.Parse(Console.ReadLine());
int secondiNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine(SubtractOfMethodAndThird(firstNumber, secondiNumber, thirdNumber));
static int SumOfFirstAndSecond(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
static int SubtractOfMethodAndThird(int firstNumber, int secondNumber, int thirdNumber)
{
    return SumOfFirstAndSecond(firstNumber, secondNumber) - thirdNumber;
}