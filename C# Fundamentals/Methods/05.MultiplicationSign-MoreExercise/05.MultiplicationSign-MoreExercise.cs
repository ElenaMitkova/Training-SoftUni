int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine(GetMultiplicationSign(firstNumber, secondNumber, thirdNumber));
static string GetMultiplicationSign(int firstNumber, int secondNumber, int thirdNumber)
{
    int countMinuses = 0;
    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
    {
        return "zero";
    }
    else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
    {
        if (firstNumber < 0)
        {
            countMinuses++;
        }
        if (secondNumber < 0)
        {
            countMinuses++;
        }
        if (thirdNumber < 0)
        {
            countMinuses++;
        }
        if (countMinuses == 1 || countMinuses == 3)
        {
            return "negative";
        }
        return "positive";
    }
    else
    {
        return "positive";
    }
}