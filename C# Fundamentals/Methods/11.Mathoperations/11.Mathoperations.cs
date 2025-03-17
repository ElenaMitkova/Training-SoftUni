int firstNumber = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine(GetResult(firstNumber, operation, secondNumber));
static int GetResult(int firstNumber, char operation, int secondNumber)
{
    if (operation == '+')
    {
        return firstNumber + secondNumber;
    }
    else if(operation == '-')
    {
        return Math.Abs(secondNumber - firstNumber);
    }
    else if(operation == '*')
    {
        return firstNumber * secondNumber;
    }
    else
    {
        return firstNumber / secondNumber;
    }
}