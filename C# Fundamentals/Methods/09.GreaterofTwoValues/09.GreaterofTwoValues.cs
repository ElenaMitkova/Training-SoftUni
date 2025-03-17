string type = Console.ReadLine();
if (type == "int")
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine(GetMaxInt(firstNumber, secondNumber));
}
else if (type == "char")
{
    char firstChar = char.Parse(Console.ReadLine());
    char secondChar = char.Parse(Console.ReadLine());
    Console.WriteLine(GetMaxChar(firstChar, secondChar));
}
else
{
    string firstString = Console.ReadLine();
    string secondString = Console.ReadLine();
    Console.WriteLine(GetMaxString(firstString, secondString));
}
static int GetMaxInt(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return firstNumber;
    }
    else
    {
        return secondNumber;
    }
}
static char GetMaxChar(char firstChar, char secondChar)
{
    if (firstChar > secondChar)
    {
        return firstChar;
    }
    else
    {
        return secondChar;
    }
}
static string GetMaxString(string firstString, string secondString)
{
    int output = firstString.CompareTo(secondString);
    if (output == 1)
    {
        return firstString;
    }
    else
    {
        return secondString;
    }
}